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
        private readonly IProdukRepository _repo;
        public ProdukService()
        {
            _repo = new ProdukRepository();
        }

        public List<Produk> GetListProduk() => _repo.GetListProduk();

        public List<Produk> GetListProduk(int limit) => _repo.GetListProduk(limit);

        public Produk? GetLowStock() => _repo.GetLowStock();
    }
}
