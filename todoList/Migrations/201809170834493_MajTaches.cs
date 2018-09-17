namespace todoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MajTaches : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Taches", "CategorieID", c => c.Int(nullable: false));
            AlterColumn("dbo.Taches", "DateFin", c => c.DateTime());
            AlterColumn("dbo.Taches", "Priorite", c => c.Int());
            CreateIndex("dbo.Taches", "CategorieID");
            AddForeignKey("dbo.Taches", "CategorieID", "dbo.Categories", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Taches", "CategorieID", "dbo.Categories");
            DropIndex("dbo.Taches", new[] { "CategorieID" });
            AlterColumn("dbo.Taches", "Priorite", c => c.Int(nullable: false));
            AlterColumn("dbo.Taches", "DateFin", c => c.DateTime(nullable: false));
            DropColumn("dbo.Taches", "CategorieID");
        }
    }
}
