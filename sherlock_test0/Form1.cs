using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            this.WindowState = FormWindowState.Maximized;
            //this.MinimumSize = this.Size;
            //this.MaximumSize = this.Size;

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
            try
            {
                nReturn = hSherlock.InvLoad("20230516.ivs");
            }
            catch (Exception)
            {
                MessageBox.Show("Sherlock file not found!", "Error", MessageBoxButtons.OK);
            }

            pnlMedida1.Hide();
            pnlMedida2.Hide();
            pnlMedida3.Hide();
            pnlMedida4.Hide();
            pnlMedida5.Hide();
            pnlMedida6.Hide();


            axIpeDspCtrl1.ConnectEngine(hSherlock.GetEngineObj());
            axIpeDspCtrl2.ConnectEngine(hSherlock.GetEngineObj());

            axIpeDspCtrl1.ConnectImgWindow("IMG_Backlight_Viales");
            axIpeDspCtrl2.ConnectImgWindow("IMG_Darkfield_Viales");
            
            axIpeDspCtrl1.SetZoom(0);
            axIpeDspCtrl2.SetZoom(0);
            nReturn = hSherlock.InvModeSet(IpeEngCtrlLib.I_MODE.I_EXE_MODE_CONT);
        }

        private void axIpeDspCtrl1_OverlayDraw(object sender, AxIpeDspCtrlLib._DIpeDspCtrlEvents_OverlayDrawEvent e)
        {
            double medicion1_sherlock, medicion2_sherlock, medicion3_sherlock, medicion4_sherlock, medicion6_sherlock, medicion5_sherlock;
            Array pass1_sherlock, pass2_sherlock, pass3_sherlock, pass4_sherlock, pass5_sherlock, pass6_sherlock;

            nReturn = hSherlock.VarGetDouble("Medicion1", out medicion1_sherlock);
            nReturn = hSherlock.VarGetDouble("Medicion2", out medicion2_sherlock);
            nReturn = hSherlock.VarGetDouble("Medicion3", out medicion3_sherlock);
            nReturn = hSherlock.VarGetDouble("Medicion4", out medicion4_sherlock);
            nReturn = hSherlock.VarGetDouble("Medicion5", out medicion5_sherlock);
            nReturn = hSherlock.VarGetDouble("Medicion6", out medicion6_sherlock);
 
            outString0.Text = medicion1_sherlock.ToString("#.##");
            outString1.Text = medicion2_sherlock.ToString("#.##");
            outString2.Text = medicion3_sherlock.ToString("#.##");
            outString3.Text = medicion4_sherlock.ToString("#.##");
            outString4.Text = medicion5_sherlock.ToString("#.##");
            outString5.Text = medicion6_sherlock.ToString("#.##");

            nReturn = hSherlock.VarGetDoubleArray("Medicion1_pass", out pass1_sherlock);
            nReturn = hSherlock.VarGetDoubleArray("Medicion2_pass", out pass2_sherlock);
            nReturn = hSherlock.VarGetDoubleArray("Medicion3_pass", out pass3_sherlock);
            nReturn = hSherlock.VarGetDoubleArray("Medicion4_pass", out pass4_sherlock);
            nReturn = hSherlock.VarGetDoubleArray("Medicion5_pass", out pass5_sherlock);
            nReturn = hSherlock.VarGetDoubleArray("Medicion6_pass", out pass6_sherlock);

            
            pnlMedida1.BackColor = checkTolerance((double)pass1_sherlock.GetValue(0), (double)pass1_sherlock.GetValue(1), medicion1_sherlock);
            pnlMedida2.BackColor = checkTolerance((double)pass2_sherlock.GetValue(0), (double)pass2_sherlock.GetValue(1), medicion2_sherlock);
            pnlMedida3.BackColor = checkTolerance((double)pass3_sherlock.GetValue(0), (double)pass3_sherlock.GetValue(1), medicion3_sherlock);
            pnlMedida4.BackColor = checkTolerance((double)pass4_sherlock.GetValue(0), (double)pass4_sherlock.GetValue(1), medicion4_sherlock);
            pnlMedida5.BackColor = checkTolerance((double)pass5_sherlock.GetValue(0), (double)pass5_sherlock.GetValue(1), medicion5_sherlock);
            pnlMedida6.BackColor = checkTolerance((double)pass6_sherlock.GetValue(0), (double)pass6_sherlock.GetValue(1), medicion6_sherlock);
            


        }

        private Color checkTolerance(double max, double min, double measure)
        {
            if(measure < max && measure > min)
            {
                return Color.FromArgb(46, 51, 73);
            }
            else
            {
                return Color.FromArgb(246, 51, 73);
            }
            
        } 

        private void axIpeDspCtrl2_OverlayDraw(object sender, AxIpeDspCtrlLib._DIpeDspCtrlEvents_OverlayDrawEvent e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnVial_Click(object sender, EventArgs e)
        {
            btnVial.BackColor = Color.FromArgb(46, 51, 73);

            pnlMedida1.Show();
            pnlMedida2.Show();
            pnlMedida3.Show();
            pnlMedida4.Show();
            pnlMedida5.Show();
            pnlMedida6.Show();
            axIpeDspCtrl1.Show();
            axIpeDspCtrl2.Show();

            nReturn = hSherlock.VarSetDouble("Model_0", 1.0);

            axIpeDspCtrl1.ConnectImgWindow("IMG_Backlight_Viales");
            axIpeDspCtrl2.ConnectImgWindow("IMG_Darkfield_Viales");

            diagram.Image = Properties.Resources.diagram_vial;

        }

        private void btnGreylid_Click(object sender, EventArgs e)
        {
            btnGreylid.BackColor = Color.FromArgb(46, 51, 73);

            pnlMedida1.Show();
            pnlMedida2.Show();
            pnlMedida3.Show();
            pnlMedida4.Show();
            pnlMedida5.Show();
            pnlMedida6.Hide();
            axIpeDspCtrl1.Show();
            axIpeDspCtrl2.Show();

            nReturn = hSherlock.VarSetDouble("Model_0", 2.0);

            axIpeDspCtrl1.ConnectImgWindow("IMG_Backlight_GrayLid");
            axIpeDspCtrl2.ConnectImgWindow("IMG_Darkfield_GrayLid");

            diagram.Image = Properties.Resources.diagram_graylid;
        }

        private void btnCasquillo_Click(object sender, EventArgs e)
        {
            btnCasquillo.BackColor = Color.FromArgb(46, 51, 73);

            pnlMedida1.Show();
            pnlMedida2.Show();
            pnlMedida3.Hide();
            pnlMedida4.Hide();
            pnlMedida5.Hide();
            pnlMedida6.Hide();
            axIpeDspCtrl1.Show();
            axIpeDspCtrl2.Show();

            nReturn = hSherlock.VarSetDouble("Model_0", 3.0);

            axIpeDspCtrl1.ConnectImgWindow("IMG_Backlight_Casquillo");
            axIpeDspCtrl2.ConnectImgWindow("IMG_Darkfield_Casquillo");

            diagram.Image = Properties.Resources.diagram_casquillo;
        }
        private void btnVial_Leave(object sender, EventArgs e)
        {
            btnVial.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnGreylid_Leave(object sender, EventArgs e)
        {
            btnGreylid.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCasquillo_Leave(object sender, EventArgs e)
        {
            btnCasquillo.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnEtiquetas_Click(object sender, EventArgs e)
        {
            btnEtiquetas.BackColor = Color.FromArgb(46, 51, 73);

            pnlMedida1.Show();
            pnlMedida2.Show();
            pnlMedida3.Hide();
            pnlMedida4.Hide();
            pnlMedida5.Hide();
            pnlMedida6.Hide();
            axIpeDspCtrl1.Show();
            axIpeDspCtrl2.Hide();

            nReturn = hSherlock.VarSetDouble("Model_0", 4.0);

            axIpeDspCtrl1.ConnectImgWindow("IMG_Etiqueta");
            axIpeDspCtrl2.ConnectImgWindow("IMG_Darkfield_Casquillo");

            diagram.Image = Properties.Resources.diagram_casquillo;
        }

        private void btnEtiquetas_Leave(object sender, EventArgs e)
        {
            btnEtiquetas.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
