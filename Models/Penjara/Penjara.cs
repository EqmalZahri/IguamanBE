namespace Iguaman.Models.Penjara
{
    public class Penjara
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string NamaCawanganPenjara { get; set; }
        public string KodCawanganPenjara { get; set; }
        public bool StatusCawanganPenjara { get; set; }
        public string Alamat1 { get; set; }
        public string Alamat2 { get; set; }
        public string Alamat3 { get; set; }
        public string Poskod { get; set; }
        public string NoTel { get; set; }
        public Guid IdNegeri { get; set; }
    }
}
