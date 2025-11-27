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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Transaksi));
            PanelDisplayProduk = new FlowLayoutPanel();
            PanelCart = new FlowLayoutPanel();
            lblTotalHarga = new Label();
            btnCheckout = new Button();
            SuspendLayout();
            // 
            // PanelDisplayProduk
            // 
            PanelDisplayProduk.BackColor = Color.Transparent;
            PanelDisplayProduk.Location = new Point(267, 91);
            PanelDisplayProduk.Name = "PanelDisplayProduk";
            PanelDisplayProduk.Size = new Size(581, 601);
            PanelDisplayProduk.TabIndex = 0;
            // 
            // PanelCart
            // 
            PanelCart.BackColor = Color.Transparent;
            PanelCart.Location = new Point(889, 76);
            PanelCart.Name = "PanelCart";
            PanelCart.Size = new Size(377, 511);
            PanelCart.TabIndex = 1;
            // 
            // lblTotalHarga
            // 
            lblTotalHarga.AutoSize = true;
            lblTotalHarga.BackColor = Color.Transparent;
            lblTotalHarga.Font = new Font("Poppins", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalHarga.Location = new Point(1111, 600);
            lblTotalHarga.Name = "lblTotalHarga";
            lblTotalHarga.Size = new Size(153, 40);
            lblTotalHarga.TabIndex = 2;
            lblTotalHarga.Text = "Total Harga";
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(962, 653);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(94, 29);
            btnCheckout.TabIndex = 3;
            btnCheckout.Text = "button1";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // V_Transaksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1280, 720);
            Controls.Add(btnCheckout);
            Controls.Add(lblTotalHarga);
            Controls.Add(PanelCart);
            Controls.Add(PanelDisplayProduk);
            DoubleBuffered = true;
            Name = "V_Transaksi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_Transaksi";
            Load += V_Transaksi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel PanelDisplayProduk;
        private FlowLayoutPanel PanelCart;
        private Label lblTotalHarga;
        private Button btnCheckout;
    }
}