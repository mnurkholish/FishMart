using FishMart.Controller;
using FishMart.Session;
using FishMart.View.Admin;

namespace FishMart.View
{
    public partial class V_AkunKasir : Form
    {
        private readonly AuthController _authController;
        private readonly UserController _userController;

        public V_AkunKasir()
        {
            InitializeComponent();
            _authController = new AuthController();
            _userController = new UserController();
        }

        private void V_AkunKasir_Load(object sender, EventArgs e)
        {
            lblUsername.Text = UserSession.Username;
            lblEmail.Text = UserSession.Email;

            _userController.FillDataWithAkunKasir(dataGridAkunKasir);
        }

        private void dataGridAkunKasir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridAkunKasir.Columns["Toggle"].Index && e.RowIndex >= 0)
            {
                int userId = (int)dataGridAkunKasir.Rows[e.RowIndex].Cells["Id"].Value;
                _userController.ToggleUserStatus(userId);
                V_AkunKasir_Load(this, EventArgs.Empty);
            }

            else if (e.ColumnIndex == dataGridAkunKasir.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                int userId = (int)dataGridAkunKasir.Rows[e.RowIndex].Cells["Id"].Value;
                string username = (string)dataGridAkunKasir.Rows[e.RowIndex].Cells["Username"].Value;
                string noTelp = (string)dataGridAkunKasir.Rows[e.RowIndex].Cells["NoTelp"].Value;
                var editAkunKasir = new V_EditAkunKasir(userId, username, noTelp);
                editAkunKasir.ShowDialog();
                V_AkunKasir_Load(sender, EventArgs.Empty);
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

        private void btnTambahAkunKasir_Click(object sender, EventArgs e)
        {
            V_TambahAkunKasir tambahAkunKasir = new V_TambahAkunKasir();
            tambahAkunKasir.ShowDialog();
            V_AkunKasir_Load(this, EventArgs.Empty);
        }
    }
}
