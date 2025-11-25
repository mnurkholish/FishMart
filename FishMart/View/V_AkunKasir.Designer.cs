namespace FishMart.View
{
    partial class V_AkunKasir
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
            btnDashboard = new Label();
            btnAkunKasir = new Label();
            btnProduk = new Label();
            btnRiwayatTransaksi = new Label();
            btnLogout = new Label();
            lblUsername = new Label();
            lblEmail = new Label();
            SuspendLayout();
            // 
            // btnDashboard
            // 
            btnDashboard.AutoSize = true;
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.Font = new Font("Poppins", 9F);
            btnDashboard.ForeColor = SystemColors.ControlText;
            btnDashboard.Location = new Point(58, 114);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(97, 26);
            btnDashboard.TabIndex = 9;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.BottomLeft;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnAkunKasir
            // 
            btnAkunKasir.AutoSize = true;
            btnAkunKasir.BackColor = Color.Transparent;
            btnAkunKasir.Cursor = Cursors.Hand;
            btnAkunKasir.Font = new Font("Poppins", 9F);
            btnAkunKasir.ForeColor = SystemColors.ControlText;
            btnAkunKasir.Location = new Point(58, 255);
            btnAkunKasir.Name = "btnAkunKasir";
            btnAkunKasir.Size = new Size(87, 26);
            btnAkunKasir.TabIndex = 10;
            btnAkunKasir.Text = "AkunKasir";
            btnAkunKasir.TextAlign = ContentAlignment.BottomLeft;
            btnAkunKasir.Click += btnAkunKasir_Click;
            // 
            // btnProduk
            // 
            btnProduk.AutoSize = true;
            btnProduk.BackColor = Color.Transparent;
            btnProduk.Cursor = Cursors.Hand;
            btnProduk.Font = new Font("Poppins", 9F);
            btnProduk.ForeColor = SystemColors.ControlText;
            btnProduk.Location = new Point(58, 162);
            btnProduk.Name = "btnProduk";
            btnProduk.Size = new Size(65, 26);
            btnProduk.TabIndex = 11;
            btnProduk.Text = "Produk";
            btnProduk.TextAlign = ContentAlignment.BottomLeft;
            btnProduk.Click += btnProduk_Click;
            // 
            // btnRiwayatTransaksi
            // 
            btnRiwayatTransaksi.AutoSize = true;
            btnRiwayatTransaksi.BackColor = Color.Transparent;
            btnRiwayatTransaksi.Cursor = Cursors.Hand;
            btnRiwayatTransaksi.Font = new Font("Poppins", 9F);
            btnRiwayatTransaksi.ForeColor = SystemColors.ControlText;
            btnRiwayatTransaksi.Location = new Point(58, 208);
            btnRiwayatTransaksi.Name = "btnRiwayatTransaksi";
            btnRiwayatTransaksi.Size = new Size(146, 26);
            btnRiwayatTransaksi.TabIndex = 12;
            btnRiwayatTransaksi.Text = "Riwayat Transaksi";
            btnRiwayatTransaksi.TextAlign = ContentAlignment.BottomLeft;
            btnRiwayatTransaksi.Click += btnRiwayatTransaksi_Click;
            // 
            // btnLogout
            // 
            btnLogout.AutoSize = true;
            btnLogout.BackColor = Color.Transparent;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.Gray;
            btnLogout.Location = new Point(58, 608);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(71, 26);
            btnLogout.TabIndex = 13;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.BottomLeft;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Poppins", 9F);
            lblUsername.ForeColor = SystemColors.ControlText;
            lblUsername.Location = new Point(77, 652);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(89, 26);
            lblUsername.TabIndex = 14;
            lblUsername.Text = "Username";
            lblUsername.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Poppins", 7F);
            lblEmail.ForeColor = SystemColors.ControlDarkDark;
            lblEmail.Location = new Point(78, 670);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(118, 22);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "Email@gmail.com";
            lblEmail.TextAlign = ContentAlignment.BottomLeft;
            // 
            // V_AkunKasir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BgAkunKasirAdmin;
            ClientSize = new Size(1280, 720);
            Controls.Add(lblEmail);
            Controls.Add(lblUsername);
            Controls.Add(btnLogout);
            Controls.Add(btnRiwayatTransaksi);
            Controls.Add(btnProduk);
            Controls.Add(btnAkunKasir);
            Controls.Add(btnDashboard);
            Name = "V_AkunKasir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FishMart";
            Load += V_AkunKasir_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label btnDashboard;
        private Label btnAkunKasir;
        private Label btnProduk;
        private Label btnRiwayatTransaksi;
        private Label btnLogout;
        private Label lblUsername;
        private Label lblEmail;
    }
}