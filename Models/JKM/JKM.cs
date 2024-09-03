namespace Iguaman.Models.JKM
{
    public class JKM
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string NamaCawanganJKM { get; set; }
        public string KodCawanganJKM { get; set; }
        public bool StatusCawanganJKM { get; set; }
        public string Alamat1 { get; set; }
        public string Alamat2 { get; set; }
        public string Alamat3 { get; set; }
        public string Poskod { get; set; }
        public string NoTel { get; set; }
        public Guid IdNegeri { get; set; }
    }
}
