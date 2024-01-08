using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Modeller
{
    public class Personel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(15)]
        public string Ad { get; set; }


        [Required]
        [MaxLength(10)]
        public string Soyad { get; set; }


        [Required]
        [MaxLength(10)]
        public string Telefon { get; set; }

        
        [MaxLength(40)]
        public string? EPosta { get; set; }

        [MaxLength(300)]
        public string? Adres { get; set; }

        [Required]
        [MaxLength(25)]
        public string KullanıcıAdı { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(7)]
        public string Parola { get; set; }

        [ForeignKey(nameof(Yetki))]
        [Required]
        public int YetkiId { get; set; }
        public virtual Yetki Yetki { get; set; }

        public virtual ICollection<Satış> Satışlar { get; set; } = new HashSet<Satış>();
    }
}
