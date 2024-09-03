namespace Iguaman.Models.KhidmatNasihat
{
    public class KhidmatNasihat
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string JenisPermohonan { get; set; }
        public string JenisKes {  get; set; }
        public string NamaMangsa { get; set; }
        public string IdPengenalanMangsa { get; set; }
        public string JenisPengenalanMangsa { get; set; }
        public string JantinaMangsa { get; set; }
        public string UmurMangsa { get; set; }
        public string Bangsa { get; set; }
        public string Agama {  get; set; }
        public DateOnly TarikhLahirMangsa { get; set; }
        public string NamaWakil {  get; set; }
        public string AnakNo {  get; set; }
        public string AlamatTetap {  get; set; }
        public string AlamatSurat {  get; set; }
        public string Poskod {  get; set; }
        public string Negeri {  get; set; }
        public bool Perakuan { get; set; }
        public DateTime TarikhCipta { get; set; }
        public string CiptaOleh { get; set; }
        public DateTime TarikhKemaskini { get; set; }
        public string KemaskiniOleh { get; set; }
        public int JumlahBayaran { get; set; }
        public bool StatusBayaran { get; set; }
        public string UlasanPermohonan { get; set; }
        public string UlasanPegawai { get; set; }
        public string Status { get; set; }

        public Guid IdTemuJanji { get; set; }
        public Guid IdPengguna { get; set; }
        public Guid IdKategori { get; set; }


    }
}
