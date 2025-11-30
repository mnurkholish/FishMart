namespace FishMart.View
{
    partial class V_RiwayatTransaksi
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_RiwayatTransaksi));
            btnDashboard = new Label();
            btnAkunKasir = new Label();
            btnProduk = new Label();
            btnRiwayatTransaksi = new Label();
            btnLogout = new Label();
            lblUsername = new Label();
            lblEmail = new Label();
            dgvTransaksi = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            UserId = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            Tanggal = new DataGridViewTextBoxColumn();
            TotalHarga = new DataGridViewTextBoxColumn();
            Detail = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).BeginInit();
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
            btnAkunKasir.Size = new Size(91, 26);
            btnAkunKasir.TabIndex = 10;
            btnAkunKasir.Text = "Akun Kasir";
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
            // dgvTransaksi
            // 
            dgvTransaksi.AllowUserToAddRows = false;
            dgvTransaksi.AllowUserToDeleteRows = false;
            dgvTransaksi.AllowUserToResizeColumns = false;
            dgvTransaksi.AllowUserToResizeRows = false;
            dgvTransaksi.AutoGenerateColumns = false;
            dgvTransaksi.BackgroundColor = Color.FromArgb(250, 250, 250);
            dgvTransaksi.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTransaksi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransaksi.Columns.AddRange(new DataGridViewColumn[] { Id, UserId, Username, Tanggal, TotalHarga, Detail });
            dgvTransaksi.Location = new Point(285, 93);
            dgvTransaksi.Name = "dgvTransaksi";
            dgvTransaksi.ReadOnly = true;
            dgvTransaksi.RowHeadersVisible = false;
            dgvTransaksi.RowHeadersWidth = 51;
            dgvTransaksi.Size = new Size(966, 600);
            dgvTransaksi.TabIndex = 16;
            dgvTransaksi.CellClick += dgvTransaksi_CellClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "ID Transaksi";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Resizable = DataGridViewTriState.False;
            Id.Width = 125;
            // 
            // UserId
            // 
            UserId.DataPropertyName = "UserId";
            UserId.HeaderText = "ID Kasir";
            UserId.MinimumWidth = 6;
            UserId.Name = "UserId";
            UserId.ReadOnly = true;
            UserId.Resizable = DataGridViewTriState.False;
            UserId.Width = 125;
            // 
            // Username
            // 
            Username.DataPropertyName = "Username";
            Username.HeaderText = "Kasir";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            Username.ReadOnly = true;
            Username.Width = 125;
            // 
            // Tanggal
            // 
            Tanggal.DataPropertyName = "Tanggal";
            Tanggal.HeaderText = "Tanggal Transaksi";
            Tanggal.MinimumWidth = 6;
            Tanggal.Name = "Tanggal";
            Tanggal.ReadOnly = true;
            Tanggal.Resizable = DataGridViewTriState.False;
            Tanggal.Width = 245;
            // 
            // TotalHarga
            // 
            TotalHarga.DataPropertyName = "TotalHarga";
            TotalHarga.HeaderText = "Total";
            TotalHarga.MinimumWidth = 6;
            TotalHarga.Name = "TotalHarga";
            TotalHarga.ReadOnly = true;
            TotalHarga.Resizable = DataGridViewTriState.False;
            TotalHarga.Width = 220;
            // 
            // Detail
            // 
            Detail.HeaderText = "Detail Transaksi";
            Detail.MinimumWidth = 6;
            Detail.Name = "Detail";
            Detail.ReadOnly = true;
            Detail.Text = "Lihat Detail";
            Detail.UseColumnTextForButtonValue = true;
            Detail.Width = 125;
            // 
            // V_RiwayatTransaksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BgRiwayatTransaksiAdmin;
            ClientSize = new Size(1280, 720);
            Controls.Add(dgvTransaksi);
            Controls.Add(lblEmail);
            Controls.Add(lblUsername);
            Controls.Add(btnLogout);
            Controls.Add(btnRiwayatTransaksi);
            Controls.Add(btnProduk);
            Controls.Add(btnAkunKasir);
            Controls.Add(btnDashboard);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_RiwayatTransaksi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FishMart";
            Load += V_RIwayatTransaksi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTransaksi).EndInit();
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
        private DataGridView dgvTransaksi;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn UserId;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn Tanggal;
        private DataGridViewTextBoxColumn TotalHarga;
        private DataGridViewButtonColumn Detail;
    }
}