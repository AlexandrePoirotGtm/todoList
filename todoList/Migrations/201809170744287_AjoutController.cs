namespace todoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjoutController : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Taches",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Description = c.String(),
                        DateFin = c.DateTime(nullable: false),
                        Statut = c.Boolean(nullable: false),
                        Priorite = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Taches");
        }
    }
}
