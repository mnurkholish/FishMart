using FishMart.Models;
using FishMart.Services;

namespace FishMart.Controller
{
    public class ProdukController
    {
        private readonly ProdukService _produkService;
        public ProdukController()
        {
            _produkService = new ProdukService();
        }
        public List<Produk> GetListProduk()
        {
            return _produkService.GetListProduk();
        }
        public List<Produk> GetListProduk(int limit)
        {
            return _produkService.GetListProduk(limit);
        }
        public Produk? GetProdukById(int id)
        {
            return _produkService.GetProdukById(id);
        }
        public Produk GetProdukHampirHabis()
        {
            return _produkService.GetLowStock();
        }
        public void InsertProduk(Produk p)
        {
            _produkService.InsertProduk(p);
        }

        public void UpdateProduk(Produk p)
        {
            _produkService.UpdateProduk(p);
        }

        public void DeleteProduk(int id)
        {
            _produkService.DeleteProduk(id);
        }

    }
}
