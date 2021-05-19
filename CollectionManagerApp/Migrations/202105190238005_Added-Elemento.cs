namespace CollectionManagerApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedElemento : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Elementoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(nullable: false),
                        Descripcion = c.String(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        Coleccion_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Coleccions", t => t.Coleccion_Id)
                .Index(t => t.Coleccion_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Elementoes", "Coleccion_Id", "dbo.Coleccions");
            DropIndex("dbo.Elementoes", new[] { "Coleccion_Id" });
            DropTable("dbo.Elementoes");
        }
    }
}
