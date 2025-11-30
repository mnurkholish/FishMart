using FishMart.Controller;
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

namespace FishMart.View.Kasir
{
    public partial class V_FormCheckout : Form
    {
        private readonly TransaksiController _controller;
        private readonly Transaksi _transaksi;
        private readonly List<DetailTransaksi> _details;

        public V_FormCheckout(Transaksi trx, List<DetailTransaksi> details)
        {
            InitializeComponent();
            _controller = new TransaksiController();
            _transaksi = trx;
            _details = details;

            lblTotal.Text = trx.TotalHarga.ToString("N0");
        }

        private void tbUangBayar_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tbUangBayar.Text, out int bayar))
            {
                int kembali = bayar - _transaksi.TotalHarga;
                lblKembalian.Text = kembali >= 0
                    ? kembali.ToString("N0")
                    : "Uang kurang";
            }
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbUangBayar.Text, out int bayar) || bayar < _transaksi.TotalHarga)
            {
                MessageBox.Show("Uang tidak cukup.");
                return;
            }

            // Simpan transaksi
            int idTransaksi = _controller.SimpanTransaksi(_transaksi, _details);

            if (idTransaksi < 0)
            {
                MessageBox.Show("Teradi kesalahan. Transaksi tidak tercatat.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Transaksi berhasil disimpan", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Sementara tidak ada nota
            }

            //var nota = new V_Nota(_transaksi, _details, bayar);
            //nota.ShowDialog();
        }
    }
}
