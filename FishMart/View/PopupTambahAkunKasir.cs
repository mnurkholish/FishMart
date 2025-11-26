using FishMart.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishMart.View
{
    public partial class PopupTambahAkunKasir : Form
    {
        private readonly UserController _userController;
        public PopupTambahAkunKasir()
        {
            InitializeComponent();
            _userController = new UserController();
        }

        private void btnBuatAkun_Click(object sender, EventArgs e)
        {
            var success = _userController.createUser(tbEmail.Text.Trim(), tbPassword.Text.Trim(), tbUsername.Text.Trim(), tbNoTelp.Text.Trim());
            if (success)
            {
                MessageBox.Show("Akun Kasir Berhasil Dibuat", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
