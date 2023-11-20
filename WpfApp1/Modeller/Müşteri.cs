using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Modeller
{
    [Table("Müşteriler")]
    public class Müşteri
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(45)]
        public string AdSoyad { get; set; }

        [MaxLength(45)]
        public string FirmaAdı { get; set; }

        [Required]
        [MaxLength(20)]
        public string Telefon { get; set; }

        [MaxLength(45)]
        public string EPosta { get; set; }

        [MaxLength(255)]
        public string Adres { get; set; }

        public virtual ICollection<Satış> Satışlar { get; set; } = new HashSet<Satış>();




    }
}
