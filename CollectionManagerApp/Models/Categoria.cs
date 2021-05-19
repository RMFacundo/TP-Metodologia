using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CollectionManagerApp.Models
{
    public class Categoria
    {
        public string Id { get; set; }
        [Required]
        public string Nombre { get; set; }
    }
}