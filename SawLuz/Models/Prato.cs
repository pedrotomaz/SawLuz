using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SawLuz.Models
{
    public class Prato
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        [Display(Name ="Valor (R$)")]
        [DisplayFormat(DataFormatString = "{0:n2}")]
        public double Valor { get; set; }

        //public List<Restaurante> Restaurantes { get; set; }

        [Display(Name ="Restaurante")]
        public int RestauranteId { get; set; }
        public virtual Restaurante Restaurante { get; set; }
    }
}