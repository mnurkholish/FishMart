using FishMart.Controller;
using FishMart.Models;
using FishMart.Session;
using FishMart.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishMart.View
{
    public partial class V_RiwayatTransaksiKasir : Form
    {
        private readonly AuthController _authController;
        private readonly ProdukController _produkController;

        public V_RiwayatTransaksiKasir()
        {
            InitializeComponent();
            _authController = new AuthController();
            _produkController = new ProdukController();
        }

        private void V_RiwayatTransaksiKasir_Load(object sender, EventArgs e)
        {
            lblUsername.Text = UserSession.Username;
            lblEmail.Text = UserSession.Email;
        }

        private void btnTKasir_Click(object sender, EventArgs e)
        {
            this.Close();
            V_Transaksi v_Transaksi = new V_Transaksi();
            v_Transaksi.Show();
        }

        private void btnRTKasir_Click(object sender, EventArgs e)
        {
            this.Close();
            V_RiwayatTransaksiKasir RWTKasir = new V_RiwayatTransaksiKasir();
            RWTKasir.Show();
        }

        private void btnProdukKasir_Click(object sender, EventArgs e)
        {
            this.Close();
            V_ProdukKasir produkKasir = new V_ProdukKasir();
            produkKasir.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _authController.logout(this);
        }
    }
}
