using FishMart.Controller;
using FishMart.Models;

namespace FishMart.View
{
    public partial class V_EditProduk : Form
    {
        private Produk _produk;
        private readonly ProdukController _produkcontroller;
        public V_EditProduk(Produk produk)
        {
            InitializeComponent();
            _produk = produk;
            _produkcontroller = new ProdukController();
        }

        private void V_EditProduk_Load(object sender, EventArgs e)
        {
            tbNamaProduk.Text = _produk.Nama;
            tbHarga.Text = _produk.Harga.ToString();
            tbStok.Text = _produk.Stok.ToString();
            if (_produk.GambarProduk != null)
            {
                using (var ms = new System.IO.MemoryStream(_produk.GambarProduk))
                {
                    GambarProduk.Image = Image.FromStream(ms);
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNamaProduk.Text) ||
                string.IsNullOrWhiteSpace(tbHarga.Text) ||
                string.IsNullOrWhiteSpace(tbStok.Text))
            {
                MessageBox.Show("Semua field harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tbHarga.Text, out int harga) || !int.TryParse(tbStok.Text, out int stok))
            {
                MessageBox.Show("Harga dan Stok harus berupa angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (harga < 0)
            {
                MessageBox.Show("Harga tidak boleh kurang dari 0.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (stok < 0)
            {
                MessageBox.Show("Stok tidak boleh kurang dari 0.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _produk.Nama = tbNamaProduk.Text;
            _produk.Harga = harga;
            _produk.Stok = stok;

            _produkcontroller.UpdateProduk(_produk);
            MessageBox.Show("Produk berhasil diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnUploadGambar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.png;*.jpg;*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                GambarProduk.Image = Image.FromFile(ofd.FileName);

                // Convert ke byte[]
                _produk.GambarProduk = File.ReadAllBytes(ofd.FileName);
            }
        }
    }
}
