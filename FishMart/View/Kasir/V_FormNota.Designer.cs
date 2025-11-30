namespace FishMart.View.Kasir
{
    partial class V_FormNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_FormNota));
            panelContainer = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            separator1 = new Label();
            lblNoTransaksi = new Label();
            lblTanggal = new Label();
            lblToko = new Label();
            pictureBox1 = new PictureBox();
            btnPrint = new Button();
            panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.Transparent;
            panelContainer.Controls.Add(flowLayoutPanel1);
            panelContainer.Controls.Add(label2);
            panelContainer.Controls.Add(separator1);
            panelContainer.Controls.Add(lblNoTransaksi);
            panelContainer.Controls.Add(lblTanggal);
            panelContainer.Controls.Add(lblToko);
            panelContainer.Controls.Add(pictureBox1);
            panelContainer.Location = new Point(12, 57);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(358, 256);
            panelContainer.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(0, 173);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(358, 50);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.BackColor = Color.Gray;
            label2.Location = new Point(0, 168);
            label2.Name = "label2";
            label2.Size = new Size(358, 2);
            label2.TabIndex = 5;
            // 
            // separator1
            // 
            separator1.BackColor = Color.Gray;
            separator1.Location = new Point(0, 162);
            separator1.Name = "separator1";
            separator1.Size = new Size(358, 2);
            separator1.TabIndex = 4;
            // 
            // lblNoTransaksi
            // 
            lblNoTransaksi.AutoSize = true;
            lblNoTransaksi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoTransaksi.Location = new Point(8, 119);
            lblNoTransaksi.Name = "lblNoTransaksi";
            lblNoTransaksi.Size = new Size(103, 20);
            lblNoTransaksi.TabIndex = 3;
            lblNoTransaksi.Text = "No Transaksi : ";
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTanggal.Location = new Point(8, 99);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(148, 20);
            lblTanggal.TabIndex = 2;
            lblTanggal.Text = "yyyy-MM-dd HH:mm";
            // 
            // lblToko
            // 
            lblToko.AutoSize = true;
            lblToko.BackColor = Color.Transparent;
            lblToko.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblToko.Location = new Point(122, 53);
            lblToko.Name = "lblToko";
            lblToko.Size = new Size(110, 31);
            lblToko.TabIndex = 0;
            lblToko.Text = "FishMart";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(154, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.Transparent;
            btnPrint.BackgroundImage = Properties.Resources.print;
            btnPrint.BackgroundImageLayout = ImageLayout.Zoom;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Location = new Point(331, 12);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(39, 39);
            btnPrint.TabIndex = 1;
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // V_FormNota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 342);
            Controls.Add(btnPrint);
            Controls.Add(panelContainer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_FormNota";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nota Transaksi";
            Load += V_FormNota_Load;
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContainer;
        private PictureBox pictureBox1;
        private Label lblToko;
        private Label lblTanggal;
        private Label lblNoTransaksi;
        private Label separator1;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnPrint;
    }
}