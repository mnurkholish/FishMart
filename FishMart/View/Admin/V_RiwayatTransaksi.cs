using FishMart.Controller;
using FishMart.Session;
using FishMart.View.Admin;

namespace FishMart.View
{
    public partial class V_RiwayatTransaksi : Form
    {
        private readonly AuthController _authController;

        private readonly RiwayatController _riwayatController;

        public V_RiwayatTransaksi()
        {
            InitializeComponent();
            _authController = new AuthController();
            _riwayatController = new RiwayatController();
        }

        private void V_RIwayatTransaksi_Load(object sender, EventArgs e)
        {
            lblUsername.Text = UserSession.Username;
            lblEmail.Text = UserSession.Email;

            dgvTransaksi.DataSource = _riwayatController.GetRiwayatWithUsername();
        }

        private void dgvTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvTransaksi.Columns["Detail"].Index && e.RowIndex >= 0)
            {
                int trxId = (int)dgvTransaksi.Rows[e.RowIndex].Cells["Id"].Value;

                var transaksi = _riwayatController.GetRiwayat().First(t => t.Id == trxId);
                var details = _riwayatController.GetDetails(trxId);

                var formDetail = new V_DetailTransaksi(transaksi, details);
                formDetail.ShowDialog();
            }
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
