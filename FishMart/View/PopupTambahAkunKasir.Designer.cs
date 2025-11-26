namespace FishMart.View
{
    partial class PopupTambahAkunKasir
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
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            tbNoTelp = new TextBox();
            btnBuatAkun = new Button();
            SuspendLayout();
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(90, 62);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(336, 27);
            tbEmail.TabIndex = 0;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(90, 110);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(336, 27);
            tbPassword.TabIndex = 1;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(90, 167);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(336, 27);
            tbUsername.TabIndex = 2;
            // 
            // tbNoTelp
            // 
            tbNoTelp.Location = new Point(90, 228);
            tbNoTelp.Name = "tbNoTelp";
            tbNoTelp.Size = new Size(336, 27);
            tbNoTelp.TabIndex = 3;
            // 
            // btnBuatAkun
            // 
            btnBuatAkun.Location = new Point(208, 290);
            btnBuatAkun.Name = "btnBuatAkun";
            btnBuatAkun.Size = new Size(94, 29);
            btnBuatAkun.TabIndex = 4;
            btnBuatAkun.Text = "Buat";
            btnBuatAkun.UseVisualStyleBackColor = true;
            btnBuatAkun.Click += btnBuatAkun_Click;
            // 
            // PopupTambahAkunKasir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 423);
            Controls.Add(btnBuatAkun);
            Controls.Add(tbNoTelp);
            Controls.Add(tbUsername);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Name = "PopupTambahAkunKasir";
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