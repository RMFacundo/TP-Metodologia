using System;
using System.ComponentModel.DataAnnotations;

namespace CollectionManagerApp.Models
{
    public class Comentario
    {
        public string Id { get; set; }
        [Required]
        public string Detalle { get; set; }
        [Required]
        public DateTime FechaDeCreacion { get; set; }
    }
}