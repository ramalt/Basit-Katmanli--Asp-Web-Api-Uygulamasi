using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace EmlakApp.Entities
{
    public class Ev
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(20)]
        public string Adres { get; set; }
        [StringLength(50)]
        public string Fiyat { get; set; }

    }
}