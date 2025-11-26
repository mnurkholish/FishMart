using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishMart.Models;

namespace FishMart.Repositories
{
    public interface IProdukRepository
    {
        List<Produk> GetListProduk();
        List<Produk> GetListProduk(int limit);
        Produk GetLowStock();
        void InsertProduk(Produk produk);
        void UpdateProduk(Produk produk);
        void DeleteProduk(int produkId);
    }
}
