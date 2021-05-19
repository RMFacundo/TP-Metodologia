namespace CollectionManagerApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCategoria : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Nombre = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Coleccions", "Categoria_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Coleccions", "Categoria_Id");
            AddForeignKey("dbo.Coleccions", "Categoria_Id", "dbo.Categorias", "Id");
            DropColumn("dbo.Coleccions", "Categoria");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Coleccions", "Categoria", c => c.String(nullable: false));
            DropForeignKey("dbo.Coleccions", "Categoria_Id", "dbo.Categorias");
            DropIndex("dbo.Coleccions", new[] { "Categoria_Id" });
            DropColumn("dbo.Coleccions", "Categoria_Id");
            DropTable("dbo.Categorias");
        }
    }
}
