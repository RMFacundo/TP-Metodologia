using CollectionManagerApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CollectionManagerApp.Data
{
    public class CollectionManagerDBContext : DbContext
    {
        public CollectionManagerDBContext() : base("CollectionManagerDB") { }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Coleccion> Colecciones { get; set; }
    }   
}