using FishMart.Models;

namespace FishMart.Repositories
{
    public interface IProdukRepository
    {
        List<Produk> GetListProduk();
        List<Produk> GetListProduk(int limit);
        Produk GetLowStock();
        Produk GetProdukById(int id);
        void InsertProduk(Produk produk);
        void UpdateProduk(Produk produk);
        void UpdateStock(int produksiId, int qtyBaru);
        void DeleteProduk(int produkId);
    }
}
