namespace UDP
{
    partial class ClientForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.txtClientPort = new System.Windows.Forms.TextBox();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCreateClient = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server Port :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client Port :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Host Name :";
            // 
            // txtServerPort
            // 
            this.txtServerPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.txtServerPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServerPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtServerPort.ForeColor = System.Drawing.Color.White;
            this.txtServerPort.Location = new System.Drawing.Point(133, 50);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(163, 23);
            this.txtServerPort.TabIndex = 4;
            this.txtServerPort.Text = "5678";
            this.txtServerPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtClientPort
            // 
            this.txtClientPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.txtClientPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClientPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtClientPort.ForeColor = System.Drawing.Color.White;
            this.txtClientPort.Location = new System.Drawing.Point(133, 90);
            this.txtClientPort.Name = "txtClientPort";
            this.txtClientPort.Size = new System.Drawing.Size(163, 23);
            this.txtClientPort.TabIndex = 5;
            this.txtClientPort.Text = "1234";
            this.txtClientPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHostName
            // 
            this.txtHostName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.txtHostName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtHostName.ForeColor = System.Drawing.Color.White;
            this.txtHostName.Location = new System.Drawing.Point(133, 132);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(163, 23);
            this.txtHostName.TabIndex = 6;
            this.txtHostName.Text = "localhost";
            this.txtHostName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mesazhi nga Serveri :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLog.ForeColor = System.Drawing.Color.White;
            this.txtLog.Location = new System.Drawing.Point(29, 191);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(267, 98);
            this.txtLog.TabIndex = 8;
            this.txtLog.Text = "";
            this.txtLog.TextChanged += new System.EventHandler(this.txtLog_TextChanged);
            // 
            // txtMsg
            // 
            this.txtMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.txtMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMsg.ForeColor = System.Drawing.Color.White;
            this.txtMsg.Location = new System.Drawing.Point(31, 312);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(265, 23);
            this.txtMsg.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kerkesa juaj :";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Enabled = false;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(29, 341);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(127, 42);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCreateClient
            // 
            this.btnCreateClient.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCreateClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnCreateClient.ForeColor = System.Drawing.Color.White;
            this.btnCreateClient.Location = new System.Drawing.Point(162, 341);
            this.btnCreateClient.Name = "btnCreateClient";
            this.btnCreateClient.Size = new System.Drawing.Size(134, 42);
            this.btnCreateClient.TabIndex = 12;
            this.btnCreateClient.Text = "Create Client";
            this.btnCreateClient.UseVisualStyleBackColor = false;
            this.btnCreateClient.Click += new System.EventHandler(this.btnCreateClient_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Client";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(325, 401);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCreateClient);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHostName);
            this.Controls.Add(this.txtClientPort);
            this.Controls.Add(this.txtServerPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.TextBox txtClientPort;
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCreateClient;
        private System.Windows.Forms.Label label6;
    }
}

