using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial1_EmilyRoss.Models
{
    public class Producto
    {
        [Key]
        public int ProductoID { get; set; }
        [Required]
        [StringLength(30,MinimumLength =3,ErrorMessage ="Ingrese descripcion entre 3 a 30 caracteres")]
        public string Descripcion { get; set; }
        [Required]
        public double Price { get; set; }
        [DisplayFormat(DataFormatString ="{0:yyyy/MM/dd}")]
        public DateTime Fecha { get; set; }

    }
}