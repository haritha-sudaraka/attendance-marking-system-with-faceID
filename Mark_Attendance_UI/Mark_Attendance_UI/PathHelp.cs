using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mark_Attendance_UI
{
    public class PathHelp
    {
        public string getMainPath()
        {
            return Directory.GetCurrentDirectory() + '\\';
        }

        public void sendPath(string imgPath)
        {
            try
            {
                var txtDir = getMainPath() + "bridge.txt";
                File.WriteAllText(txtDir, imgPath);
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

        public void clearBridgeTxt()
        {
            try
            {
                var txtDir = getMainPath() + "bridge.txt";
                File.WriteAllBytes(txtDir, new byte[] { 0 });
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
    }
}
