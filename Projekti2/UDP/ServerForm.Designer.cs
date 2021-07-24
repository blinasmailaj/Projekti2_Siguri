namespace UDP
{
    partial class ServerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.btnNewClient = new System.Windows.Forms.Button();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = " Porti :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtServerPort
            // 
            this.txtServerPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.txtServerPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtServerPort.ForeColor = System.Drawing.Color.White;
            this.txtServerPort.Location = new System.Drawing.Point(72, 43);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(103, 23);
            this.txtServerPort.TabIndex = 4;
            this.txtServerPort.Text = "5678";
            this.txtServerPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Serveri:";
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLog.ForeColor = System.Drawing.Color.White;
            this.txtLog.Location = new System.Drawing.Point(22, 97);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(268, 166);
            this.txtLog.TabIndex = 8;
            this.txtLog.Text = "";
            // 
            // btnNewClient
            // 
            this.btnNewClient.BackColor = System.Drawing.Color.DarkCyan;
            this.btnNewClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewClient.Enabled = false;
            this.btnNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnNewClient.ForeColor = System.Drawing.Color.White;
            this.btnNewClient.Location = new System.Drawing.Point(22, 269);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(135, 42);
            this.btnNewClient.TabIndex = 11;
            this.btnNewClient.Text = "Open Client";
            this.btnNewClient.UseVisualStyleBackColor = false;
            this.btnNewClient.Click += new System.EventHandler(this.btnNewClient_Click);
            // 
            // btnStartServer
            // 
            this.btnStartServer.BackColor = System.Drawing.Color.DarkCyan;
            this.btnStartServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartServer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnStartServer.ForeColor = System.Drawing.Color.White;
            this.btnStartServer.Location = new System.Drawing.Point(163, 269);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(127, 42);
            this.btnStartServer.TabIndex = 12;
            this.btnStartServer.Text = "Start Server";
            this.btnStartServer.UseVisualStyleBackColor = false;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Server";
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(311, 326);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnStartServer);
            this.Controls.Add(this.btnNewClient);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtServerPort);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServerForm_FormClosing);
            this.Load += new System.EventHandler(this.ServerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Button btnNewClient;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.Label label6;
    }
}

