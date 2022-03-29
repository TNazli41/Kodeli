using System.ComponentModel.DataAnnotations;

namespace Kodeli.Models.Entity
{
    public class TanimlarTur
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
       public string? Adi { get; set; }
       public bool? AltifMi { get; set; }
       public string? Aciklama { get; set; }
       public DateTime? KayitTarihi { get; set; }
       public DateTime? GuncellemeTarihi { get; set; }
       public string? KaydedenKullanici { get; set; }
       public string? GuncelleyenKullanici { get; set; }
       public string? IpAdresi { get; set; }


    }
}
