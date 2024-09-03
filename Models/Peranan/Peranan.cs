using Microsoft.AspNetCore.Identity;

namespace Iguaman.Models.Peranan
{
    public class Peranan : IdentityRole<Guid>
    {
        public Peranan(string NamaPeranan)
        {
            Name = NamaPeranan;
            NormalizedName = NamaPeranan.ToUpper();
        }
    }
}
