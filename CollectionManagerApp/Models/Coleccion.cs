using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CollectionManagerApp.Models
{
    public class Coleccion
    {
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public DateTime FechaDeCreacion { get; set; }
        public List<Comentario> Comentarios { get; set; }
        public List<Elemento> Elementos { get; set; }
        public Categoria Categoria { get; set; }
    }
}