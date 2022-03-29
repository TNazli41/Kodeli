using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kodeli.Models.Entity
{
    public class Ilce
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Adi { get; set; }
        public int IlceKodu { get; set; }
        public virtual Il Il { get; set; }
        [Required]
        [ForeignKey("Il")]
        public int IlId { get; set; }
        public bool? AltifMi { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? KaydedenKullanici { get; set; }
        public string? GuncelleyenKullanici { get; set; }
        public string? IpAdresi { get; set; }
    }
}
