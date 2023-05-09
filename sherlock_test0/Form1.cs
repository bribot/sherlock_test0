using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sherlock_test0
{
    public partial class Form1 : Form
    {
        IpeEngCtrlLib.Engine hSherlock;
        IpeEngCtrlLib.I_ENG_ERROR nReturn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hSherlock = null;
            try
            {
                hSherlock = new IpeEngCtrlLib.Engine();
            }
            catch (Exception)
            {
                MessageBox.Show("Error imicializando", "Error", MessageBoxButtons.OK);
                throw;
            }

            if (hSherlock != null)
            {
                try
                {
                    nReturn = hSherlock.EngInitialize();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error imicializando 2", "Error", MessageBoxButtons.OK);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("hSherlock != null", "Error", MessageBoxButtons.OK);
            }
            if (nReturn != IpeEngCtrlLib.I_ENG_ERROR.I_OK)
            {
                MessageBox.Show("Error imicializando 3", "Error", MessageBoxButtons.OK);
            }

            nReturn = hSherlock.InvLoad("C:\\ProgramData\\Teledyne DALSA\\Sherlockx64\\Programs\\Simple0.ivs");

            axIpeDspCtrl1.ConnectEngine(hSherlock.GetEngineObj());
            axIpeDspCtrl1.ConnectImgWindow("imgA");
        }
    }
}
