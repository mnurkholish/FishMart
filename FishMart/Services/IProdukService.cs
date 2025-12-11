using FishMart.Models;

namespace FishMart.Services
{
    public interface IProdukService
    {
        List<Produk> GetListProduk();
        List<Produk> GetListProduk(int limit);
        Produk? GetLowStock();
        Produk? GetProdukById(int id);
        void InsertProduk(Produk produk);
        void UpdateProduk(Produk produk);
        void DeleteProduk(int produkId);
    }
}
