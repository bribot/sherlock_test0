using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Timers;
using System.Diagnostics;

namespace sherlock_test0
{
    public partial class Form1 : Form
    {
        IpeEngCtrlLib.Engine hSherlock;
        IpeEngCtrlLib.I_ENG_ERROR nReturn;
        int currentModel;
        //double modelSherlock = 0;
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
            try
            {
                nReturn = hSherlock.InvLoad("SanofiV01.ivs");
            }
            catch (Exception)
            {
                MessageBox.Show("Sherlock file not found!", "Error", MessageBoxButtons.OK);
            }

            this.WindowState = FormWindowState.Maximized;

            axIpeDspCtrl1.ConnectEngine(hSherlock.GetEngineObj());
            axIpeDspCtrl2.ConnectEngine(hSherlock.GetEngineObj());
            
            nReturn = hSherlock.InvModeSet(IpeEngCtrlLib.I_MODE.I_EXE_MODE_CONT);
            axIpeDspCtrl1.ConnectImgWindow("IMG_Backlight_Viales");
            axIpeDspCtrl2.ConnectImgWindow("IMG_Darkfield_Viales");
            resizeControlPanel();

            System.Timers.Timer timer = new System.Timers.Timer(TimeSpan.FromSeconds(1).TotalMilliseconds);
            timer.AutoReset = true;
            timer.Elapsed += checkUpdate;//new System.Timers.ElapsedEventHandler(updateModel);
            timer.Start();
            //updateModel();
            //System.Threading.Timer timer1 = new System.Threading.Timer(this.checkUpdate, null, 0, 1000);
        }

        private void resizeControlPanel()
        {
            //this.WindowState = FormWindowState.Maximized;
            pnlControl.Width = this.Size.Width / 5;
            axIpeDspCtrl1.Width = this.Width / 2;
            axIpeDspCtrl1.Height = this.Height / 2;
            axIpeDspCtrl1.Location = new Point(0, 0);
            axIpeDspCtrl2.Width = this.Width / 2;
            axIpeDspCtrl2.Height = this.Height / 2;
            axIpeDspCtrl2.Location = new Point(0, this.Height / 2);
            axIpeDspCtrl1.SetZoom(0);
            axIpeDspCtrl2.SetZoom(0);
        }


        private void clearUI()
        {
            pnlMedida1.Hide();
            pnlMedida2.Hide();
            pnlMedida3.Hide();
            pnlMedida4.Hide();
            pnlMedida5.Hide();
            pnlMedida6.Hide();
            btnVial.Hide();
            btnCasquillo.Hide();
            btnGreylid.Hide();
            btnEtiquetas.Hide();
            btnReport.Hide();
            axIpeDspCtrl1.Show();
            axIpeDspCtrl2.Show();
        }

        
        public void checkUpdate(object sender, ElapsedEventArgs e)
        {
            try
            {
                this.Invoke(new Action(updateModel));
            } catch (Exception ex)
            {

            }
            
        }
        

        public void updateModel()
        {
            double modelSherlock;
            Array statusSherlock;
            int statusS = 0;
            bool reportReady;

            //nReturn = hSherlock.VarGetDouble("Model_0", out modelSherlock);

            try
            {
                nReturn = hSherlock.VarGetBool("reportReady", out reportReady);
                //reportready = (int)(double)statusSherlock.GetValue(0);
            }
            catch (Exception ex)
            {
                reportReady = false;
            }

            btnReport.Visible = reportReady;

            try
            {
                nReturn = hSherlock.VarGetDouble("Model_0", out modelSherlock);
            } catch (Exception ex)
            {
                modelSherlock = currentModel;
            }
            
            nReturn = hSherlock.VarGetDoubleArray("Status", out statusSherlock);

            try
            {
                statusS = (int)(double)statusSherlock.GetValue(0);
            }
            catch (Exception ex)
            {
                statusS = 0;
            }


            switch (statusS)
            {
                case 1:
                    labelRunning.Text = "Emergencia";
                    break;
                case 2:
                    labelRunning.Text = "Corriendo";
                    break;
                default:
                    labelRunning.Text = "Detenido";
                    break;
            }
            if(currentModel != (int)modelSherlock)
            {
                currentModel = (int)modelSherlock;
                switch (modelSherlock)
                {
                    case 1:
                        labelStatus.Text = "Vial";
                        axIpeDspCtrl2.Show();
                        axIpeDspCtrl1.ConnectImgWindow("IMG_Backlight_Viales");
                        axIpeDspCtrl2.ConnectImgWindow("IMG_Darkfield_Viales");
                        btnVial.BackColor = Color.FromArgb(46, 51, 73);
                        changeMeasurements(6);
                        break;
                    case 2:
                        labelStatus.Text = "GrayLid";
                        axIpeDspCtrl2.Show();
                        axIpeDspCtrl1.ConnectImgWindow("IMG_Backlight_GrayLid");
                        axIpeDspCtrl2.ConnectImgWindow("IMG_Darkfield_GrayLid");
                        btnGreylid.BackColor = Color.FromArgb(46, 51, 73);
                        changeMeasurements(5);
                        break;
                    case 3:
                        labelStatus.Text = "Casquillo";
                        axIpeDspCtrl2.Show();
                        axIpeDspCtrl1.ConnectImgWindow("IMG_Backlight_Casquillo");
                        axIpeDspCtrl2.ConnectImgWindow("IMG_Darkfield_Casquillo");
                        btnCasquillo.BackColor = Color.FromArgb(46, 51, 73);
                        changeMeasurements(2);
                        break;
                    case 4:
                        labelStatus.Text = "Etiquetas";
                        axIpeDspCtrl2.Hide();
                        axIpeDspCtrl1.ConnectImgWindow("IMG_Etiqueta");
                        btnEtiquetas.BackColor = Color.FromArgb(46, 51, 73);
                        changeMeasurements(2);
                        break;
                    default:
                        labelStatus.Text = modelSherlock.ToString();
                        changeMeasurements(0);
                        break;
                }
            
            }
        }

        private void changeMeasurements(int nMeasurements)
        {
            int totalM = 6;
            Boolean[] visM = { false, false, false, false, false, false };

            if (nMeasurements > totalM)
            {
                nMeasurements = 0;
            } 

            for(int i=0; i < nMeasurements; i++)
            {
                visM[i] = true;
            }

            pnlMedida1.Visible = visM[0];
            pnlMedida2.Visible = visM[1];
            pnlMedida3.Visible = visM[2];
            pnlMedida4.Visible = visM[3];
            pnlMedida5.Visible = visM[4];
            pnlMedida6.Visible = visM[5];
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

            //updateModel();


        }

        private void resetVarsSherlock()
        {
            nReturn = hSherlock.VarSetDouble("Model_0", 0.0);
            nReturn = hSherlock.VarSetDouble("Medicion1", 0.0);
            nReturn = hSherlock.VarSetDouble("Medicion2", 0.0);
            nReturn = hSherlock.VarSetDouble("Medicion3", 0.0);
            nReturn = hSherlock.VarSetDouble("Medicion4", 0.0);
            nReturn = hSherlock.VarSetDouble("Medicion5", 0.0);
            nReturn = hSherlock.VarSetDouble("Medicion6", 0.0);

            return;
        }

        private Color checkTolerance(double max, double min, double measure)
        {
            if (measure < max && measure > min)
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
            //updateModel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hSherlock.EngTerminate();
            Environment.Exit(Environment.ExitCode);
            Close();
            
        }

        private void btnVial_Click(object sender, EventArgs e)
        {
            nReturn = hSherlock.VarSetDouble("Model_0", 1.0);
            


        }

        private void btnGreylid_Click(object sender, EventArgs e)
        {
            nReturn = hSherlock.VarSetDouble("Model_0", 2.0);
         
        }

        private void btnCasquillo_Click(object sender, EventArgs e)
        {
            nReturn = hSherlock.VarSetDouble("Model_0", 3.0);
            
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
            nReturn = hSherlock.VarSetDouble("Model_0", 4.0);
         
        }

        private void btnEtiquetas_Leave(object sender, EventArgs e)
        {
            btnEtiquetas.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //updateModel();
            Array statusSherlock;
            double[] localStatus = { 0 };
            nReturn = hSherlock.VarGetDoubleArray("Status", out statusSherlock);
            
            if((double)statusSherlock.GetValue(0) == 2)
            {
                localStatus[0] = 0;
                btnStop.Text = "Iniciar";
            }
            else
            {
                localStatus[0] = 2;
                btnStop.Text = "Detener";
            }

            nReturn = hSherlock.VarSetDoubleArray("Status",localStatus);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void labelRunning_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Process reportGen = new Process();
            reportGen.StartInfo.FileName = @"C:\\Program Files\\APAAQ\\reportGen\\reportGen.exe";
            reportGen.StartInfo.WorkingDirectory = @"C:\\Program Files\\APAAQ\\reportGen\\";
            //reportGen.StartInfo.Arguments = @"C:\\Users\\Bri\\Documents\\APAAQ\\sanofi 020523\\Report Generator\\Report-Generator-PDF\\reportGen\\config.ini";
            reportGen.Start();
            Cursor.Current = Cursors.WaitCursor;
            reportGen.WaitForExit();
            Cursor.Current = Cursors.Default;
            System.Windows.Forms.MessageBox.Show("reporte generado");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
