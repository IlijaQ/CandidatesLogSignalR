﻿namespace CandidatesLogSignalR
{
    partial class SignalRClient
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
            this.lbSignalRLogs = new System.Windows.Forms.ListBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblConnected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSignalRLogs
            // 
            this.lbSignalRLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSignalRLogs.FormattingEnabled = true;
            this.lbSignalRLogs.ItemHeight = 16;
            this.lbSignalRLogs.Location = new System.Drawing.Point(12, 11);
            this.lbSignalRLogs.Name = "lbSignalRLogs";
            this.lbSignalRLogs.Size = new System.Drawing.Size(776, 388);
            this.lbSignalRLogs.TabIndex = 9;
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(629, 412);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(159, 28);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblConnected
            // 
            this.lblConnected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConnected.AutoSize = true;
            this.lblConnected.Location = new System.Drawing.Point(675, 418);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(72, 16);
            this.lblConnected.TabIndex = 10;
            this.lblConnected.Text = "Connected";
            this.lblConnected.Visible = false;
            // 
            // SignalRClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblConnected);
            this.Controls.Add(this.lbSignalRLogs);
            this.Controls.Add(this.btnConnect);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "SignalRClient";
            this.Text = "SignalR Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSignalRLogs;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblConnected;
    }
}