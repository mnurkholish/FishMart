using Microsoft.VisualBasic.Devices;

namespace FishMart.View
{
    partial class V_TambahProduk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_TambahProduk));
            tbNamaProduk = new TextBox();
            gambarProduk = new PictureBox();
            tbHarga = new TextBox();
            tbStok = new TextBox();
            btnTambahProduk = new Button();
            ((System.ComponentModel.ISupportInitialize)gambarProduk).BeginInit();
            SuspendLayout();
            // 
            // tbNamaProduk
            // 
            tbNamaProduk.BorderStyle = BorderStyle.None;
            tbNamaProduk.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNamaProduk.Location = new Point(62, 320);
            tbNamaProduk.Name = "tbNamaProduk";
            tbNamaProduk.Size = new Size(369, 27);
            tbNamaProduk.TabIndex = 0;
            // 
            // gambarProduk
            // 
            gambarProduk.BackColor = Color.Transparent;
            gambarProduk.Location = new Point(136, 37);
            gambarProduk.Name = "gambarProduk";
            gambarProduk.Size = new Size(224, 224);
            gambarProduk.SizeMode = PictureBoxSizeMode.Zoom;
            gambarProduk.TabIndex = 3;
            gambarProduk.TabStop = false;
            gambarProduk.Click += gambarProduk_Click;
            // 
            // tbHarga
            // 
            tbHarga.BorderStyle = BorderStyle.None;
            tbHarga.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbHarga.Location = new Point(62, 407);
            tbHarga.Name = "tbHarga";
            tbHarga.Size = new Size(369, 27);
            tbHarga.TabIndex = 4;
            // 
            // tbStok
            // 
            tbStok.BorderStyle = BorderStyle.None;
            tbStok.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbStok.Location = new Point(62, 494);
            tbStok.Name = "tbStok";
            tbStok.Size = new Size(369, 27);
            tbStok.TabIndex = 5;
            // 
            // btnTambahProduk
            // 
            btnTambahProduk.BackColor = Color.Transparent;
            btnTambahProduk.BackgroundImage = Properties.Resources.btnTambahProduk;
            btnTambahProduk.BackgroundImageLayout = ImageLayout.Zoom;
            btnTambahProduk.FlatAppearance.BorderSize = 0;
            btnTambahProduk.FlatStyle = FlatStyle.Flat;
            btnTambahProduk.Location = new Point(160, 568);
            btnTambahProduk.Name = "btnTambahProduk";
            btnTambahProduk.Size = new Size(175, 35);
            btnTambahProduk.TabIndex = 6;
            btnTambahProduk.UseVisualStyleBackColor = false;
            btnTambahProduk.Click += btnTambahProduk_Click;
            // 
            // V_TambahProduk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BgNewProduk;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(495, 626);
            Controls.Add(btnTambahProduk);
            Controls.Add(tbStok);
            Controls.Add(tbHarga);
            Controls.Add(gambarProduk);
            Controls.Add(tbNamaProduk);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_TambahProduk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tambah Produk";
            ((System.ComponentModel.ISupportInitialize)gambarProduk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNamaProduk;
        private PictureBox gambarProduk;
        private TextBox tbHarga;
        private TextBox tbStok;
        private Button btnTambahProduk;
    }
}