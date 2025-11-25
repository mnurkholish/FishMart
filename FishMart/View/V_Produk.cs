using FishMart.Controller;
using FishMart.Models;
using FishMart.Session;
using FishMart.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;   // ❗ WAJIB untuk MemoryStream
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishMart.View
{
    public partial class V_Produk : Form
    {
        private readonly AuthController _authController;
        private readonly ProdukController _produkController;

        public V_Produk()
        {
            InitializeComponent();
            _authController = new AuthController();
            _produkController = new ProdukController();
        }

        private void V_Produk_Load(object sender, EventArgs e)
        {
            lblUsername.Text = UserSession.Username;
            lblEmail.Text = UserSession.Email;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
            V_DashboardAdmin dasborAdmin = new V_DashboardAdmin();
            dasborAdmin.Show();
        }

        private void btnProduk_Click(object sender, EventArgs e)
        {
            this.Close();
            V_Produk produk = new V_Produk();
            produk.Show();
        }

        private void btnRiwayatTransaksi_Click(object sender, EventArgs e)
        {
            this.Close();
            V_RiwayatTransaksi riwayatTransaksi = new V_RiwayatTransaksi();
            riwayatTransaksi.Show();
        }

        private void btnAkunKasir_Click(object sender, EventArgs e)
        {
            this.Close();
            V_AkunKasir akunKasir = new V_AkunKasir();
            akunKasir.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _authController.logout(this);
        }
    }
}
