namespace FilevineIntakeIntegrationDemo
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
            this.cboFirm = new System.Windows.Forms.ComboBox();
            this.cboProjectType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxApiKey = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGetList = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSendProject = new System.Windows.Forms.Button();
            this.tbxClientLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxClientFirstName = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxGetOrgResult = new System.Windows.Forms.TextBox();
            this.tbxSendProjectResult = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboFirm
            // 
            this.cboFirm.DisplayMember = "Name";
            this.cboFirm.FormattingEnabled = true;
            this.cboFirm.Location = new System.Drawing.Point(487, 84);
            this.cboFirm.Name = "cboFirm";
            this.cboFirm.Size = new System.Drawing.Size(156, 21);
            this.cboFirm.TabIndex = 0;
            this.cboFirm.ValueMember = "ID";
            this.cboFirm.SelectedIndexChanged += new System.EventHandler(this.cboFirm_SelectedIndexChanged);
            // 
            // cboProjectType
            // 
            this.cboProjectType.DisplayMember = "Name";
            this.cboProjectType.FormattingEnabled = true;
            this.cboProjectType.Location = new System.Drawing.Point(487, 137);
            this.cboProjectType.Name = "cboProjectType";
            this.cboProjectType.Size = new System.Drawing.Size(156, 21);
            this.cboProjectType.TabIndex = 1;
            this.cboProjectType.ValueMember = "ID";
            this.cboProjectType.SelectedIndexChanged += new System.EventHandler(this.cboProjectType_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxApiKey);
            this.groupBox1.Location = new System.Drawing.Point(24, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 130);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Securely Store API Key";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(27, 28);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(361, 85);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "API Key";
            // 
            // tbxApiKey
            // 
            this.tbxApiKey.Location = new System.Drawing.Point(487, 44);
            this.tbxApiKey.Name = "tbxApiKey";
            this.tbxApiKey.Size = new System.Drawing.Size(156, 20);
            this.tbxApiKey.TabIndex = 0;
            this.tbxApiKey.TextChanged += new System.EventHandler(this.tbxApiKey_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.tbxGetOrgResult);
            this.groupBox2.Controls.Add(this.btnGetList);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cboFirm);
            this.groupBox2.Controls.Add(this.cboProjectType);
            this.groupBox2.Location = new System.Drawing.Point(24, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(713, 192);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Get Lists from Filevine and Select";
            // 
            // btnGetList
            // 
            this.btnGetList.Location = new System.Drawing.Point(568, 27);
            this.btnGetList.Name = "btnGetList";
            this.btnGetList.Size = new System.Drawing.Size(75, 23);
            this.btnGetList.TabIndex = 4;
            this.btnGetList.Text = "Get List";
            this.btnGetList.UseVisualStyleBackColor = true;
            this.btnGetList.Click += new System.EventHandler(this.btnGetList_Click);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(27, 32);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(361, 73);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Case Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(490, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Firm Receiving Case";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.tbxSendProjectResult);
            this.groupBox3.Controls.Add(this.btnSendProject);
            this.groupBox3.Controls.Add(this.tbxClientLastName);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbxClientFirstName);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Location = new System.Drawing.Point(24, 432);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(713, 186);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3. Send Case to Filevine";
            // 
            // btnSendProject
            // 
            this.btnSendProject.Location = new System.Drawing.Point(522, 136);
            this.btnSendProject.Name = "btnSendProject";
            this.btnSendProject.Size = new System.Drawing.Size(121, 23);
            this.btnSendProject.TabIndex = 8;
            this.btnSendProject.Text = "Send Case to Filevine";
            this.btnSendProject.UseVisualStyleBackColor = true;
            this.btnSendProject.Click += new System.EventHandler(this.btnSendProject_Click);
            // 
            // tbxClientLastName
            // 
            this.tbxClientLastName.Location = new System.Drawing.Point(487, 86);
            this.tbxClientLastName.Name = "tbxClientLastName";
            this.tbxClientLastName.Size = new System.Drawing.Size(156, 20);
            this.tbxClientLastName.TabIndex = 7;
            this.tbxClientLastName.TextChanged += new System.EventHandler(this.tbxClientLastName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Client Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Client First Name";
            // 
            // tbxClientFirstName
            // 
            this.tbxClientFirstName.Location = new System.Drawing.Point(487, 35);
            this.tbxClientFirstName.Name = "tbxClientFirstName";
            this.tbxClientFirstName.Size = new System.Drawing.Size(156, 20);
            this.tbxClientFirstName.TabIndex = 5;
            this.tbxClientFirstName.TextChanged += new System.EventHandler(this.tbxClientFirstName_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(27, 38);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(361, 73);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "Once selection is made, case can be dispatched to Filevine.  Enter a name (the re" +
    "st of the data is generated for the demo)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(374, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Intake Integration Sample Code Demo";
            // 
            // tbxGetOrgResult
            // 
            this.tbxGetOrgResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxGetOrgResult.Location = new System.Drawing.Point(73, 101);
            this.tbxGetOrgResult.Multiline = true;
            this.tbxGetOrgResult.Name = "tbxGetOrgResult";
            this.tbxGetOrgResult.ReadOnly = true;
            this.tbxGetOrgResult.Size = new System.Drawing.Size(328, 57);
            this.tbxGetOrgResult.TabIndex = 5;
            this.tbxGetOrgResult.Text = "get orgs result";
            // 
            // tbxSendProjectResult
            // 
            this.tbxSendProjectResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxSendProjectResult.Location = new System.Drawing.Point(73, 102);
            this.tbxSendProjectResult.Multiline = true;
            this.tbxSendProjectResult.Name = "tbxSendProjectResult";
            this.tbxSendProjectResult.ReadOnly = true;
            this.tbxSendProjectResult.Size = new System.Drawing.Size(328, 57);
            this.tbxSendProjectResult.TabIndex = 10;
            this.tbxSendProjectResult.Text = "send project result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(768, 693);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Intake Integration Sample Code Demo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboFirm;
        private System.Windows.Forms.ComboBox cboProjectType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxApiKey;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSendProject;
        private System.Windows.Forms.TextBox tbxClientLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxClientFirstName;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGetList;
        private System.Windows.Forms.TextBox tbxGetOrgResult;
        private System.Windows.Forms.TextBox tbxSendProjectResult;
    }
}

