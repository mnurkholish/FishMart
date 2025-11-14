namespace FishMart
{
    partial class V_FormRegister
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
            panel1 = new Panel();
            btnSignIn = new LinkLabel();
            btnRegis = new Button();
            tbPasswordRegis = new TextBox();
            tbNomorTlpRegis = new TextBox();
            tbUsernameRegis = new TextBox();
            tbEmailRegis = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSignIn);
            panel1.Controls.Add(btnRegis);
            panel1.Controls.Add(tbPasswordRegis);
            panel1.Controls.Add(tbNomorTlpRegis);
            panel1.Controls.Add(tbUsernameRegis);
            panel1.Controls.Add(tbEmailRegis);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(564, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 719);
            panel1.TabIndex = 0;
            // 
            // btnSignIn
            // 
            btnSignIn.AutoSize = true;
            btnSignIn.BackColor = Color.White;
            btnSignIn.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignIn.Location = new Point(262, 626);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(195, 31);
            btnSignIn.TabIndex = 8;
            btnSignIn.TabStop = true;
            btnSignIn.Text = "Sudah punya akun?";
            btnSignIn.LinkClicked += btnSignIn_LinkClicked;
            // 
            // btnRegis
            // 
            btnRegis.Location = new Point(217, 570);
            btnRegis.Name = "btnRegis";
            btnRegis.Size = new Size(268, 48);
            btnRegis.TabIndex = 7;
            btnRegis.UseVisualStyleBackColor = true;
            // 
            // tbPasswordRegis
            // 
            tbPasswordRegis.BackColor = Color.White;
            tbPasswordRegis.BorderStyle = BorderStyle.None;
            tbPasswordRegis.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPasswordRegis.Location = new Point(159, 494);
            tbPasswordRegis.Name = "tbPasswordRegis";
            tbPasswordRegis.Size = new Size(398, 27);
            tbPasswordRegis.TabIndex = 6;
            // 
            // tbNomorTlpRegis
            // 
            tbNomorTlpRegis.BackColor = Color.White;
            tbNomorTlpRegis.BorderStyle = BorderStyle.None;
            tbNomorTlpRegis.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNomorTlpRegis.Location = new Point(159, 414);
            tbNomorTlpRegis.Name = "tbNomorTlpRegis";
            tbNomorTlpRegis.Size = new Size(398, 27);
            tbNomorTlpRegis.TabIndex = 5;
            // 
            // tbUsernameRegis
            // 
            tbUsernameRegis.BackColor = Color.White;
            tbUsernameRegis.BorderStyle = BorderStyle.None;
            tbUsernameRegis.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsernameRegis.Location = new Point(159, 333);
            tbUsernameRegis.Name = "tbUsernameRegis";
            tbUsernameRegis.Size = new Size(398, 27);
            tbUsernameRegis.TabIndex = 4;
            // 
            // tbEmailRegis
            // 
            tbEmailRegis.BackColor = Color.White;
            tbEmailRegis.BorderStyle = BorderStyle.None;
            tbEmailRegis.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmailRegis.Location = new Point(159, 251);
            tbEmailRegis.Name = "tbEmailRegis";
            tbEmailRegis.Size = new Size(398, 27);
            tbEmailRegis.TabIndex = 2;
            tbEmailRegis.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.panel_form_regis;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(716, 719);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Log_in_bg;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1280, 719);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // V_FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 719);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "V_FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_FormRegister";
            Load += V_FormRegister_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox tbEmailRegis;
        private TextBox tbNomorTlpRegis;
        private TextBox tbUsernameRegis;
        private LinkLabel btnSignIn;
        private Button btnRegis;
        private TextBox tbPasswordRegis;
    }
}