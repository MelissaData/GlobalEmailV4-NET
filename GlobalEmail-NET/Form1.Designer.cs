namespace GlobalEmail_NET
{
    partial class Form1
    {
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabRequest = new System.Windows.Forms.TabControl();
            this.tabInput = new System.Windows.Forms.TabPage();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.txtEmailIn = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optDomainCorrection = new System.Windows.Forms.CheckBox();
            this.optVerificationType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbWhoIs = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.optTimeToWait = new System.Windows.Forms.ComboBox();
            this.tabResponse = new System.Windows.Forms.TabControl();
            this.tabServiceResponse = new System.Windows.Forms.TabPage();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.tabRESTRequest = new System.Windows.Forms.TabPage();
            this.txtRESTRequest = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkWiki = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.tabRequest.SuspendLayout();
            this.tabInput.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabResponse.SuspendLayout();
            this.tabServiceResponse.SuspendLayout();
            this.tabRESTRequest.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.tabRequest);
            this.panel1.Controls.Add(this.tabResponse);
            this.panel1.Location = new System.Drawing.Point(125, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 619);
            this.panel1.TabIndex = 1;
            // 
            // tabRequest
            // 
            this.tabRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabRequest.Controls.Add(this.tabInput);
            this.tabRequest.Controls.Add(this.tabOptions);
            this.tabRequest.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tabRequest.Location = new System.Drawing.Point(28, 26);
            this.tabRequest.Name = "tabRequest";
            this.tabRequest.SelectedIndex = 0;
            this.tabRequest.Size = new System.Drawing.Size(298, 568);
            this.tabRequest.TabIndex = 16;
            // 
            // tabInput
            // 
            this.tabInput.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabInput.Controls.Add(this.txtLicense);
            this.tabInput.Controls.Add(this.txtEmailIn);
            this.tabInput.Controls.Add(this.label25);
            this.tabInput.Controls.Add(this.label22);
            this.tabInput.Controls.Add(this.btnClear);
            this.tabInput.Controls.Add(this.btnSubmit);
            this.tabInput.Controls.Add(this.label2);
            this.tabInput.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tabInput.Location = new System.Drawing.Point(4, 22);
            this.tabInput.Name = "tabInput";
            this.tabInput.Padding = new System.Windows.Forms.Padding(3);
            this.tabInput.Size = new System.Drawing.Size(290, 542);
            this.tabInput.TabIndex = 0;
            this.tabInput.Text = "Input";
            // 
            // txtLicense
            // 
            this.txtLicense.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic);
            this.txtLicense.Location = new System.Drawing.Point(18, 31);
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.Size = new System.Drawing.Size(250, 22);
            this.txtLicense.TabIndex = 53;
            this.txtLicense.Text = "Enter your license key here";
            // 
            // txtEmailIn
            // 
            this.txtEmailIn.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.txtEmailIn.Location = new System.Drawing.Point(18, 112);
            this.txtEmailIn.Name = "txtEmailIn";
            this.txtEmailIn.Size = new System.Drawing.Size(250, 22);
            this.txtEmailIn.TabIndex = 1;
            this.txtEmailIn.Text = "testemail@domain.com";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label25.Location = new System.Drawing.Point(15, 13);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(85, 15);
            this.label25.TabIndex = 54;
            this.label25.Text = "License String";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label22.Location = new System.Drawing.Point(15, 70);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(102, 15);
            this.label22.TabIndex = 51;
            this.label22.Text = "Email Information";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGray;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(98, 162);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(68, 23);
            this.btnClear.TabIndex = 47;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LightGray;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(172, 162);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(96, 23);
            this.btnSubmit.TabIndex = 46;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(15, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            // 
            // tabOptions
            // 
            this.tabOptions.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabOptions.Controls.Add(this.groupBox1);
            this.tabOptions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabOptions.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabOptions.Location = new System.Drawing.Point(4, 22);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabOptions.Size = new System.Drawing.Size(290, 542);
            this.tabOptions.TabIndex = 1;
            this.tabOptions.Text = "Options";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optDomainCorrection);
            this.groupBox1.Controls.Add(this.optVerificationType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.cmbWhoIs);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.optTimeToWait);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(23, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 299);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // optDomainCorrection
            // 
            this.optDomainCorrection.Checked = true;
            this.optDomainCorrection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.optDomainCorrection.Location = new System.Drawing.Point(6, 22);
            this.optDomainCorrection.Name = "optDomainCorrection";
            this.optDomainCorrection.Size = new System.Drawing.Size(227, 20);
            this.optDomainCorrection.TabIndex = 80;
            this.optDomainCorrection.Text = "Domain Correction";
            this.optDomainCorrection.UseVisualStyleBackColor = true;
            // 
            // optVerificationType
            // 
            this.optVerificationType.FormattingEnabled = true;
            this.optVerificationType.Items.AddRange(new object[] {
            "Express (Default)",
            "Premium"});
            this.optVerificationType.Location = new System.Drawing.Point(6, 84);
            this.optVerificationType.Name = "optVerificationType";
            this.optVerificationType.Size = new System.Drawing.Size(227, 23);
            this.optVerificationType.TabIndex = 87;
            this.optVerificationType.Text = "Express (Default)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 79;
            this.label3.Text = "WhoIS Domain Info";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 137);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 15);
            this.label17.TabIndex = 79;
            this.label17.Text = "Time to Wait";
            // 
            // cmbWhoIs
            // 
            this.cmbWhoIs.DropDownHeight = 108;
            this.cmbWhoIs.FormattingEnabled = true;
            this.cmbWhoIs.IntegralHeight = false;
            this.cmbWhoIs.Items.AddRange(new object[] {
            "Off",
            "On (Default)"});
            this.cmbWhoIs.Location = new System.Drawing.Point(6, 223);
            this.cmbWhoIs.Name = "cmbWhoIs";
            this.cmbWhoIs.Size = new System.Drawing.Size(227, 23);
            this.cmbWhoIs.TabIndex = 76;
            this.cmbWhoIs.Text = "On (Default)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 15);
            this.label7.TabIndex = 88;
            this.label7.Text = "Verification Type";
            // 
            // optTimeToWait
            // 
            this.optTimeToWait.DropDownHeight = 108;
            this.optTimeToWait.FormattingEnabled = true;
            this.optTimeToWait.IntegralHeight = false;
            this.optTimeToWait.Items.AddRange(new object[] {
            "1",
            "2 (Default)",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.optTimeToWait.Location = new System.Drawing.Point(6, 155);
            this.optTimeToWait.Name = "optTimeToWait";
            this.optTimeToWait.Size = new System.Drawing.Size(227, 23);
            this.optTimeToWait.TabIndex = 76;
            this.optTimeToWait.Text = "2 (Default)";
            // 
            // tabResponse
            // 
            this.tabResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabResponse.Controls.Add(this.tabServiceResponse);
            this.tabResponse.Controls.Add(this.tabRESTRequest);
            this.tabResponse.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.tabResponse.Location = new System.Drawing.Point(350, 22);
            this.tabResponse.Name = "tabResponse";
            this.tabResponse.SelectedIndex = 0;
            this.tabResponse.Size = new System.Drawing.Size(709, 572);
            this.tabResponse.TabIndex = 15;
            // 
            // tabServiceResponse
            // 
            this.tabServiceResponse.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabServiceResponse.Controls.Add(this.txtResponse);
            this.tabServiceResponse.Location = new System.Drawing.Point(4, 22);
            this.tabServiceResponse.Name = "tabServiceResponse";
            this.tabServiceResponse.Padding = new System.Windows.Forms.Padding(3);
            this.tabServiceResponse.Size = new System.Drawing.Size(701, 546);
            this.tabServiceResponse.TabIndex = 1;
            this.tabServiceResponse.Text = "Service Response";
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.BackColor = System.Drawing.Color.White;
            this.txtResponse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponse.ForeColor = System.Drawing.Color.Black;
            this.txtResponse.Location = new System.Drawing.Point(-4, 0);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResponse.Size = new System.Drawing.Size(709, 550);
            this.txtResponse.TabIndex = 0;
            // 
            // tabRESTRequest
            // 
            this.tabRESTRequest.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabRESTRequest.Controls.Add(this.txtRESTRequest);
            this.tabRESTRequest.Controls.Add(this.label23);
            this.tabRESTRequest.Location = new System.Drawing.Point(4, 22);
            this.tabRESTRequest.Name = "tabRESTRequest";
            this.tabRESTRequest.Padding = new System.Windows.Forms.Padding(3);
            this.tabRESTRequest.Size = new System.Drawing.Size(701, 546);
            this.tabRESTRequest.TabIndex = 2;
            this.tabRESTRequest.Text = "REST Request";
            // 
            // txtRESTRequest
            // 
            this.txtRESTRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRESTRequest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRESTRequest.Location = new System.Drawing.Point(30, 48);
            this.txtRESTRequest.Multiline = true;
            this.txtRESTRequest.Name = "txtRESTRequest";
            this.txtRESTRequest.Size = new System.Drawing.Size(638, 221);
            this.txtRESTRequest.TabIndex = 75;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label23.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label23.Location = new System.Drawing.Point(26, 27);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(102, 19);
            this.label23.TabIndex = 74;
            this.label23.Text = "REST Request:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(117, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Global Email Sample V4";
            // 
            // lnkWiki
            // 
            this.lnkWiki.AutoSize = true;
            this.lnkWiki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkWiki.LinkColor = System.Drawing.Color.SkyBlue;
            this.lnkWiki.Location = new System.Drawing.Point(472, 65);
            this.lnkWiki.Name = "lnkWiki";
            this.lnkWiki.Size = new System.Drawing.Size(126, 15);
            this.lnkWiki.TabIndex = 7;
            this.lnkWiki.TabStop = true;
            this.lnkWiki.Text = "Wiki Reference Guide";
            this.lnkWiki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkWiki_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1290, 773);
            this.Controls.Add(this.lnkWiki);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Global Email Sample Code";
            this.panel1.ResumeLayout(false);
            this.tabRequest.ResumeLayout(false);
            this.tabInput.ResumeLayout(false);
            this.tabInput.PerformLayout();
            this.tabOptions.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabResponse.ResumeLayout(false);
            this.tabServiceResponse.ResumeLayout(false);
            this.tabServiceResponse.PerformLayout();
            this.tabRESTRequest.ResumeLayout(false);
            this.tabRESTRequest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabResponse;
        private System.Windows.Forms.TabPage tabServiceResponse;
        private System.Windows.Forms.TabPage tabRESTRequest;
        private System.Windows.Forms.TextBox txtRESTRequest;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.LinkLabel lnkWiki;
        private System.Windows.Forms.TabControl tabRequest;
        private System.Windows.Forms.TabPage tabInput;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.TextBox txtEmailIn;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabOptions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox optVerificationType;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox optTimeToWait;
        private System.Windows.Forms.CheckBox optDomainCorrection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbWhoIs;

    }
}

