using Microsoft.AspNetCore.Identity;

namespace Iguaman.Models.Pengguna
{
    public class Pengguna : IdentityUser<Guid>
    {
        public string IdPengguna { get; set; }
        public string JenisPengenalan {  get; set; }
        public string Nama { get; set; }
        public string Alamat1 { get; set; }
        public string Alamat2 { get; set; }
        public string Alamat3 { get; set; }
        public string Poskod { get; set; }
        public string Bandar {  get; set; }
        public string NoTel { get; set; }
        public string Emel { get; set; }
        public string Jantina { get; set; }
        public string Agama { get; set; }
        public string Bangsa { get; set; }
        public string KodKeselamatan { get; set; }
        public string Status { get; set; }
        public string KataLaluan { get; set; }
        public DateTime TarikhCipta { get; set; }
        public string CiptaOleh { get; set; }
        public DateTime TarikhKemaskini { get; set; }
        public string KemaskiniOleh { get; set; }
        public string AlamatPejabat {  get; set; }
        public string JawatanPegawai { get; set; }
        public string GredPegawai { get; set; }
        public string BahagianPegawai { get; set; }
        public bool IsPegawai { get; set; }

        public Guid IdPeranan { get; set; }
        public Guid IdNegeri { get; set; }
        public Guid IdCawanganJBG { get; set; }

    }
}
