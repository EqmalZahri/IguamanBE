namespace Iguaman.Models.TemuJanji
{
    public class TemuJanji
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateOnly TarikhTemuJanji { get; set; }
        public TimeOnly MasaMulaTemuJanji { get; set; }
        public TimeOnly MasaAkhirTemuJanji { get; set; }
        public string TempatTemuJanji { get; set; }
        public string Status { get; set; }
        public DateTime TarikhCipta { get; set; }
        public string CiptaOleh { get; set; }
        public DateTime TarikhKemaskini { get; set; }
        public string KemaskiniOleh { get; set; }

        public Guid IdKhidmatNasihat { get; set; }
        public Guid CawanganJBG { get; set; }
        public Guid IdPegawaiKN { get; set; }
    }
}
