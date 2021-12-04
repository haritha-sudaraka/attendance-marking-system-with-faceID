import face_recognition as fr
import cv2
import os

try:
    workingDir = os.getcwd()
    workingDir = format(workingDir)

    workingDir += '\\bridge.txt'

    with open(workingDir, 'r+') as f:
        path = f.readlines()[0]

    image = fr.load_image_file(path)
    image = cv2.cvtColor(image, cv2.COLOR_BGR2RGB)
        
    if image.shape[0] > 800 or image.shape[1] > 800:
        image = cv2.resize(image, (0, 0), None, 0.25, 0.25)

    faceLocations = fr.face_locations(image)
    if not faceLocations:
        with open(workingDir, 'w') as f:
            f.writelines('false')

        cv2.rectangle(image, (0, 0), (image.shape[1], image.shape[0]), (255, 255, 255), cv2.FILLED)
        cv2.putText(image, 'No Faces Detected', (20, 100), cv2.FONT_HERSHEY_PLAIN, 1.7, (0, 0, 255), 2)
        cv2.imshow('Added Image', image)
        cv2.waitKey(0)
        exit(-1)

    else:
        with open(workingDir, 'w') as f:
            f.writelines('true')

        faceLocations = fr.face_locations(image)[0]
        cv2.rectangle(image, (faceLocations[3], faceLocations[0]), (faceLocations[1], faceLocations[2]), (0, 255, 0), 3)

        cv2.imshow('Added Image', image)
        cv2.waitKey(0)

except:
    print("Exception Occurred")
