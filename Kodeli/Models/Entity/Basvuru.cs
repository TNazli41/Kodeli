using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kodeli.Models.Entity
{
    public class Basvuru
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Adi { get; set; }
        [Required]
        [MaxLength(50)]
        public string Soyadi { get; set; }
        public virtual Tanimlar Cinsiyet { get; set; }
        [Required]
        [ForeignKey("Cinsiyet")]
        public int CinsiyetId { get; set; }
        public virtual Okul Okul { get; set; }
        [Required]
        [ForeignKey("Okul")]
        public int OkulId { get; set; }
        public virtual YarismaTanim YarismaTanim { get; set; }
        [Required]
        [ForeignKey("YarismaTanim")]
        public int YarismaId { get; set; }
        public DateTime? DogumTairih { get; set; }

        [MaxLength(50)]
        public string? VeliAd { get; set; }
        [MaxLength(50)]
        public string? VeliSoyad { get; set; }
        public string? Eposta{ get; set; }
        public string? CepTel { get; set; }
        public bool? Kvkk { get; set; }
        public bool? Sartname { get; set; } 
        public bool? AltifMi { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? GuncellemeTarihi { get; set; }
        public string? KaydedenKullanici { get; set; }
        public string? GuncelleyenKullanici { get; set; }
        public string? IpAdresi { get; set; }



    }
}
