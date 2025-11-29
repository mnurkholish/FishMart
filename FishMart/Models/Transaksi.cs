using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishMart.Models
{
    public class Transaksi
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Tanggal { get; set; }
        public int TotalHarga { get; set; }

        public List<DetailTransaksi>  Detail { get; set; }
    }
}
