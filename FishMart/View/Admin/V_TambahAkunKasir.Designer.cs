namespace FishMart.View
{
    partial class V_TambahAkunKasir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_TambahAkunKasir));
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            tbNoTelp = new TextBox();
            btnBuatAkun = new Button();
            SuspendLayout();
            // 
            // tbEmail
            // 
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Location = new Point(63, 98);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(372, 20);
            tbEmail.TabIndex = 0;
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Location = new Point(63, 360);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(372, 20);
            tbPassword.TabIndex = 1;
            // 
            // tbUsername
            // 
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Location = new Point(63, 185);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(372, 20);
            tbUsername.TabIndex = 2;
            // 
            // tbNoTelp
            // 
            tbNoTelp.BorderStyle = BorderStyle.None;
            tbNoTelp.Location = new Point(63, 273);
            tbNoTelp.Name = "tbNoTelp";
            tbNoTelp.Size = new Size(372, 20);
            tbNoTelp.TabIndex = 3;
            // 
            // btnBuatAkun
            // 
            btnBuatAkun.BackColor = Color.Transparent;
            btnBuatAkun.BackgroundImage = Properties.Resources.BuatAkun;
            btnBuatAkun.BackgroundImageLayout = ImageLayout.Zoom;
            btnBuatAkun.FlatAppearance.BorderSize = 0;
            btnBuatAkun.FlatStyle = FlatStyle.Flat;
            btnBuatAkun.Location = new Point(160, 428);
            btnBuatAkun.Name = "btnBuatAkun";
            btnBuatAkun.Size = new Size(179, 38);
            btnBuatAkun.TabIndex = 4;
            btnBuatAkun.UseVisualStyleBackColor = false;
            btnBuatAkun.Click += btnBuatAkun_Click;
            // 
            // V_TambahAkunKasir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BgPopupTambahAkun1;
            ClientSize = new Size(497, 493);
            Controls.Add(btnBuatAkun);
            Controls.Add(tbNoTelp);
            Controls.Add(tbUsername);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_TambahAkunKasir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tambah Akun Kasir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbEmail;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private TextBox tbNoTelp;
        private Button btnBuatAkun;
    }
}