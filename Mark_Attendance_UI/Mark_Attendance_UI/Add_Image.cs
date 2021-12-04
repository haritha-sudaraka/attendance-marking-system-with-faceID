using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

namespace Mark_Attendance_UI
{
    public partial class Add_Image : Form
    {
        public Add_Image()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddFace_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)| *.jpg; *.jpeg; *.gif; *.bmp;";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    lblImageLocation.Text = open.FileName;
                    picBoxPreview.Image = new Bitmap(open.FileName);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                PathHelp pName = new PathHelp();
                string dirPath = pName.getMainPath() + "FaceRecognition\\ResourceImages";

                if (picBoxPreview.Image != null)
                {
                    if (!Directory.Exists(dirPath))
                    {
                        Directory.CreateDirectory(dirPath);
                        saveImage(dirPath);
                    }
                    else
                    {
                        saveImage(dirPath);
                    }
                }
                else
                {
                    MessageBox.Show("No Image Selected!", "Warning");
                }
            }
            catch (Exception ex)
            {
                if (ex.ToString().Contains("UnauthorizedAccessException"))
                {
                    MessageBox.Show(ex.Message + "\nTry Running Your Program as an Administrator!", "Error");
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void btnCheckFaces_Click(object sender, EventArgs e)
        {
            try
            {
                if (picBoxPreview.Image != null)
                {
                    PathHelp imPath = new PathHelp();
                    imPath.sendText(lblImageLocation.Text);

                    PathHelp mainDir = new PathHelp();

                    // Create process info
                    var processStartInfo = new ProcessStartInfo();
                    string venvLoc = mainDir.getMainPath() + "venv\\Scripts\\python.exe";
                    processStartInfo.FileName = venvLoc;

                    // Provide scripts and args
                    var scriptLoc = mainDir.getMainPath() + "FaceRecognition\\CheckFaces.py";
                    processStartInfo.Arguments = $"\"{scriptLoc}\"";

                    // Process configuration
                    processStartInfo.UseShellExecute = false;
                    processStartInfo.CreateNoWindow = true;
                    processStartInfo.RedirectStandardOutput = true;
                    processStartInfo.RedirectStandardError = true;

                    var process = Process.Start(processStartInfo);
                    process.StandardError.ReadToEnd();
                    process.StandardOutput.ReadToEnd();
                }
                else
                {
                    MessageBox.Show("First Select a Picture With a Face", "Warning");
                }
            }
            catch(Exception ex)
            {
                if (ex.ToString().Contains("UnauthorizedAccessException"))
                {
                    MessageBox.Show(ex.Message + "\nTry Running Your Program as an Administrator!", "Error");
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.ForeColor = Color.White;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.ForeColor = Color.Black;
        }

        private void btnCheckFaces_MouseEnter(object sender, EventArgs e)
        {
            btnCheckFaces.ForeColor = Color.White;
        }

        private void btnCheckFaces_MouseLeave(object sender, EventArgs e)
        {
            btnCheckFaces.ForeColor = Color.Black;
        }

        private void saveImage(string dest)
        {
            try
            {
                PathHelp mp = new PathHelp();
                string path = mp.getMainPath() + "bridge.txt";
                string bridgeValue = System.IO.File.ReadAllText(path);

                if (bridgeValue == "true" || bridgeValue == "false")
                {
                    bool isFaceDetected = Convert.ToBoolean(bridgeValue);
                    if (isFaceDetected)
                    {
                        FileInfo fi = new FileInfo(lblImageLocation.Text);
                        string ext = fi.Extension;
                        if (textBoxRename.Text == string.Empty)
                        {
                            File.Copy(lblImageLocation.Text, Path.Combine(dest, Path.GetFileName(lblImageLocation.Text)), true);
                        }
                        else
                        {
                            File.Copy(lblImageLocation.Text, (dest + "\\" + textBoxRename.Text + ext), true);
                        }


                        DialogResult msgBxImSave = MessageBox.Show("Image saved!", "Done", MessageBoxButtons.OK);
                        if (msgBxImSave == DialogResult.OK)
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Select an Image With a Clear Face!", "No Face Detected");
                        mp.sendText(string.Empty);
                    }
                }
                else
                {
                    MessageBox.Show("Please check your image for faces\nClick on \"Check This Image for Faces\"", "Warning");
                }

            }

            catch (Exception ex)
            {
                if (ex.ToString().Contains("UnauthorizedAccessException"))
                {
                    MessageBox.Show(ex.Message + "\nTry Running Your Program as an Administrator!", "Error");
                }
                else
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void Add_Image_FormClosing(object sender, FormClosingEventArgs e)
        {
            PathHelp ph = new PathHelp();
            ph.sendText(string.Empty);
        }
    }
}
