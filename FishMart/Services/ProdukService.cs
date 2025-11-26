using FishMart.Models;
using FishMart.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishMart.Services
{
    public class ProdukService : IProdukService
    {
        private readonly ProdukRepository _repo;
        public ProdukService()
        {
            _repo = new ProdukRepository();
        }
        public List<Produk> GetListProduk()
        {
            return _repo.GetListProduk();
        }
        public List<Produk> GetListProduk(int limit)
        {
            return _repo.GetListProduk(limit);
        }
        public Produk GetLowStock()
        {
            return _repo.GetLowStock();
        }
        public void InsertProduk(Produk produk)
        {
            _repo.InsertProduk(produk);
        }
        public void UpdateProduk(Produk produk)
        {
            _repo.UpdateProduk(produk);
        }
        public void DeleteProduk(int produkId)
        {
            _repo.DeleteProduk(produkId);
        }
    }
}
