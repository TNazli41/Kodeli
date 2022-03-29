using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kodeli.Models.Entity
{
    public class Okul
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Adi { get; set; }
        public virtual Tanimlar OkulTuru { get; set; }  
        [Required]
        [ForeignKey("OkulTuru")]
        public int OkulTuruId { get; set; }
        public virtual Ilce Ilce { get; set; }
        [Required]
        [ForeignKey("Ilce")]
        public int IlceId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? KaydedenKullanici { get; set; }
        public string? GuncelleyenKullanici { get; set; }
        public string? IpAdresi { get; set; }


    }
}
