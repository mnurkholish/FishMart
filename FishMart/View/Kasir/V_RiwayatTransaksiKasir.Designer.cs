namespace FishMart.View
{
    partial class V_RiwayatTransaksiKasir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_RiwayatTransaksiKasir));
            btnTKasir = new Label();
            btnRTKasir = new Label();
            btnProdukKasir = new Label();
            btnLogout = new Label();
            lblUsername = new Label();
            lblEmail = new Label();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Tanggal = new DataGridViewTextBoxColumn();
            TotalHarga = new DataGridViewTextBoxColumn();
            Detail = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnTKasir
            // 
            btnTKasir.AutoSize = true;
            btnTKasir.BackColor = Color.Transparent;
            btnTKasir.Cursor = Cursors.Hand;
            btnTKasir.Font = new Font("Poppins", 9F);
            btnTKasir.ForeColor = SystemColors.ControlText;
            btnTKasir.Location = new Point(58, 114);
            btnTKasir.Name = "btnTKasir";
            btnTKasir.Size = new Size(84, 26);
            btnTKasir.TabIndex = 9;
            btnTKasir.Text = "Transaksi";
            btnTKasir.TextAlign = ContentAlignment.BottomLeft;
            btnTKasir.Click += btnTKasir_Click;
            // 
            // btnRTKasir
            // 
            btnRTKasir.AutoSize = true;
            btnRTKasir.BackColor = Color.Transparent;
            btnRTKasir.Cursor = Cursors.Hand;
            btnRTKasir.Font = new Font("Poppins", 9F);
            btnRTKasir.ForeColor = SystemColors.ControlText;
            btnRTKasir.Location = new Point(58, 162);
            btnRTKasir.Name = "btnRTKasir";
            btnRTKasir.Size = new Size(146, 26);
            btnRTKasir.TabIndex = 11;
            btnRTKasir.Text = "Riwayat Transaksi";
            btnRTKasir.TextAlign = ContentAlignment.BottomLeft;
            btnRTKasir.Click += btnRTKasir_Click;
            // 
            // btnProdukKasir
            // 
            btnProdukKasir.AutoSize = true;
            btnProdukKasir.BackColor = Color.Transparent;
            btnProdukKasir.Cursor = Cursors.Hand;
            btnProdukKasir.Font = new Font("Poppins", 9F);
            btnProdukKasir.ForeColor = SystemColors.ControlText;
            btnProdukKasir.Location = new Point(58, 208);
            btnProdukKasir.Name = "btnProdukKasir";
            btnProdukKasir.Size = new Size(65, 26);
            btnProdukKasir.TabIndex = 12;
            btnProdukKasir.Text = "Produk";
            btnProdukKasir.TextAlign = ContentAlignment.BottomLeft;
            btnProdukKasir.Click += btnProdukKasir_Click;
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(250, 250, 250);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Tanggal, TotalHarga, Detail });
            dataGridView1.Location = new Point(285, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(801, 600);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "ID Transaksi";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 125;
            // 
            // Tanggal
            // 
            Tanggal.DataPropertyName = "Tanggal";
            Tanggal.HeaderText = "Tanggal Transaksi";
            Tanggal.MinimumWidth = 6;
            Tanggal.Name = "Tanggal";
            Tanggal.ReadOnly = true;
            Tanggal.Width = 300;
            // 
            // TotalHarga
            // 
            TotalHarga.DataPropertyName = "TotalHarga";
            TotalHarga.HeaderText = "Total";
            TotalHarga.MinimumWidth = 6;
            TotalHarga.Name = "TotalHarga";
            TotalHarga.ReadOnly = true;
            TotalHarga.Width = 250;
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
            // V_RiwayatTransaksiKasir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BgRiwayatTransaksiKasir;
            ClientSize = new Size(1280, 720);
            Controls.Add(dataGridView1);
            Controls.Add(lblEmail);
            Controls.Add(lblUsername);
            Controls.Add(btnLogout);
            Controls.Add(btnProdukKasir);
            Controls.Add(btnRTKasir);
            Controls.Add(btnTKasir);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_RiwayatTransaksiKasir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FishMart";
            Load += V_RiwayatTransaksiKasir_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Label btnTKasir;
        private Label btnRTKasir;
        private Label btnProdukKasir;
        private Label btnLogout;
        private Label lblUsername;
        private Label lblEmail;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Tanggal;
        private DataGridViewTextBoxColumn TotalHarga;
        private DataGridViewButtonColumn Detail;
    }
}