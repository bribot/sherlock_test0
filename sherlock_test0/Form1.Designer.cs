
namespace sherlock_test0
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (hSherlock != null)
            {
                hSherlock.EngTerminate();
                hSherlock = null;
            }
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axIpeDspCtrl1 = new AxIpeDspCtrlLib.AxIpeDspCtrl();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMedida1 = new System.Windows.Forms.Panel();
            this.outString0 = new System.Windows.Forms.Label();
            this.axIpeDspCtrl2 = new AxIpeDspCtrlLib.AxIpeDspCtrl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnCasquillo = new System.Windows.Forms.Button();
            this.btnGreylid = new System.Windows.Forms.Button();
            this.btnVial = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMedida2 = new System.Windows.Forms.Panel();
            this.outString1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlMedida3 = new System.Windows.Forms.Panel();
            this.outString2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlMedida4 = new System.Windows.Forms.Panel();
            this.outString3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlMedida5 = new System.Windows.Forms.Panel();
            this.outString4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlMedida6 = new System.Windows.Forms.Panel();
            this.outString5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnEtiquetas = new System.Windows.Forms.Button();
            this.diagram = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.axIpeDspCtrl1)).BeginInit();
            this.pnlMedida1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axIpeDspCtrl2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlMedida2.SuspendLayout();
            this.pnlMedida3.SuspendLayout();
            this.pnlMedida4.SuspendLayout();
            this.pnlMedida5.SuspendLayout();
            this.pnlMedida6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // axIpeDspCtrl1
            // 
            this.axIpeDspCtrl1.Enabled = true;
            this.axIpeDspCtrl1.Location = new System.Drawing.Point(554, 151);
            this.axIpeDspCtrl1.Name = "axIpeDspCtrl1";
            this.axIpeDspCtrl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axIpeDspCtrl1.OcxState")));
            this.axIpeDspCtrl1.Size = new System.Drawing.Size(320, 304);
            this.axIpeDspCtrl1.TabIndex = 0;
            this.axIpeDspCtrl1.OverlayDraw += new AxIpeDspCtrlLib._DIpeDspCtrlEvents_OverlayDrawEventHandler(this.axIpeDspCtrl1_OverlayDraw);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medida 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlMedida1
            // 
            this.pnlMedida1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlMedida1.Controls.Add(this.outString0);
            this.pnlMedida1.Controls.Add(this.label1);
            this.pnlMedida1.ForeColor = System.Drawing.Color.Honeydew;
            this.pnlMedida1.Location = new System.Drawing.Point(248, 96);
            this.pnlMedida1.Name = "pnlMedida1";
            this.pnlMedida1.Size = new System.Drawing.Size(275, 125);
            this.pnlMedida1.TabIndex = 2;
            // 
            // outString0
            // 
            this.outString0.AutoSize = true;
            this.outString0.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outString0.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.outString0.Location = new System.Drawing.Point(22, 55);
            this.outString0.Name = "outString0";
            this.outString0.Size = new System.Drawing.Size(79, 38);
            this.outString0.TabIndex = 2;
            this.outString0.Text = "out1";
            // 
            // axIpeDspCtrl2
            // 
            this.axIpeDspCtrl2.Enabled = true;
            this.axIpeDspCtrl2.Location = new System.Drawing.Point(554, 454);
            this.axIpeDspCtrl2.Name = "axIpeDspCtrl2";
            this.axIpeDspCtrl2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axIpeDspCtrl2.OcxState")));
            this.axIpeDspCtrl2.Size = new System.Drawing.Size(320, 298);
            this.axIpeDspCtrl2.TabIndex = 3;
            this.axIpeDspCtrl2.OverlayDraw += new AxIpeDspCtrlLib._DIpeDspCtrlEvents_OverlayDrawEventHandler(this.axIpeDspCtrl2_OverlayDraw);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.btnEtiquetas);
            this.panel2.Controls.Add(this.btnSettings);
            this.panel2.Controls.Add(this.btnCasquillo);
            this.panel2.Controls.Add(this.btnGreylid);
            this.panel2.Controls.Add(this.btnVial);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 765);
            this.panel2.TabIndex = 4;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(200)))));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.Location = new System.Drawing.Point(0, 721);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(188, 44);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Configuracion";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnCasquillo
            // 
            this.btnCasquillo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCasquillo.FlatAppearance.BorderSize = 0;
            this.btnCasquillo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCasquillo.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCasquillo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(200)))));
            this.btnCasquillo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCasquillo.Location = new System.Drawing.Point(0, 295);
            this.btnCasquillo.Name = "btnCasquillo";
            this.btnCasquillo.Size = new System.Drawing.Size(188, 58);
            this.btnCasquillo.TabIndex = 4;
            this.btnCasquillo.Text = "Casquillo";
            this.btnCasquillo.UseVisualStyleBackColor = true;
            this.btnCasquillo.Click += new System.EventHandler(this.btnCasquillo_Click);
            this.btnCasquillo.Leave += new System.EventHandler(this.btnCasquillo_Leave);
            // 
            // btnGreylid
            // 
            this.btnGreylid.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGreylid.FlatAppearance.BorderSize = 0;
            this.btnGreylid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGreylid.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreylid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(200)))));
            this.btnGreylid.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreylid.Location = new System.Drawing.Point(0, 237);
            this.btnGreylid.Name = "btnGreylid";
            this.btnGreylid.Size = new System.Drawing.Size(188, 58);
            this.btnGreylid.TabIndex = 3;
            this.btnGreylid.Text = "Greylid";
            this.btnGreylid.UseVisualStyleBackColor = true;
            this.btnGreylid.Click += new System.EventHandler(this.btnGreylid_Click);
            this.btnGreylid.Leave += new System.EventHandler(this.btnGreylid_Leave);
            // 
            // btnVial
            // 
            this.btnVial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVial.FlatAppearance.BorderSize = 0;
            this.btnVial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVial.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(200)))));
            this.btnVial.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVial.Location = new System.Drawing.Point(0, 179);
            this.btnVial.Name = "btnVial";
            this.btnVial.Size = new System.Drawing.Size(188, 58);
            this.btnVial.TabIndex = 2;
            this.btnVial.Text = "Vial";
            this.btnVial.UseVisualStyleBackColor = true;
            this.btnVial.Click += new System.EventHandler(this.btnVial_Click);
            this.btnVial.Leave += new System.EventHandler(this.btnVial_Leave);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(188, 179);
            this.panel4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(12, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Interfaz de Inspeccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label4.Location = new System.Drawing.Point(194, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 46);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dashboard";
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1271, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlMedida2
            // 
            this.pnlMedida2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlMedida2.Controls.Add(this.outString1);
            this.pnlMedida2.Controls.Add(this.label3);
            this.pnlMedida2.ForeColor = System.Drawing.Color.Honeydew;
            this.pnlMedida2.Location = new System.Drawing.Point(248, 245);
            this.pnlMedida2.Name = "pnlMedida2";
            this.pnlMedida2.Size = new System.Drawing.Size(275, 125);
            this.pnlMedida2.TabIndex = 2;
            // 
            // outString1
            // 
            this.outString1.AutoSize = true;
            this.outString1.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outString1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.outString1.Location = new System.Drawing.Point(22, 55);
            this.outString1.Name = "outString1";
            this.outString1.Size = new System.Drawing.Size(79, 38);
            this.outString1.TabIndex = 2;
            this.outString1.Text = "out1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 40);
            this.label3.TabIndex = 1;
            this.label3.Text = "Medida 2";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlMedida3
            // 
            this.pnlMedida3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlMedida3.Controls.Add(this.outString2);
            this.pnlMedida3.Controls.Add(this.label2);
            this.pnlMedida3.ForeColor = System.Drawing.Color.Honeydew;
            this.pnlMedida3.Location = new System.Drawing.Point(248, 399);
            this.pnlMedida3.Name = "pnlMedida3";
            this.pnlMedida3.Size = new System.Drawing.Size(275, 125);
            this.pnlMedida3.TabIndex = 2;
            // 
            // outString2
            // 
            this.outString2.AutoSize = true;
            this.outString2.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outString2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.outString2.Location = new System.Drawing.Point(22, 55);
            this.outString2.Name = "outString2";
            this.outString2.Size = new System.Drawing.Size(79, 38);
            this.outString2.TabIndex = 2;
            this.outString2.Text = "out1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medida 3";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlMedida4
            // 
            this.pnlMedida4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlMedida4.Controls.Add(this.outString3);
            this.pnlMedida4.Controls.Add(this.label6);
            this.pnlMedida4.ForeColor = System.Drawing.Color.Honeydew;
            this.pnlMedida4.Location = new System.Drawing.Point(248, 557);
            this.pnlMedida4.Name = "pnlMedida4";
            this.pnlMedida4.Size = new System.Drawing.Size(275, 125);
            this.pnlMedida4.TabIndex = 2;
            // 
            // outString3
            // 
            this.outString3.AutoSize = true;
            this.outString3.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outString3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.outString3.Location = new System.Drawing.Point(22, 55);
            this.outString3.Name = "outString3";
            this.outString3.Size = new System.Drawing.Size(79, 38);
            this.outString3.TabIndex = 2;
            this.outString3.Text = "out1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 40);
            this.label6.TabIndex = 1;
            this.label6.Text = "Medida 4";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlMedida5
            // 
            this.pnlMedida5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlMedida5.Controls.Add(this.outString4);
            this.pnlMedida5.Controls.Add(this.label9);
            this.pnlMedida5.ForeColor = System.Drawing.Color.Honeydew;
            this.pnlMedida5.Location = new System.Drawing.Point(926, 96);
            this.pnlMedida5.Name = "pnlMedida5";
            this.pnlMedida5.Size = new System.Drawing.Size(275, 125);
            this.pnlMedida5.TabIndex = 2;
            // 
            // outString4
            // 
            this.outString4.AutoSize = true;
            this.outString4.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outString4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.outString4.Location = new System.Drawing.Point(22, 55);
            this.outString4.Name = "outString4";
            this.outString4.Size = new System.Drawing.Size(79, 38);
            this.outString4.TabIndex = 2;
            this.outString4.Text = "out1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 40);
            this.label9.TabIndex = 1;
            this.label9.Text = "Medida 5";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlMedida6
            // 
            this.pnlMedida6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlMedida6.Controls.Add(this.outString5);
            this.pnlMedida6.Controls.Add(this.label11);
            this.pnlMedida6.ForeColor = System.Drawing.Color.Honeydew;
            this.pnlMedida6.Location = new System.Drawing.Point(926, 245);
            this.pnlMedida6.Name = "pnlMedida6";
            this.pnlMedida6.Size = new System.Drawing.Size(275, 125);
            this.pnlMedida6.TabIndex = 2;
            // 
            // outString5
            // 
            this.outString5.AutoSize = true;
            this.outString5.Font = new System.Drawing.Font("Arial", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outString5.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.outString5.Location = new System.Drawing.Point(22, 55);
            this.outString5.Name = "outString5";
            this.outString5.Size = new System.Drawing.Size(79, 38);
            this.outString5.TabIndex = 2;
            this.outString5.Text = "out1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 40);
            this.label11.TabIndex = 1;
            this.label11.Text = "Medida 6";
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnEtiquetas
            // 
            this.btnEtiquetas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEtiquetas.FlatAppearance.BorderSize = 0;
            this.btnEtiquetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEtiquetas.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEtiquetas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(200)))));
            this.btnEtiquetas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEtiquetas.Location = new System.Drawing.Point(0, 353);
            this.btnEtiquetas.Name = "btnEtiquetas";
            this.btnEtiquetas.Size = new System.Drawing.Size(188, 58);
            this.btnEtiquetas.TabIndex = 6;
            this.btnEtiquetas.Text = "Etiquetas";
            this.btnEtiquetas.UseVisualStyleBackColor = true;
            this.btnEtiquetas.Click += new System.EventHandler(this.btnEtiquetas_Click);
            this.btnEtiquetas.Leave += new System.EventHandler(this.btnEtiquetas_Leave);
            // 
            // diagram
            // 
            this.diagram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diagram.Location = new System.Drawing.Point(554, 23);
            this.diagram.Name = "diagram";
            this.diagram.Size = new System.Drawing.Size(320, 128);
            this.diagram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.diagram.TabIndex = 7;
            this.diagram.TabStop = false;
            this.diagram.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sherlock_test0.Properties.Resources.paranoiaComp;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1313, 765);
            this.Controls.Add(this.pnlMedida5);
            this.Controls.Add(this.diagram);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.axIpeDspCtrl2);
            this.Controls.Add(this.pnlMedida6);
            this.Controls.Add(this.pnlMedida4);
            this.Controls.Add(this.pnlMedida3);
            this.Controls.Add(this.pnlMedida2);
            this.Controls.Add(this.pnlMedida1);
            this.Controls.Add(this.axIpeDspCtrl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axIpeDspCtrl1)).EndInit();
            this.pnlMedida1.ResumeLayout(false);
            this.pnlMedida1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axIpeDspCtrl2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnlMedida2.ResumeLayout(false);
            this.pnlMedida2.PerformLayout();
            this.pnlMedida3.ResumeLayout(false);
            this.pnlMedida3.PerformLayout();
            this.pnlMedida4.ResumeLayout(false);
            this.pnlMedida4.PerformLayout();
            this.pnlMedida5.ResumeLayout(false);
            this.pnlMedida5.PerformLayout();
            this.pnlMedida6.ResumeLayout(false);
            this.pnlMedida6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxIpeDspCtrlLib.AxIpeDspCtrl axIpeDspCtrl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMedida1;
        private System.Windows.Forms.Label outString0;
        private AxIpeDspCtrlLib.AxIpeDspCtrl axIpeDspCtrl2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlMedida2;
        private System.Windows.Forms.Label outString1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlMedida3;
        private System.Windows.Forms.Label outString2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlMedida4;
        private System.Windows.Forms.Label outString3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlMedida5;
        private System.Windows.Forms.Label outString4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlMedida6;
        private System.Windows.Forms.Label outString5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnVial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCasquillo;
        private System.Windows.Forms.Button btnGreylid;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox diagram;
        private System.Windows.Forms.Button btnEtiquetas;
    }
}

