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
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            tbEmailLogin = new TextBox();
            tbPasswordLogin = new TextBox();
            btnLogin = new Button();
            btnShowPassword = new Button();
            SuspendLayout();
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
            tbEmailLogin.Location = new Point(789, 316);
            tbEmailLogin.Name = "tbEmailLogin";
            tbEmailLogin.Size = new Size(364, 27);
            tbEmailLogin.TabIndex = 2;
            // 
            // tbPasswordLogin
            // 
            tbPasswordLogin.BackColor = Color.White;
            tbPasswordLogin.BorderStyle = BorderStyle.None;
            tbPasswordLogin.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPasswordLogin.Location = new Point(789, 425);
            tbPasswordLogin.Name = "tbPasswordLogin";
            tbPasswordLogin.Size = new Size(337, 27);
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
            // btnShowPassword
            // 
            btnShowPassword.BackColor = Color.Transparent;
            btnShowPassword.BackgroundImage = Properties.Resources.EyesClose;
            btnShowPassword.BackgroundImageLayout = ImageLayout.Stretch;
            btnShowPassword.FlatAppearance.BorderSize = 0;
            btnShowPassword.FlatStyle = FlatStyle.Flat;
            btnShowPassword.Location = new Point(1132, 424);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(30, 30);
            btnShowPassword.TabIndex = 7;
            btnShowPassword.UseVisualStyleBackColor = false;
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // V_FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.login_bg;
            ClientSize = new Size(1280, 719);
            Controls.Add(btnShowPassword);
            Controls.Add(tbEmailLogin);
            Controls.Add(btnLogin);
            Controls.Add(tbPasswordLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FishMart";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private TextBox tbEmailLogin;
        private TextBox tbPasswordLogin;
        private Button btnLogin;
        private Button btnShowPassword;
    }
}