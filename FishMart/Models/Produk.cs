namespace FishMart.Models
{
    public class Produk
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public int Harga { get; set; }
        public int Stok { get; set; }
        public byte[] GambarProduk { get; set; }
        public bool IsDelete { get; set; }
    }
}
