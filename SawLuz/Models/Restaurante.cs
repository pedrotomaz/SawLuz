using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SawLuz.Models
{
    public class Restaurante
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }

        //[Display(Name ="Prato")]
        //public int IdPrato { get; set; }
        //public virtual Prato Prato { get; set; }

        public List<Prato> Pratos { get; set; }
    }
}