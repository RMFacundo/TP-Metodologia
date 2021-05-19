namespace CollectionManagerApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Coleccions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(nullable: false),
                        Categoria = c.String(nullable: false),
                        Descripcion = c.String(nullable: false),
                        FechaDeCreacion = c.DateTime(nullable: false),
                        Usuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_Id)
                .Index(t => t.Usuario_Id);
            
            CreateTable(
                "dbo.Comentarios",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Detalle = c.String(nullable: false),
                        FechaDeCreacion = c.DateTime(nullable: false),
                        Coleccion_Id = c.Int(),
                        Usuario_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Coleccions", t => t.Coleccion_Id)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_Id)
                .Index(t => t.Coleccion_Id)
                .Index(t => t.Usuario_Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Contrasenia = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comentarios", "Usuario_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Coleccions", "Usuario_Id", "dbo.Usuarios");
            DropForeignKey("dbo.Comentarios", "Coleccion_Id", "dbo.Coleccions");
            DropIndex("dbo.Comentarios", new[] { "Usuario_Id" });
            DropIndex("dbo.Comentarios", new[] { "Coleccion_Id" });
            DropIndex("dbo.Coleccions", new[] { "Usuario_Id" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Comentarios");
            DropTable("dbo.Coleccions");
        }
    }
}
