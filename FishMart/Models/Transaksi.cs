using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishMart.Models
{
    public class Transaksi
    {
        public int IdTransaksi { get; set; }
        public int IdProduk { get; set; }
        public int Jumlah { get; set; }
        public DateTime Tanggal { get; set; }
    }
}
