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
    public partial class V_FormRegister : Form
    {
        public V_FormRegister()
        {
            InitializeComponent();
            btnRegis.MouseEnter += btnRegis_MouseEnter;
            btnRegis.MouseLeave += btnRegis_MouseLeave;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void V_FormRegister_Load(object sender, EventArgs e)
        {
            // Set tampilan awal tombol register
            btnRegis.BackgroundImage = Properties.Resources.sing_up;
            btnRegis.BackgroundImageLayout = ImageLayout.Stretch;
            btnRegis.FlatStyle = FlatStyle.Flat;
            btnRegis.FlatAppearance.BorderSize = 0;
            btnRegis.BackColor = Color.Transparent;

        }

        private void btnRegis_MouseEnter(object sender, EventArgs e)
        {
            btnRegis.BackgroundImage = Properties.Resources.sing_up_hover;
        }

        private void btnRegis_MouseLeave(object sender, EventArgs e)
        {
            btnRegis.BackgroundImage = Properties.Resources.sing_up;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            V_FormLogin loginForm = new V_FormLogin();
            loginForm.Show();
        }
    }
}
