namespace EmployeeManagementForm
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.lbl_CompanyName = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_FooterLine = new System.Windows.Forms.Label();
            this.lnk_Register = new System.Windows.Forms.LinkLabel();
            this.lbl_Slogan = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_CompanyName
            // 
            this.lbl_CompanyName.AutoSize = true;
            this.lbl_CompanyName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_CompanyName.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CompanyName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_CompanyName.Location = new System.Drawing.Point(200, 48);
            this.lbl_CompanyName.Name = "lbl_CompanyName";
            this.lbl_CompanyName.Size = new System.Drawing.Size(435, 40);
            this.lbl_CompanyName.TabIndex = 0;
            this.lbl_CompanyName.Text = "LEXCROP INDUSTRIES";
            // 
            // lbl_Login
            // 
            this.lbl_Login.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_Login.Font = new System.Drawing.Font("Segoe UI Symbol", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Login.Location = new System.Drawing.Point(529, 124);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(93, 40);
            this.lbl_Login.TabIndex = 1;
            this.lbl_Login.Text = "Login";
            this.lbl_Login.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Welcome.Location = new System.Drawing.Point(112, 152);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(186, 29);
            this.lbl_Welcome.TabIndex = 2;
            this.lbl_Welcome.Text = "Welcome Back";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_UserName.Location = new System.Drawing.Point(420, 199);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(101, 20);
            this.lbl_UserName.TabIndex = 3;
            this.lbl_UserName.Text = "Username  :";
            // 
            // tb_UserName
            // 
            this.tb_UserName.Location = new System.Drawing.Point(541, 199);
            this.tb_UserName.MaxLength = 10;
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(212, 22);
            this.tb_UserName.TabIndex = 1;
            this.tb_UserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_UserName_KeyPress);
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(541, 260);
            this.tb_Password.MaxLength = 8;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(212, 22);
            this.tb_Password.TabIndex = 2;
            this.tb_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Password_KeyPress);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Password.Location = new System.Drawing.Point(420, 262);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(98, 20);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Password  :";
            // 
            // lbl_FooterLine
            // 
            this.lbl_FooterLine.AutoSize = true;
            this.lbl_FooterLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FooterLine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_FooterLine.Location = new System.Drawing.Point(169, 406);
            this.lbl_FooterLine.Name = "lbl_FooterLine";
            this.lbl_FooterLine.Size = new System.Drawing.Size(287, 20);
            this.lbl_FooterLine.TabIndex = 5;
            this.lbl_FooterLine.Text = "Don\'t have account, you can register ";
            // 
            // lnk_Register
            // 
            this.lnk_Register.AutoSize = true;
            this.lnk_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_Register.Location = new System.Drawing.Point(491, 406);
            this.lnk_Register.Name = "lnk_Register";
            this.lnk_Register.Size = new System.Drawing.Size(42, 20);
            this.lnk_Register.TabIndex = 4;
            this.lnk_Register.TabStop = true;
            this.lnk_Register.Text = "here";
            this.lnk_Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_Register_LinkClicked);
            // 
            // lbl_Slogan
            // 
            this.lbl_Slogan.AutoSize = true;
            this.lbl_Slogan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Slogan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Slogan.Location = new System.Drawing.Point(65, 257);
            this.lbl_Slogan.Name = "lbl_Slogan";
            this.lbl_Slogan.Size = new System.Drawing.Size(260, 25);
            this.lbl_Slogan.TabIndex = 7;
            this.lbl_Slogan.Text = "\"Empowering Lives Globally\"";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Login.Location = new System.Drawing.Point(511, 348);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(111, 41);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(428, 305);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(360, 18);
            this.lbl_Error.TabIndex = 9;
            this.lbl_Error.Text = "* Please enter a valid Username or Password .";
            this.lbl_Error.Visible = false;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_Slogan);
            this.Controls.Add(this.lnk_Register);
            this.Controls.Add(this.lbl_FooterLine);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.tb_UserName);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.lbl_CompanyName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LEXCROP INDUSTRIES";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CompanyName;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.TextBox tb_UserName;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_FooterLine;
        private System.Windows.Forms.LinkLabel lnk_Register;
        private System.Windows.Forms.Label lbl_Slogan;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_Error;
    }
}

