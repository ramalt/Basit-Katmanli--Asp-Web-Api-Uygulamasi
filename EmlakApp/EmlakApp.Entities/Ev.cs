using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace EmlakApp.Entities
{
    public class Ev
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        [StringLength(20)]
        [Required]
        public string Adres { get; set; }
        [StringLength(50)]
        [Required]
        public string Fiyat { get; set; }

    }
}