namespace Iguaman.Models.JKM
{
    public class JKM
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string NamaCawanganJKM { get; set; }
        public Guid IdNegeri { get; set; }
    }
}
