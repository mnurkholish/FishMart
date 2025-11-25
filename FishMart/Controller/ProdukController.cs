using FishMart.Models;
using FishMart.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
