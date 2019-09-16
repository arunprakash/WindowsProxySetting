namespace ProxySetting
{
    partial class ProxySetting
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
            this.btnSetProxy = new System.Windows.Forms.Button();
            this.btnDisableProxy = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtProxyAddress = new System.Windows.Forms.TextBox();
            this.txtProxyPort = new System.Windows.Forms.TextBox();
            this.txtByPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtByPassSet = new System.Windows.Forms.TextBox();
            this.txtProxyPortSet = new System.Windows.Forms.TextBox();
            this.txtProxyAddressSet = new System.Windows.Forms.TextBox();
            this.btnPopulateDefault = new System.Windows.Forms.Button();
            this.chkProxy = new System.Windows.Forms.Button();
            this.btnConnection = new System.Windows.Forms.Button();
            this.txtConnection = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSetProxy
            // 
            this.btnSetProxy.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetProxy.Location = new System.Drawing.Point(566, 212);
            this.btnSetProxy.Name = "btnSetProxy";
            this.btnSetProxy.Size = new System.Drawing.Size(105, 23);
            this.btnSetProxy.TabIndex = 0;
            this.btnSetProxy.Text = "Set Proxy";
            this.btnSetProxy.UseVisualStyleBackColor = true;
            this.btnSetProxy.Click += new System.EventHandler(this.btnSetProxy_Click);
            // 
            // btnDisableProxy
            // 
            this.btnDisableProxy.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisableProxy.Location = new System.Drawing.Point(566, 257);
            this.btnDisableProxy.Name = "btnDisableProxy";
            this.btnDisableProxy.Size = new System.Drawing.Size(105, 23);
            this.btnDisableProxy.TabIndex = 1;
            this.btnDisableProxy.Text = "Disable Proxy";
            this.btnDisableProxy.UseVisualStyleBackColor = true;
            this.btnDisableProxy.Click += new System.EventHandler(this.btnDisableProxy_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(136, 49);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(158, 23);
            this.txtStatus.TabIndex = 2;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProxyAddress
            // 
            this.txtProxyAddress.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProxyAddress.Location = new System.Drawing.Point(136, 109);
            this.txtProxyAddress.Name = "txtProxyAddress";
            this.txtProxyAddress.ReadOnly = true;
            this.txtProxyAddress.Size = new System.Drawing.Size(158, 23);
            this.txtProxyAddress.TabIndex = 3;
            this.txtProxyAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProxyPort
            // 
            this.txtProxyPort.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProxyPort.Location = new System.Drawing.Point(136, 162);
            this.txtProxyPort.Name = "txtProxyPort";
            this.txtProxyPort.ReadOnly = true;
            this.txtProxyPort.Size = new System.Drawing.Size(158, 23);
            this.txtProxyPort.TabIndex = 4;
            this.txtProxyPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtByPass
            // 
            this.txtByPass.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtByPass.Location = new System.Drawing.Point(136, 217);
            this.txtByPass.Multiline = true;
            this.txtByPass.Name = "txtByPass";
            this.txtByPass.ReadOnly = true;
            this.txtByPass.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtByPass.Size = new System.Drawing.Size(158, 90);
            this.txtByPass.TabIndex = 5;
            this.txtByPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtByPass.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Proxy Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Proxy Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "ByPass List";
            // 
            // txtByPassSet
            // 
            this.txtByPassSet.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtByPassSet.Location = new System.Drawing.Point(345, 217);
            this.txtByPassSet.Multiline = true;
            this.txtByPassSet.Name = "txtByPassSet";
            this.txtByPassSet.Size = new System.Drawing.Size(158, 90);
            this.txtByPassSet.TabIndex = 13;
            this.txtByPassSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProxyPortSet
            // 
            this.txtProxyPortSet.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProxyPortSet.Location = new System.Drawing.Point(345, 162);
            this.txtProxyPortSet.Name = "txtProxyPortSet";
            this.txtProxyPortSet.Size = new System.Drawing.Size(158, 23);
            this.txtProxyPortSet.TabIndex = 12;
            this.txtProxyPortSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProxyAddressSet
            // 
            this.txtProxyAddressSet.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProxyAddressSet.Location = new System.Drawing.Point(345, 109);
            this.txtProxyAddressSet.Name = "txtProxyAddressSet";
            this.txtProxyAddressSet.Size = new System.Drawing.Size(158, 23);
            this.txtProxyAddressSet.TabIndex = 11;
            this.txtProxyAddressSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPopulateDefault
            // 
            this.btnPopulateDefault.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopulateDefault.Location = new System.Drawing.Point(566, 112);
            this.btnPopulateDefault.Name = "btnPopulateDefault";
            this.btnPopulateDefault.Size = new System.Drawing.Size(105, 23);
            this.btnPopulateDefault.TabIndex = 14;
            this.btnPopulateDefault.Text = "Populate Default";
            this.btnPopulateDefault.UseVisualStyleBackColor = true;
            this.btnPopulateDefault.Click += new System.EventHandler(this.txtPopulateDefault_Click);
            // 
            // chkProxy
            // 
            this.chkProxy.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkProxy.Location = new System.Drawing.Point(566, 162);
            this.chkProxy.Name = "chkProxy";
            this.chkProxy.Size = new System.Drawing.Size(105, 23);
            this.chkProxy.TabIndex = 15;
            this.chkProxy.Text = "Check Proxy";
            this.chkProxy.UseVisualStyleBackColor = true;
            this.chkProxy.Click += new System.EventHandler(this.chkProxy_Click);
            // 
            // btnConnection
            // 
            this.btnConnection.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnection.Location = new System.Drawing.Point(566, 48);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(105, 23);
            this.btnConnection.TabIndex = 16;
            this.btnConnection.Text = "Check Connection";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtConnection
            // 
            this.txtConnection.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConnection.Location = new System.Drawing.Point(345, 49);
            this.txtConnection.Name = "txtConnection";
            this.txtConnection.ReadOnly = true;
            this.txtConnection.Size = new System.Drawing.Size(158, 23);
            this.txtConnection.TabIndex = 17;
            this.txtConnection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(481, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "© Arun Prakash - arun@arunprakash.net";
            // 
            // ProxySetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(726, 352);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtConnection);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.chkProxy);
            this.Controls.Add(this.btnPopulateDefault);
            this.Controls.Add(this.txtByPassSet);
            this.Controls.Add(this.txtProxyPortSet);
            this.Controls.Add(this.txtProxyAddressSet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtByPass);
            this.Controls.Add(this.txtProxyPort);
            this.Controls.Add(this.txtProxyAddress);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnDisableProxy);
            this.Controls.Add(this.btnSetProxy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ProxySetting";
            this.Text = "ProxySetting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetProxy;
        private System.Windows.Forms.Button btnDisableProxy;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtProxyAddress;
        private System.Windows.Forms.TextBox txtProxyPort;
        private System.Windows.Forms.TextBox txtByPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtByPassSet;
        private System.Windows.Forms.TextBox txtProxyPortSet;
        private System.Windows.Forms.TextBox txtProxyAddressSet;
        private System.Windows.Forms.Button btnPopulateDefault;
        private System.Windows.Forms.Button chkProxy;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.TextBox txtConnection;
        private System.Windows.Forms.Label label5;
    }
}

