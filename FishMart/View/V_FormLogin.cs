using FishMart.Controler;
using FishMart.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishMart
{
    public partial class V_FormLogin : Form
    {
        private AuthController _authController;
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

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            V_FormRegister registerForm = new V_FormRegister();
            registerForm.Show();
        }
    }
}
