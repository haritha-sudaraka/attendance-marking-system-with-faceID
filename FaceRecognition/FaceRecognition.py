# importing necessary libraries (opencv-python, numpy, face_recognition, os, datetime
import sys
import cv2  # for computer vision
import numpy as np  # for calculations
import face_recognition as fr  # find encodings of faces and compare them
import os  # interact with files
from datetime import datetime  # get current time for marking attendance

try:
    workingDir = os.getcwd()  # getting current working directory for calling files
    workingDir = format(workingDir)
    workingDir += '\\'

    # A function to find encodings of faces from a particular image list and return them
    def findFaceEncodes(imageList):
        encode_list = []  # encodings of faces
        for image in imageList:  # list of source images
            image = cv2.cvtColor(image, cv2.COLOR_BGR2RGB)  # changing color format from BGR to RGB
            encodes = fr.face_encodings(image)[0]  # getting first value of face encodings
            encode_list.append(encodes)  # appending value to encode list
        return encode_list

    # A function to write image name and the attended time on a comma separated value file (.csv)
    def markAttendance(name):
        with open(workingDir+'FaceRecognition\Attendance Sheet\Markings.csv', 'r+') as f:  # Opening .csv file for reading and writing purposes
            data_list = f.readlines()  # reading records in the .csv file and list to data_list[]
            name_list = []  # creating a list to check whether the name is already marked or not
            for line in data_list:  # loop through every value in data_list[] (.csv file) and append them to name_list[]
                record = line.split(',')
                name_list.append(record[0])
            if name not in name_list:  # if the value in the parameter "name" does not exist in the name_list[]
                current_time = datetime.now()
                time_format = current_time.strftime('%H:%M:%S')
                f.writelines(f'\n{name}, {time_format}')  # write name and the current time inside the .csv file


    # listing the source images of students and image names for marking purposes
    path = workingDir+'FaceRecognition\ResourceImages'
    sourceImages = []  # sourceImages[] - images list
    imageNames = []  # imageNames[] - image names list
    dirContents = os.listdir(path)  # listing image names inside the defined path ResourceImages
    print(dirContents)
    for dc in dirContents:  # loop through each image to list the image and the name
        currentImage = cv2.imread(f'{path}/{dc}')
        sourceImages.append(currentImage)  # append current image file into sourceImages[]
        imageNames.append(os.path.splitext(dc)[0])  # append image name into imageNames[] without file extension
    print(imageNames)

    sourceImageEncodings = findFaceEncodes(sourceImages)  # find and list the encodings
    print('Encoding Complete')

    camCapture = cv2.VideoCapture(0)  # capturing the video from web camera (0 for 1st camera, 1 for second camera)

    while True:  # live video from a web camera or a video is just a sequence of images. using infinite loop to show
        # web cam video

        success, capturedImage = camCapture.read()  # read() returns 2 values
        # success of each frame, each frame of the video per an iteration
        scaledImage = cv2.resize(capturedImage, (0, 0), None, 0.25, 0.25)  # scaling down the image to quarter size
        scaledImage = cv2.cvtColor(scaledImage, cv2.COLOR_BGR2RGB)  # converting the color mode of the frame from BGR to RGB

        currentFrameFaces = fr.face_locations(scaledImage)  # finding faces in the current frame
        currentFrameEncodes = fr.face_encodings(scaledImage, currentFrameFaces)  # find encodings and measurements in the current frame

        for faceEncodes, faceLocations in zip(currentFrameEncodes, currentFrameFaces):  # loop through faces and compare them
            # comparing and listing source face encodes and current face encode. returns bool value
            faceMatch = fr.compare_faces(sourceImageEncodings, faceEncodes, 0.5)
            # finding and listing face landmark distances between source and current faces. lower is better and best match
            lmDistance = fr.face_distance(sourceImageEncodings, faceEncodes)
            # print(lmDistance, faceMatch)
            # finding index of minimum distance value inside lmDistance list
            faceMatchIndex = np.argmin(lmDistance)

            if faceMatch[faceMatchIndex]:  # checking correspond value for faceMatchIndex in faceMatch list
                avatarName = imageNames[faceMatchIndex]  # giving image name for identified name
                # print(avatarName)
                # putting image name on the face in webcam video
                y1, x2, y2, x1 = faceLocations
                y1, x2, y2, x1 = y1 * 4, x2 * 4, (y2 * 4) + 40, x1 * 4
                cv2.rectangle(capturedImage, (x1, y1), (x2, y2), (0, 255, 0), 2)
                cv2.rectangle(capturedImage, (x1, y2 - 40), (x2, y2), (0, 255, 0), cv2.FILLED)
                cv2.putText(capturedImage, avatarName, (x1 + 5, y2 - 7), cv2.FONT_HERSHEY_PLAIN, 1, (255, 255, 255), 2)
                markAttendance(avatarName)

            else:  # drawing a red rectangle on the face if the face is not identified
                y1, x2, y2, x1 = faceLocations
                y1, x2, y2, x1 = y1 * 4, x2 * 4, (y2 * 4) + 40, x1 * 4
                cv2.rectangle(capturedImage, (x1, y1), (x2, y2), (0, 0, 255), 2)

        cv2.rectangle(capturedImage, (0, 0), (320, 30), (255, 255, 255), cv2.FILLED)
        cv2.putText(capturedImage, 'Press \"Q\" to exit', (10, 25), cv2.FONT_HERSHEY_PLAIN, 2, (0, 0, 0), 2)

        # showing the finalized output on the window
        cv2.imshow('WebCam Feed', capturedImage)
        
        # to stop that infinite loop in need, press esc key and then break the loop
        if cv2.waitKey(1) & 0xFF == ord('q'):
            break

    # cleaning up
    cv2.destroyAllWindows()
    camCapture.stop()

except KeyboardInterrupt:  # handling the KeyboardInterrupt Exception
    print('KeyboardInterrupt Exception')

except:
    print("Exception Occurred")
