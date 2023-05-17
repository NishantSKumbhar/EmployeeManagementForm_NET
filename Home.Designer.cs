namespace EmployeeManagementForm
{
    partial class frm_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Home));
            this.lbl_CompanyName = new System.Windows.Forms.Label();
            this.lbl_Uname_header = new System.Windows.Forms.Label();
            this.lnk_Logout = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl_CompanyName
            // 
            this.lbl_CompanyName.AutoSize = true;
            this.lbl_CompanyName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_CompanyName.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CompanyName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_CompanyName.Location = new System.Drawing.Point(498, 29);
            this.lbl_CompanyName.Name = "lbl_CompanyName";
            this.lbl_CompanyName.Size = new System.Drawing.Size(435, 40);
            this.lbl_CompanyName.TabIndex = 1;
            this.lbl_CompanyName.Text = "LEXCROP INDUSTRIES";
            // 
            // lbl_Uname_header
            // 
            this.lbl_Uname_header.AutoSize = true;
            this.lbl_Uname_header.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_Uname_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Uname_header.Location = new System.Drawing.Point(12, 38);
            this.lbl_Uname_header.Name = "lbl_Uname_header";
            this.lbl_Uname_header.Size = new System.Drawing.Size(85, 18);
            this.lbl_Uname_header.TabIndex = 2;
            this.lbl_Uname_header.Text = "Username";
            // 
            // lnk_Logout
            // 
            this.lnk_Logout.AutoSize = true;
            this.lnk_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_Logout.Location = new System.Drawing.Point(1345, 33);
            this.lnk_Logout.Name = "lnk_Logout";
            this.lnk_Logout.Size = new System.Drawing.Size(72, 25);
            this.lnk_Logout.TabIndex = 3;
            this.lnk_Logout.TabStop = true;
            this.lnk_Logout.Text = "Logout";
            this.lnk_Logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_Logout_LinkClicked);
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1446, 741);
            this.Controls.Add(this.lnk_Logout);
            this.Controls.Add(this.lbl_Uname_header);
            this.Controls.Add(this.lbl_CompanyName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frm_Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CompanyName;
        private System.Windows.Forms.Label lbl_Uname_header;
        private System.Windows.Forms.LinkLabel lnk_Logout;
    }
}