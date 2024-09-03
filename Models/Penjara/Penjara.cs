namespace Iguaman.Models.Penjara
{
    public class Penjara
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string NamaCawanganPenjara { get; set; }
        public string StatusCawanganPenjara { get; set; }
        public Guid IdNegeri { get; set; }
    }
}
