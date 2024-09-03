namespace Iguaman.Models.Kategori
{
    public class Kategori
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string JenisKategori { get; set; }
    }
}
