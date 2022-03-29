using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kodeli.Models.Entity
{
    public class Tanimlar
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Adi { get; set; }
        public virtual TanimlarTur TanimlarTur { get; set; }
        [Required]
        [ForeignKey("TanimlarTur")]
        public int tanimlarTurId { get; set; }
        public bool? AltifMi { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? KaydedenKullanici { get; set; }
        public string? GuncelleyenKullanici { get; set; }
        public string? IpAdresi { get; set; }


    }
}
