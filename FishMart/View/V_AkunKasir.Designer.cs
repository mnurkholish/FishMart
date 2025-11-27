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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_AkunKasir));
            btnDashboard = new Label();
            btnAkunKasir = new Label();
            btnProduk = new Label();
            btnRiwayatTransaksi = new Label();
            btnLogout = new Label();
            lblUsername = new Label();
            lblEmail = new Label();
            dataGridAkunKasir = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            NoTelp = new DataGridViewTextBoxColumn();
            StatusColumn = new DataGridViewTextBoxColumn();
            Toggle = new DataGridViewButtonColumn();
            btnTambahAkunKasir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridAkunKasir).BeginInit();
            SuspendLayout();
            // 
            // btnDashboard
            // 
            btnDashboard.AutoSize = true;
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.Font = new Font("Poppins", 9F);
            btnDashboard.ForeColor = SystemColors.ControlText;
            btnDashboard.Location = new Point(51, 86);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(76, 21);
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
            btnAkunKasir.Location = new Point(51, 191);
            btnAkunKasir.Name = "btnAkunKasir";
            btnAkunKasir.Size = new Size(71, 21);
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
            btnProduk.Location = new Point(51, 122);
            btnProduk.Name = "btnProduk";
            btnProduk.Size = new Size(51, 21);
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
            btnRiwayatTransaksi.Location = new Point(51, 156);
            btnRiwayatTransaksi.Name = "btnRiwayatTransaksi";
            btnRiwayatTransaksi.Size = new Size(115, 21);
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
            btnLogout.Location = new Point(51, 456);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(53, 21);
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
            lblUsername.Location = new Point(67, 489);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(70, 21);
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
            lblEmail.Location = new Point(68, 502);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(96, 18);
            lblEmail.TabIndex = 15;
            lblEmail.Text = "Email@gmail.com";
            lblEmail.TextAlign = ContentAlignment.BottomLeft;
            // 
            // dataGridAkunKasir
            // 
            dataGridAkunKasir.AllowUserToAddRows = false;
            dataGridAkunKasir.AllowUserToResizeColumns = false;
            dataGridAkunKasir.AllowUserToResizeRows = false;
            dataGridAkunKasir.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridAkunKasir.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridAkunKasir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAkunKasir.Columns.AddRange(new DataGridViewColumn[] { ID, Email, Username, NoTelp, StatusColumn, Toggle });
            dataGridAkunKasir.Location = new Point(248, 86);
            dataGridAkunKasir.Margin = new Padding(3, 2, 3, 2);
            dataGridAkunKasir.Name = "dataGridAkunKasir";
            dataGridAkunKasir.ReadOnly = true;
            dataGridAkunKasir.RowHeadersVisible = false;
            dataGridAkunKasir.RowHeadersWidth = 51;
            dataGridAkunKasir.Size = new Size(831, 435);
            dataGridAkunKasir.TabIndex = 16;
            dataGridAkunKasir.CellContentClick += dataGridAkunKasir_CellContentClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "Id";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Resizable = DataGridViewTriState.False;
            ID.Width = 50;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Resizable = DataGridViewTriState.False;
            Email.Width = 277;
            // 
            // Username
            // 
            Username.DataPropertyName = "Username";
            Username.HeaderText = "Username";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            Username.ReadOnly = true;
            Username.Width = 210;
            // 
            // NoTelp
            // 
            NoTelp.DataPropertyName = "NoTelp";
            NoTelp.HeaderText = "No Telp";
            NoTelp.MinimumWidth = 6;
            NoTelp.Name = "NoTelp";
            NoTelp.ReadOnly = true;
            NoTelp.Width = 180;
            // 
            // StatusColumn
            // 
            StatusColumn.DataPropertyName = "StatusText";
            StatusColumn.HeaderText = "Status";
            StatusColumn.MinimumWidth = 6;
            StatusColumn.Name = "StatusColumn";
            StatusColumn.ReadOnly = true;
            StatusColumn.Width = 120;
            // 
            // Toggle
            // 
            Toggle.HeaderText = "Ubah Status";
            Toggle.MinimumWidth = 6;
            Toggle.Name = "Toggle";
            Toggle.ReadOnly = true;
            Toggle.Text = "Toggle";
            Toggle.UseColumnTextForButtonValue = true;
            Toggle.Width = 110;
            // 
            // btnTambahAkunKasir
            // 
            btnTambahAkunKasir.BackColor = Color.Transparent;
            btnTambahAkunKasir.BackgroundImage = Properties.Resources.TambahAkun;
            btnTambahAkunKasir.BackgroundImageLayout = ImageLayout.Zoom;
            btnTambahAkunKasir.Cursor = Cursors.Hand;
            btnTambahAkunKasir.FlatAppearance.BorderSize = 0;
            btnTambahAkunKasir.FlatStyle = FlatStyle.Flat;
            btnTambahAkunKasir.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTambahAkunKasir.ForeColor = SystemColors.ButtonHighlight;
            btnTambahAkunKasir.Location = new Point(939, 46);
            btnTambahAkunKasir.Margin = new Padding(3, 2, 3, 2);
            btnTambahAkunKasir.Name = "btnTambahAkunKasir";
            btnTambahAkunKasir.Size = new Size(140, 22);
            btnTambahAkunKasir.TabIndex = 17;
            btnTambahAkunKasir.UseVisualStyleBackColor = false;
            btnTambahAkunKasir.Click += btnTambahAkunKasir_Click;
            // 
            // V_AkunKasir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BgAkunKasirAdmin;
            ClientSize = new Size(1120, 540);
            Controls.Add(btnTambahAkunKasir);
            Controls.Add(dataGridAkunKasir);
            Controls.Add(lblEmail);
            Controls.Add(lblUsername);
            Controls.Add(btnLogout);
            Controls.Add(btnRiwayatTransaksi);
            Controls.Add(btnProduk);
            Controls.Add(btnAkunKasir);
            Controls.Add(btnDashboard);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "V_AkunKasir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FishMart";
            Load += V_AkunKasir_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridAkunKasir).EndInit();
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
        private DataGridView dataGridAkunKasir;
        private Button btnTambahAkunKasir;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn NoTelp;
        private DataGridViewTextBoxColumn StatusColumn;
        private DataGridViewButtonColumn Toggle;
    }
}