using FishMart.Models;
using FishMart.Services;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishMart.Controller
{
    public class RiwayatController
    {
        private readonly ITransaksiService _transaksiService;
        private readonly IProdukService _produkService;
        private readonly IUserService _userService;

        public RiwayatController()
        {
            _transaksiService = new TransaksiService();
            _produkService = new ProdukService();
            _userService = new UserService();
        }

        public List<Transaksi> GetRiwayat()
        {
            return _transaksiService.GetAll();
        }

        public List<object> GetRiwayatWithUsername()
        {
            var list = _transaksiService.GetAll();
            var users = _userService.GetAllKasir();

            return list.Select(t => new
            {
                t.Id,
                t.Tanggal,
                t.TotalHarga,
                t.UserId,
                Username = users.First(u => u.Id == t.UserId).Username
            }).ToList<object>();
        }

        public List<DetailTransaksi> GetDetails(int transaksiId)
        {
            return _transaksiService.GetDetail(transaksiId);
        }

        public string GetNamaProduk(int id)
        {
            return _produkService.GetProdukById(id).Nama;
        }

        public string GetNamaKasir(int id)
        {
            return _userService.GetUserById(id).Username;
        }

        public List<object> GetRiwayatKasir(int userId)
        {
            return _transaksiService.GetRiwayatKasir(userId)
                           .Select(t => (object)new
                           {
                               t.Id,
                               t.Tanggal,
                               t.TotalHarga
                           })
                           .ToList();
        }
    }
}
