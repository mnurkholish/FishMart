namespace FishMart.View.Admin
{
    partial class V_DetailTransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_DetailTransaksi));
            lblJudul = new Label();
            lblId = new Label();
            lblTanggal = new Label();
            lblTotal = new Label();
            lblUser = new Label();
            panelContainer = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(60, 9);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(210, 40);
            lblJudul.TabIndex = 1;
            lblJudul.Text = "Detail Transaksi";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(15, 49);
            lblId.Name = "lblId";
            lblId.Size = new Size(95, 20);
            lblId.TabIndex = 2;
            lblId.Text = "No. Transaksi";
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Location = new Point(15, 72);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(61, 20);
            lblTanggal.TabIndex = 3;
            lblTanggal.Text = "Tanggal";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(15, 118);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 20);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(15, 95);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(41, 20);
            lblUser.TabIndex = 5;
            lblUser.Text = "Kasir";
            // 
            // panelContainer
            // 
            panelContainer.AutoSize = true;
            panelContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelContainer.Controls.Add(flowLayoutPanel1);
            panelContainer.Location = new Point(12, 141);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(6, 6);
            panelContainer.TabIndex = 6;
            panelContainer.AutoSize = true;
            panelContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelContainer.MinimumSize = new Size(200, 50);
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(0, 0);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.MinimumSize = new Size(300, 50);
            flowLayoutPanel1.Layout += FlowLayoutPanel1_Layout;
            flowLayoutPanel1.ControlAdded += FlowLayoutPanel1_ControlAdded;
            // 
            // V_DetailTransaksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 178);
            Controls.Add(panelContainer);
            Controls.Add(lblUser);
            Controls.Add(lblTotal);
            Controls.Add(lblTanggal);
            Controls.Add(lblId);
            Controls.Add(lblJudul);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_DetailTransaksi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detail Transaksi";
            Load += V_DetailTransaksi_Load;
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJudul;
        private Label lblId;
        private Label lblTanggal;
        private Label lblTotal;
        private Label lblUser;
        private Panel panelContainer;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}