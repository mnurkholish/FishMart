namespace FishMart.View
{
    partial class V_EditProduk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_EditProduk));
            tbNamaProduk = new TextBox();
            tbHarga = new TextBox();
            tbStok = new TextBox();
            btnSimpan = new Button();
            GambarProduk = new PictureBox();
            btnUploadGambar = new Button();
            ((System.ComponentModel.ISupportInitialize)GambarProduk).BeginInit();
            SuspendLayout();
            // 
            // tbNamaProduk
            // 
            tbNamaProduk.BorderStyle = BorderStyle.None;
            tbNamaProduk.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNamaProduk.Location = new Point(61, 321);
            tbNamaProduk.Name = "tbNamaProduk";
            tbNamaProduk.Size = new Size(371, 27);
            tbNamaProduk.TabIndex = 0;
            // 
            // tbHarga
            // 
            tbHarga.BorderStyle = BorderStyle.None;
            tbHarga.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbHarga.Location = new Point(61, 408);
            tbHarga.Name = "tbHarga";
            tbHarga.Size = new Size(371, 27);
            tbHarga.TabIndex = 1;
            // 
            // tbStok
            // 
            tbStok.BorderStyle = BorderStyle.None;
            tbStok.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbStok.Location = new Point(61, 495);
            tbStok.Name = "tbStok";
            tbStok.Size = new Size(371, 27);
            tbStok.TabIndex = 2;
            // 
            // btnSimpan
            // 
            btnSimpan.BackgroundImage = (Image)resources.GetObject("btnSimpan.BackgroundImage");
            btnSimpan.BackgroundImageLayout = ImageLayout.Zoom;
            btnSimpan.FlatAppearance.BorderSize = 0;
            btnSimpan.FlatStyle = FlatStyle.Flat;
            btnSimpan.Location = new Point(159, 568);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(175, 35);
            btnSimpan.TabIndex = 3;
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // GambarProduk
            // 
            GambarProduk.Location = new Point(147, 35);
            GambarProduk.Name = "GambarProduk";
            GambarProduk.Size = new Size(200, 200);
            GambarProduk.SizeMode = PictureBoxSizeMode.Zoom;
            GambarProduk.TabIndex = 4;
            GambarProduk.TabStop = false;
            // 
            // btnUploadGambar
            // 
            btnUploadGambar.BackgroundImage = (Image)resources.GetObject("btnUploadGambar.BackgroundImage");
            btnUploadGambar.BackgroundImageLayout = ImageLayout.Zoom;
            btnUploadGambar.FlatAppearance.BorderSize = 0;
            btnUploadGambar.FlatStyle = FlatStyle.Flat;
            btnUploadGambar.Location = new Point(159, 243);
            btnUploadGambar.Name = "btnUploadGambar";
            btnUploadGambar.Size = new Size(175, 35);
            btnUploadGambar.TabIndex = 5;
            btnUploadGambar.UseVisualStyleBackColor = true;
            btnUploadGambar.Click += btnUploadGambar_Click;
            // 
            // V_EditProduk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(495, 626);
            Controls.Add(btnUploadGambar);
            Controls.Add(GambarProduk);
            Controls.Add(btnSimpan);
            Controls.Add(tbStok);
            Controls.Add(tbHarga);
            Controls.Add(tbNamaProduk);
            DoubleBuffered = true;
            Name = "V_EditProduk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_EditProduk";
            Load += V_EditProduk_Load;
            ((System.ComponentModel.ISupportInitialize)GambarProduk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNamaProduk;
        private TextBox tbHarga;
        private TextBox tbStok;
        private Button btnSimpan;
        private PictureBox GambarProduk;
        private Button btnUploadGambar;
    }
}