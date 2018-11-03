using System;
using System.ComponentModel.DataAnnotations;

namespace Travlr.Models
{
    public class FechaDisponibilidad
    {
        public int ID { get; set; }
        public string UsuarioId { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime FechaFin { get; set; }
    }
}