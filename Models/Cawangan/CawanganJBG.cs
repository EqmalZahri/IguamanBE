namespace Iguaman.Models.Cawangan
{
    public class CawanganJBG
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string NamaCawangan { get; set; }
        public string KodCawangan { get; set; }
        public bool StatusJBG { get; set; }
        public string Alamat1 { get; set; }
        public string Alamat2 { get; set; }
        public string Alamat3 { get; set; }
        public string Poskod {  get; set; }
        public string NoTel { get; set; }
        public Guid IdNegeri { get; set; }
    }
}
