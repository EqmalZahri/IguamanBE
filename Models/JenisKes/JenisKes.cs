namespace Iguaman.Models.JenisKes
{
    public class JenisKes
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Jenis_Kes { get; set; }
        public Guid IdKategori { get; set; }
    }
}
