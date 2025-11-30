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

namespace FishMart.View.Admin
{
    public partial class V_EditAKunKasir : Form
    {
        private readonly UserController _userController;

        private int _userId;
        private string _username;
        private string _noTelp;

        public V_EditAKunKasir(int userId, string username, string noTelp)
        {
            InitializeComponent();
            _userController = new UserController();

            _userId = userId;
            _username = username;
            _noTelp = noTelp;

            tbUsername.Text = _username;
            tbNoTelp.Text = _noTelp;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            var success = _userController.UpdateUser(_userId, tbUsername.Text.Trim(), tbNoTelp.Text.Trim(), tbPassword.Text.Trim());
            if (success)
            {
                MessageBox.Show("Akun Kasir Berhasil Diedit", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
