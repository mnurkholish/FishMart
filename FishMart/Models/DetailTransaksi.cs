namespace FishMart.Models
{
    public class DetailTransaksi
    {
        public int Id { get; set; }
        public int TransaksiId { get; set; }
        public int ProdukId { get; set; }
        public int Qty { get; set; }
        public int HargaSatuan { get; set; }
        public int Subtotal { get; set; }
    }
}
