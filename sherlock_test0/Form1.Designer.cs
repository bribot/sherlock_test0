﻿
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
            ((System.ComponentModel.ISupportInitialize)(this.axIpeDspCtrl1)).BeginInit();
            this.SuspendLayout();
            // 
            // axIpeDspCtrl1
            // 
            this.axIpeDspCtrl1.Enabled = true;
            this.axIpeDspCtrl1.Location = new System.Drawing.Point(57, 25);
            this.axIpeDspCtrl1.Name = "axIpeDspCtrl1";
            this.axIpeDspCtrl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axIpeDspCtrl1.OcxState")));
            this.axIpeDspCtrl1.Size = new System.Drawing.Size(578, 358);
            this.axIpeDspCtrl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.axIpeDspCtrl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axIpeDspCtrl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxIpeDspCtrlLib.AxIpeDspCtrl axIpeDspCtrl1;
    }
}

