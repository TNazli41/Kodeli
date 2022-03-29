using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kodeli.Models.Entity
{
    public class YarismaTanim
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Adi { get; set; }
        public virtual Tanimlar YarismaTuru { get; set; }
        [Required]
        [ForeignKey("YarismaTuru")]
        public int YarismaTuruId    { get; set; }
        public int? Kontenjan { get; set; }
        public bool? AltifMi { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? KaydedenKullanici { get; set; }
        public string? GuncelleyenKullanici { get; set; }
        public string? IpAdresi { get; set; }
    }
}
