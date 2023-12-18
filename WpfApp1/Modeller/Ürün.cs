using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Modeller
{
    [Table("Ürünler")]
    public class Ürün
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ÜrünAdı { get; set; }


        [ForeignKey(nameof(Kategori))]
        [Required]
        public int KategoriId { get; set; }
        public virtual Kategori Kategori { get; set; }

        [ForeignKey(nameof(Tedarikçi))]
        [Required]
        public int TedarikçiId { get; set; }
        public virtual Tedarikçi Tedarikçi { get; set; }

        [Required]
        public int StokAdedi { get; set; }

        [Required]
        public int Fiyat { get; set; }

        public string? Açıklama { get; set; }

        public virtual ICollection<SatışDetayı> SatışDetayları { get; set; } = new HashSet<SatışDetayı>();

    }
}
