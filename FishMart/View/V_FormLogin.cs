using FishMart.Controller;

namespace FishMart
{
    public partial class V_FormLogin : Form
    {
        private readonly AuthController _authController;
        public V_FormLogin()
        {
            InitializeComponent();
            _authController = new AuthController();
            btnLogin.MouseEnter += btnLogin_MouseEnter;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
        }


        private void FormLogin_Load(object sender, EventArgs e)
        {
            // Set tampilan awal tombol login
            btnLogin.BackgroundImage = Properties.Resources.sing_in;
            btnLogin.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.BackColor = Color.Transparent;

            tbPasswordLogin.UseSystemPasswordChar = true;
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackgroundImage = Properties.Resources.sing_in_hover;
        }

        // Saat mouse keluar
        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackgroundImage = Properties.Resources.sing_in;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tbEmailLogin.Text;
            string password = tbPasswordLogin.Text;
            tbEmailLogin.Text = "";
            tbPasswordLogin.Text = "";
            bool success = _authController.Login(email, password);
            if (!success)
            {
                MessageBox.Show("Username atau Password salah. Silahkan Coba Lagi!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            tbPasswordLogin.UseSystemPasswordChar = !tbPasswordLogin.UseSystemPasswordChar;
            btnShowPassword.BackgroundImage = tbPasswordLogin.UseSystemPasswordChar ? Properties.Resources.EyesClose : Properties.Resources.EyesOpen;
            btnShowPassword.BackgroundImageLayout = ImageLayout.Zoom;
        }
    }
}
