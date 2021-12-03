using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mark_Attendance_UI
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void lblHowTo_Click(object sender, EventArgs e)
        {
            string ins = "1) Click on -  Open Marking Sheet Location (.csv)\n2) Copy - Markings.csv\n3) Paste it anywhere you want";
            MessageBox.Show(ins, "How to get the marked attendance sheet?");
        }

        private void btnAddNewFace_Click(object sender, EventArgs e)
        {
            try
            {
                Add_Image obj = (Add_Image)Application.OpenForms["Add_Image"];
                if (obj != null)
                {
                    obj.Show();
                }
                else
                {
                    obj = new Add_Image();
                    obj.Show();
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

        private void btnStartFaceScanner_Click(object sender, EventArgs e)
        {
            try
            {
                PathHelp mainDir = new PathHelp();
                var imPath = mainDir.getMainPath() + "FaceRecognition\\ResourceImages";
                if (!Directory.Exists(imPath))
                {
                    Directory.CreateDirectory(imPath);
                    MessageBox.Show("Resource Image Folder is Empty!\nAdd Face Images First.", "Warning!");
                }
                else if (Directory.GetFiles(imPath).Length == 0)
                {
                    MessageBox.Show("Resource Image Folder is Empty!\nAdd Face Images First.", "Warning!");
                }
                else
                {
                    // Create process info
                    var processStrtInf = new ProcessStartInfo();
                    string venvLoc = mainDir.getMainPath() + "venv\\Scripts\\python.exe";
                    processStrtInf.FileName = venvLoc;

                    // Provide scripts and args
                    var scriptLoc = mainDir.getMainPath() + "FaceRecognition\\FaceRecognition.py";
                    processStrtInf.Arguments = $"\"{scriptLoc}\"";

                    // Process configuration
                    processStrtInf.UseShellExecute = false;
                    processStrtInf.CreateNoWindow = true;
                    processStrtInf.RedirectStandardOutput = true;
                    processStrtInf.RedirectStandardError = false;

                    //Process.Start(processStrtInf);

                    // Starting the process in a new thread
                    ThreadStart ths = new ThreadStart(() => Process.Start(processStrtInf));
                    Thread th = new Thread(ths);
                    th.Start();
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

        private void btnOpenImgDir_Click(object sender, EventArgs e)
        {
            try
            {
                PathHelp obj = new PathHelp();
                var mainDir = obj.getMainPath() + "FaceRecognition\\ResourceImages";
                if (!Directory.Exists(mainDir))
                {
                    Directory.CreateDirectory(mainDir);
                    Process.Start("explorer.exe", mainDir);
                }
                else
                {
                    Process.Start("explorer.exe", mainDir);
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

        private void btnOpenCSVDir_Click(object sender, EventArgs e)
        {
            try
            {
                PathHelp obj = new PathHelp();
                var mainDir = obj.getMainPath() + "FaceRecognition\\Attendance Sheet";
                Process.Start("explorer.exe", mainDir);
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

        private void btnClearOld_Click(object sender, EventArgs e)
        {
            try {
                PathHelp obj = new PathHelp();
                var csvDir = obj.getMainPath() + "FaceRecognition\\Attendance Sheet\\Markings.csv";
                File.WriteAllBytes(csvDir, new byte[] { 0 });
                File.WriteAllText(csvDir, "Reg_Number,Time");

                MessageBox.Show("Records Cleared!", "Done");
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

        private void lblHowTo_MouseEnter(object sender, EventArgs e)
        {
            lblHowTo.ForeColor = Color.BlueViolet;
        }

        private void btnStartFaceScanner_MouseEnter(object sender, EventArgs e)
        {
            btnStartFaceScanner.ForeColor = Color.White;
        }

        private void btnStartFaceScanner_MouseLeave(object sender, EventArgs e)
        {
            btnStartFaceScanner.ForeColor = Color.Black;
        }

        private void btnAddNewFace_MouseEnter(object sender, EventArgs e)
        {
            btnAddNewFace.ForeColor = Color.White;
        }

        private void btnAddNewFace_MouseLeave(object sender, EventArgs e)
        {
            btnAddNewFace.ForeColor = Color.Black;
        }

        private void btnOpenImgDir_MouseEnter(object sender, EventArgs e)
        {
            btnOpenImgDir.ForeColor = Color.White;
        }

        private void btnOpenImgDir_MouseLeave(object sender, EventArgs e)
        {
            btnOpenImgDir.ForeColor = Color.Black;
        }

        private void btnOpenCSVDir_MouseEnter(object sender, EventArgs e)
        {
            btnOpenCSVDir.ForeColor = Color.White;
        }

        private void btnOpenCSVDir_MouseLeave(object sender, EventArgs e)
        {
            btnOpenCSVDir.ForeColor = Color.Black;
        }

        private void btnClearOld_MouseEnter(object sender, EventArgs e)
        {
            btnClearOld.ForeColor = Color.White;
        }

        private void btnClearOld_MouseLeave(object sender, EventArgs e)
        {
            btnClearOld.ForeColor = Color.Black;
        }

        private void lblHowTo_MouseLeave(object sender, EventArgs e)
        {
            lblHowTo.ForeColor = Color.White;
        }
    }
}
