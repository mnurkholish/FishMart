namespace FishMart.View.Admin
{
    partial class V_EditAkunKasir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_EditAkunKasir));
            tbUsername = new TextBox();
            tbNoTelp = new TextBox();
            tbPassword = new TextBox();
            btnSimpan = new Button();
            SuspendLayout();
            // 
            // tbUsername
            // 
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(66, 114);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(365, 26);
            tbUsername.TabIndex = 0;
            // 
            // tbNoTelp
            // 
            tbNoTelp.BorderStyle = BorderStyle.None;
            tbNoTelp.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNoTelp.Location = new Point(66, 190);
            tbNoTelp.Name = "tbNoTelp";
            tbNoTelp.Size = new Size(365, 26);
            tbNoTelp.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(66, 302);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(365, 26);
            tbPassword.TabIndex = 2;
            // 
            // btnSimpan
            // 
            btnSimpan.BackgroundImage = Properties.Resources.btnSimpanAKun;
            btnSimpan.BackgroundImageLayout = ImageLayout.Zoom;
            btnSimpan.Cursor = Cursors.Hand;
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Location = new Point(161, 428);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(180, 40);
            btnSimpan.TabIndex = 3;
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // V_EditAKunKasir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.BgEditAkun;
            ClientSize = new Size(513, 521);
            Controls.Add(btnSimpan);
            Controls.Add(tbPassword);
            Controls.Add(tbNoTelp);
            Controls.Add(tbUsername);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_EditAKunKasir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Akun Kasir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUsername;
        private TextBox tbNoTelp;
        private TextBox tbPassword;
        private Button btnSimpan;
    }
}