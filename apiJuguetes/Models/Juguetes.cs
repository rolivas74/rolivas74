using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace apiJuguetes.Models
{
    public class Juguetes
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Nombre { get; set; }
        [StringLength(100)]
        public string Descripcion { get; set; }
        [Range(0,100)]
        public int RestriccionEdad { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Compania { get; set; }
        [Required]
        [Range(1,1000)]
        public decimal Precio { get; set; }

    }
}
