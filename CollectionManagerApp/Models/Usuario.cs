using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CollectionManagerApp.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Contrasenia { get; set; }
        public List<Coleccion> Colecciones { get; set; }
        public List<Comentario> Comentarios { get; set; }
    }
}