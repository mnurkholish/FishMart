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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_FormLogin));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnLogin = new Button();
            tbPasswordLogin = new TextBox();
            linkLabel1 = new LinkLabel();
            tbEmailLogin = new TextBox();
            pictureBox2 = new PictureBox();
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1280, 720);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(tbPasswordLogin);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(tbEmailLogin);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(564, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 719);
            panel1.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(225, 548);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(268, 48);
            btnLogin.TabIndex = 6;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // tbPasswordLogin
            // 
            tbPasswordLogin.BackColor = Color.White;
            tbPasswordLogin.BorderStyle = BorderStyle.None;
            tbPasswordLogin.Font = new Font("Poppins", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPasswordLogin.Location = new Point(136, 458);
            tbPasswordLogin.Name = "tbPasswordLogin";
            tbPasswordLogin.Size = new Size(441, 33);
            tbPasswordLogin.TabIndex = 5;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Red;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.White;
            linkLabel1.Font = new Font("Poppins", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(307, 608);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(105, 40);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign Up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // tbEmailLogin
            // 
            tbEmailLogin.BorderStyle = BorderStyle.None;
            tbEmailLogin.Font = new Font("Poppins", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmailLogin.Location = new Point(136, 339);
            tbEmailLogin.Name = "tbEmailLogin";
            tbEmailLogin.Size = new Size(441, 33);
            tbEmailLogin.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(716, 719);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // npgsqlCommandBuilder1
            // 
            npgsqlCommandBuilder1.QuotePrefix = "\"";
            npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 719);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private PictureBox pictureBox2;
        private LinkLabel linkLabel1;
        private TextBox tbEmailLogin;
        private TextBox tbPasswordLogin;
        private Button btnLogin;
    }
}