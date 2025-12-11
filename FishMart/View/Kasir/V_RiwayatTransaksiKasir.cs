using FishMart.Controller;
using FishMart.Session;
using FishMart.View.Admin;

namespace FishMart.View
{
    public partial class V_RiwayatTransaksiKasir : Form
    {
        private readonly AuthController _authController;
        private readonly RiwayatController _riwayatController;

        public V_RiwayatTransaksiKasir()
        {
            InitializeComponent();
            _authController = new AuthController();
            _riwayatController = new RiwayatController();
        }

        private void V_RiwayatTransaksiKasir_Load(object sender, EventArgs e)
        {
            lblUsername.Text = UserSession.Username;
            lblEmail.Text = UserSession.Email;

            dataGridView1.DataSource = _riwayatController.GetRiwayatKasir(UserSession.Id);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Detail"].Index && e.RowIndex >= 0)
            {
                int trxId = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;

                var transaksi = _riwayatController.GetRiwayat().First(t => t.Id == trxId);
                var details = _riwayatController.GetDetails(trxId);

                var formDetail = new V_DetailTransaksi(transaksi, details);
                formDetail.ShowDialog();
            }
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
