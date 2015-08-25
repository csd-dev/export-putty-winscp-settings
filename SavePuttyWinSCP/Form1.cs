using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavePuttyWinSCP
{
    public partial class ExportForm : Form
    {
        private SaveFileDialog savePutty;
        private SaveFileDialog saveWinSCP;

        public ExportForm()
        {
            InitializeComponent();
        }

        private void btnExpPutty_Click(object sender, EventArgs e)
        {
            savePutty = new SaveFileDialog();
            savePutty.Title = "Save Registry File";
            savePutty.FileName = "Putty.reg";
            savePutty.Filter = "Registry files|*.reg";
            savePutty.InitialDirectory = @"C:\";
            if (savePutty.ShowDialog() == DialogResult.OK)
            {

                String fileName = savePutty.FileName.ToString();
                String cmd = "/e \""+ fileName + "\" HKEY_CURRENT_USER\\Software\\SimonTatham";

                System.Diagnostics.Process regeditProcess = System.Diagnostics.Process.Start("regedit.exe", cmd);
                regeditProcess.WaitForExit();


                MessageBox.Show("Registry Exported.");
                Console.WriteLine(cmd);
            }
        }

        private void btnExpWinSCP_Click(object sender, EventArgs e)
        {
            saveWinSCP = new SaveFileDialog();
            saveWinSCP.Title = "Save Registry File";
            saveWinSCP.FileName = "WinSCP.reg";
            saveWinSCP.Filter = "Registry files|*.reg";
            saveWinSCP.InitialDirectory = @"C:\";
            if (saveWinSCP.ShowDialog() == DialogResult.OK)
            {

                String fileName = saveWinSCP.FileName.ToString();
                String cmd = "/e \"" + fileName + "\" \"HKEY_CURRENT_USER\\Software\\Martin Prikryl\"";

                System.Diagnostics.Process regeditProcess = System.Diagnostics.Process.Start("regedit.exe", cmd);
                regeditProcess.WaitForExit();


                MessageBox.Show("Registry Exported.");
                Console.WriteLine(cmd);
            }
        }
    }
}
