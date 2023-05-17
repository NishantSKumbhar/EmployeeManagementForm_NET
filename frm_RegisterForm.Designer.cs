namespace EmployeeManagementForm
{
    partial class frm_RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_RegisterForm));
            this.lbl_RegisterHeader = new System.Windows.Forms.Label();
            this.lbl_ErrorRegisterDetails = new System.Windows.Forms.Label();
            this.lnk_Login = new System.Windows.Forms.LinkLabel();
            this.lbl_FooterLine = new System.Windows.Forms.Label();
            this.tb_EmpName = new System.Windows.Forms.TextBox();
            this.lbl_EmpName = new System.Windows.Forms.Label();
            this.lbl_Department = new System.Windows.Forms.Label();
            this.tb_Mobile = new System.Windows.Forms.TextBox();
            this.lbl_Mobile = new System.Windows.Forms.Label();
            this.cmb_Department = new System.Windows.Forms.ComboBox();
            this.tb_Location = new System.Windows.Forms.TextBox();
            this.lbl_Location = new System.Windows.Forms.Label();
            this.btn_Register = new System.Windows.Forms.Button();
            this.lbl_CompanyName = new System.Windows.Forms.Label();
            this.tb_Password1 = new System.Windows.Forms.TextBox();
            this.lbl_Password1 = new System.Windows.Forms.Label();
            this.tb_Password2 = new System.Windows.Forms.TextBox();
            this.lbl_Password2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_RegisterHeader
            // 
            this.lbl_RegisterHeader.AutoSize = true;
            this.lbl_RegisterHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegisterHeader.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_RegisterHeader.Location = new System.Drawing.Point(441, 103);
            this.lbl_RegisterHeader.Name = "lbl_RegisterHeader";
            this.lbl_RegisterHeader.Size = new System.Drawing.Size(158, 29);
            this.lbl_RegisterHeader.TabIndex = 0;
            this.lbl_RegisterHeader.Text = "Join Today ..";
            // 
            // lbl_ErrorRegisterDetails
            // 
            this.lbl_ErrorRegisterDetails.AutoSize = true;
            this.lbl_ErrorRegisterDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorRegisterDetails.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorRegisterDetails.Location = new System.Drawing.Point(395, 481);
            this.lbl_ErrorRegisterDetails.Name = "lbl_ErrorRegisterDetails";
            this.lbl_ErrorRegisterDetails.Size = new System.Drawing.Size(253, 24);
            this.lbl_ErrorRegisterDetails.TabIndex = 19;
            this.lbl_ErrorRegisterDetails.Text = "* Please enter a valid info.";
            this.lbl_ErrorRegisterDetails.Visible = false;
            // 
            // lnk_Login
            // 
            this.lnk_Login.AutoSize = true;
            this.lnk_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_Login.Location = new System.Drawing.Point(668, 573);
            this.lnk_Login.Name = "lnk_Login";
            this.lnk_Login.Size = new System.Drawing.Size(42, 20);
            this.lnk_Login.TabIndex = 6;
            this.lnk_Login.TabStop = true;
            this.lnk_Login.Text = "here";
            this.lnk_Login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_Login_LinkClicked);
            // 
            // lbl_FooterLine
            // 
            this.lbl_FooterLine.AutoSize = true;
            this.lbl_FooterLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FooterLine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_FooterLine.Location = new System.Drawing.Point(349, 573);
            this.lbl_FooterLine.Name = "lbl_FooterLine";
            this.lbl_FooterLine.Size = new System.Drawing.Size(281, 20);
            this.lbl_FooterLine.TabIndex = 18;
            this.lbl_FooterLine.Text = "Aleardy have account, you can login ";
            // 
            // tb_EmpName
            // 
            this.tb_EmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_EmpName.Location = new System.Drawing.Point(486, 162);
            this.tb_EmpName.MaxLength = 20;
            this.tb_EmpName.Name = "tb_EmpName";
            this.tb_EmpName.Size = new System.Drawing.Size(337, 26);
            this.tb_EmpName.TabIndex = 1;
            // 
            // lbl_EmpName
            // 
            this.lbl_EmpName.AutoSize = true;
            this.lbl_EmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmpName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_EmpName.Location = new System.Drawing.Point(276, 162);
            this.lbl_EmpName.Name = "lbl_EmpName";
            this.lbl_EmpName.Size = new System.Drawing.Size(180, 25);
            this.lbl_EmpName.TabIndex = 16;
            this.lbl_EmpName.Text = "Name                      :";
            // 
            // lbl_Department
            // 
            this.lbl_Department.AutoSize = true;
            this.lbl_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Department.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Department.Location = new System.Drawing.Point(277, 213);
            this.lbl_Department.Name = "lbl_Department";
            this.lbl_Department.Size = new System.Drawing.Size(179, 25);
            this.lbl_Department.TabIndex = 21;
            this.lbl_Department.Text = "Department            :";
            // 
            // tb_Mobile
            // 
            this.tb_Mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile.Location = new System.Drawing.Point(486, 275);
            this.tb_Mobile.MaxLength = 10;
            this.tb_Mobile.Name = "tb_Mobile";
            this.tb_Mobile.Size = new System.Drawing.Size(337, 26);
            this.tb_Mobile.TabIndex = 3;
            // 
            // lbl_Mobile
            // 
            this.lbl_Mobile.AutoSize = true;
            this.lbl_Mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Mobile.Location = new System.Drawing.Point(276, 275);
            this.lbl_Mobile.Name = "lbl_Mobile";
            this.lbl_Mobile.Size = new System.Drawing.Size(181, 25);
            this.lbl_Mobile.TabIndex = 23;
            this.lbl_Mobile.Text = "Mobile No.              :";
            // 
            // cmb_Department
            // 
            this.cmb_Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Department.FormattingEnabled = true;
            this.cmb_Department.Items.AddRange(new object[] {
            "HR",
            "Finanace",
            "Web",
            "IT"});
            this.cmb_Department.Location = new System.Drawing.Point(486, 213);
            this.cmb_Department.Name = "cmb_Department";
            this.cmb_Department.Size = new System.Drawing.Size(337, 28);
            this.cmb_Department.TabIndex = 2;
            // 
            // tb_Location
            // 
            this.tb_Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Location.Location = new System.Drawing.Point(486, 326);
            this.tb_Location.MaxLength = 20;
            this.tb_Location.Name = "tb_Location";
            this.tb_Location.Size = new System.Drawing.Size(337, 26);
            this.tb_Location.TabIndex = 4;
            // 
            // lbl_Location
            // 
            this.lbl_Location.AutoSize = true;
            this.lbl_Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Location.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Location.Location = new System.Drawing.Point(276, 328);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Size = new System.Drawing.Size(182, 25);
            this.lbl_Location.TabIndex = 25;
            this.lbl_Location.Text = "Location                  :";
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Register.Location = new System.Drawing.Point(446, 518);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(104, 42);
            this.btn_Register.TabIndex = 5;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = false;
            // 
            // lbl_CompanyName
            // 
            this.lbl_CompanyName.AutoSize = true;
            this.lbl_CompanyName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_CompanyName.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CompanyName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_CompanyName.Location = new System.Drawing.Point(321, 35);
            this.lbl_CompanyName.Name = "lbl_CompanyName";
            this.lbl_CompanyName.Size = new System.Drawing.Size(435, 40);
            this.lbl_CompanyName.TabIndex = 26;
            this.lbl_CompanyName.Text = "LEXCROP INDUSTRIES";
            // 
            // tb_Password1
            // 
            this.tb_Password1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password1.Location = new System.Drawing.Point(486, 377);
            this.tb_Password1.MaxLength = 8;
            this.tb_Password1.Name = "tb_Password1";
            this.tb_Password1.Size = new System.Drawing.Size(337, 26);
            this.tb_Password1.TabIndex = 27;
            // 
            // lbl_Password1
            // 
            this.lbl_Password1.AutoSize = true;
            this.lbl_Password1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Password1.Location = new System.Drawing.Point(276, 378);
            this.lbl_Password1.Name = "lbl_Password1";
            this.lbl_Password1.Size = new System.Drawing.Size(184, 25);
            this.lbl_Password1.TabIndex = 28;
            this.lbl_Password1.Text = "Password                :";
            // 
            // tb_Password2
            // 
            this.tb_Password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password2.Location = new System.Drawing.Point(486, 436);
            this.tb_Password2.MaxLength = 8;
            this.tb_Password2.Name = "tb_Password2";
            this.tb_Password2.Size = new System.Drawing.Size(337, 26);
            this.tb_Password2.TabIndex = 29;
            // 
            // lbl_Password2
            // 
            this.lbl_Password2.AutoSize = true;
            this.lbl_Password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Password2.Location = new System.Drawing.Point(277, 435);
            this.lbl_Password2.Name = "lbl_Password2";
            this.lbl_Password2.Size = new System.Drawing.Size(185, 25);
            this.lbl_Password2.TabIndex = 30;
            this.lbl_Password2.Text = "Again Password     :";
            // 
            // frm_RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1070, 625);
            this.Controls.Add(this.tb_Password2);
            this.Controls.Add(this.lbl_Password2);
            this.Controls.Add(this.tb_Password1);
            this.Controls.Add(this.lbl_Password1);
            this.Controls.Add(this.lbl_CompanyName);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.tb_Location);
            this.Controls.Add(this.lbl_Location);
            this.Controls.Add(this.cmb_Department);
            this.Controls.Add(this.tb_Mobile);
            this.Controls.Add(this.lbl_Mobile);
            this.Controls.Add(this.lbl_Department);
            this.Controls.Add(this.lbl_ErrorRegisterDetails);
            this.Controls.Add(this.lnk_Login);
            this.Controls.Add(this.lbl_FooterLine);
            this.Controls.Add(this.tb_EmpName);
            this.Controls.Add(this.lbl_EmpName);
            this.Controls.Add(this.lbl_RegisterHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LEXCROP INDUSTRIES REGISTER USER";
            this.Load += new System.EventHandler(this.frm_RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_RegisterHeader;
        private System.Windows.Forms.Label lbl_ErrorRegisterDetails;
        private System.Windows.Forms.LinkLabel lnk_Login;
        private System.Windows.Forms.Label lbl_FooterLine;
        private System.Windows.Forms.TextBox tb_EmpName;
        private System.Windows.Forms.Label lbl_EmpName;
        private System.Windows.Forms.Label lbl_Department;
        private System.Windows.Forms.TextBox tb_Mobile;
        private System.Windows.Forms.Label lbl_Mobile;
        private System.Windows.Forms.ComboBox cmb_Department;
        private System.Windows.Forms.TextBox tb_Location;
        private System.Windows.Forms.Label lbl_Location;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Label lbl_CompanyName;
        private System.Windows.Forms.TextBox tb_Password1;
        private System.Windows.Forms.Label lbl_Password1;
        private System.Windows.Forms.TextBox tb_Password2;
        private System.Windows.Forms.Label lbl_Password2;
    }
}