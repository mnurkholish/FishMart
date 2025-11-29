namespace FishMart.View
{
    partial class V_Transaksi
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
            btnTKasir = new Label();
            btnRTKasir = new Label();
            btnProdukKasir = new Label();
            btnLogout = new Label();
            lblUsername = new Label();
            lblEmail = new Label();
            PanelDisplayProduk = new FlowLayoutPanel();
            PanelCart = new FlowLayoutPanel();
            label1 = new Label();
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
            // PanelDisplayProduk
            // 
            PanelDisplayProduk.BackColor = Color.Transparent;
            PanelDisplayProduk.Location = new Point(267, 77);
            PanelDisplayProduk.Name = "PanelDisplayProduk";
            PanelDisplayProduk.Size = new Size(581, 601);
            PanelDisplayProduk.TabIndex = 16;
            // 
            // PanelCart
            // 
            PanelCart.BackColor = Color.Transparent;
            PanelCart.Location = new Point(891, 77);
            PanelCart.Name = "PanelCart";
            PanelCart.Size = new Size(377, 511);
            PanelCart.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poppins Medium", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1159, 597);
            label1.Name = "label1";
            label1.Size = new Size(97, 44);
            label1.TabIndex = 18;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.TopRight
            // 
            // V_Transaksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BgTransaksi;
            ClientSize = new Size(1280, 720);
            Controls.Add(label1);
            Controls.Add(PanelCart);
            Controls.Add(PanelDisplayProduk);
            Controls.Add(lblEmail);
            Controls.Add(lblUsername);
            Controls.Add(btnLogout);
            Controls.Add(btnProdukKasir);
            Controls.Add(btnRTKasir);
            Controls.Add(btnTKasir);
            Name = "V_Transaksi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sidebar";
            Load += V_Transaksi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label btnTKasir;
        private Label btnRTKasir;
        private Label btnProdukKasir;
        private Label btnLogout;
        private Label lblUsername;
        private Label lblEmail;
        private FlowLayoutPanel PanelDisplayProduk;
        private FlowLayoutPanel PanelCart;
        private Label label1;
    }
}