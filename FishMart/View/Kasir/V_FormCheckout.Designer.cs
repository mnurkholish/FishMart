namespace FishMart.View.Kasir
{
    partial class V_FormCheckout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_FormCheckout));
            lblTotal = new Label();
            tbUangBayar = new TextBox();
            btnBayar = new Button();
            lblKembalian = new Label();
            SuspendLayout();
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(178, 80);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(269, 36);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total";
            lblTotal.TextAlign = ContentAlignment.TopRight;
            // 
            // tbUangBayar
            // 
            tbUangBayar.BorderStyle = BorderStyle.None;
            tbUangBayar.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUangBayar.Location = new Point(64, 182);
            tbUangBayar.Name = "tbUangBayar";
            tbUangBayar.Size = new Size(368, 30);
            tbUangBayar.TabIndex = 2;
            tbUangBayar.TextChanged += tbUangBayar_TextChanged;
            // 
            // btnBayar
            // 
            btnBayar.BackColor = Color.Transparent;
            btnBayar.BackgroundImage = Properties.Resources.btnBayar;
            btnBayar.BackgroundImageLayout = ImageLayout.Zoom;
            btnBayar.FlatAppearance.BorderSize = 0;
            btnBayar.FlatStyle = FlatStyle.Flat;
            btnBayar.Location = new Point(160, 319);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(177, 38);
            btnBayar.TabIndex = 3;
            btnBayar.UseVisualStyleBackColor = false;
            btnBayar.Click += btnBayar_Click;
            // 
            // lblKembalian
            // 
            lblKembalian.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblKembalian.BackColor = Color.Transparent;
            lblKembalian.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKembalian.Location = new Point(178, 238);
            lblKembalian.Name = "lblKembalian";
            lblKembalian.Size = new Size(269, 36);
            lblKembalian.TabIndex = 4;
            lblKembalian.Text = "-";
            lblKembalian.TextAlign = ContentAlignment.TopRight;
            // 
            // V_FormCheckout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bgCheckout;
            ClientSize = new Size(498, 439);
            Controls.Add(lblKembalian);
            Controls.Add(btnBayar);
            Controls.Add(tbUangBayar);
            Controls.Add(lblTotal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_FormCheckout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Checkout";
            ResumeLayout(false);
            PerformLayout();
        }

        private void TbUangBayar_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblTotal;
        private TextBox tbUangBayar;
        private Button btnBayar;
        private Label lblKembalian;
    }
}