namespace FishMart
{
    partial class V_FormLogin
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
            pictureBox1 = new PictureBox();
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            tbEmailLogin = new TextBox();
            tbPasswordLogin = new TextBox();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.login_bg;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1280, 719);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // npgsqlCommandBuilder1
            // 
            npgsqlCommandBuilder1.QuotePrefix = "\"";
            npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // tbEmailLogin
            // 
            tbEmailLogin.BorderStyle = BorderStyle.None;
            tbEmailLogin.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmailLogin.Location = new Point(784, 316);
            tbEmailLogin.Name = "tbEmailLogin";
            tbEmailLogin.Size = new Size(378, 27);
            tbEmailLogin.TabIndex = 2;
            // 
            // tbPasswordLogin
            // 
            tbPasswordLogin.BackColor = Color.White;
            tbPasswordLogin.BorderStyle = BorderStyle.None;
            tbPasswordLogin.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPasswordLogin.Location = new Point(784, 424);
            tbPasswordLogin.Name = "tbPasswordLogin";
            tbPasswordLogin.Size = new Size(378, 27);
            tbPasswordLogin.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.Location = new Point(777, 512);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(393, 54);
            btnLogin.TabIndex = 6;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // V_FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 719);
            Controls.Add(tbEmailLogin);
            Controls.Add(btnLogin);
            Controls.Add(tbPasswordLogin);
            Controls.Add(pictureBox1);
            Name = "V_FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private TextBox tbEmailLogin;
        private TextBox tbPasswordLogin;
        private Button btnLogin;
    }
}