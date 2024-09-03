namespace Iguaman.Models.Cawangan
{
    public class CawanganJBG
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string NamaCawangan { get; set; }
        public Guid IdNegeri { get; set; }
    }
}
