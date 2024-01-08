using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Modeller

{
    [Table("Tedarikçiler")]
    public class Tedarikçi
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(60)]
        public string FirmaAdı { get; set; }


        [Required]
        [MaxLength(30)]
        public string YetkiliAdSoyad { get; set; }

        [Required]
        [MaxLength(10)]
        public string Telefon { get; set; }

      
        [MaxLength(40)]
        public string? EPosta { get; set; }

        [MaxLength(300)]
        public string? Adres { get; set; }

        public virtual ICollection<Ürün> Ürünler { get; set; } = new HashSet<Ürün>();

    }
}
