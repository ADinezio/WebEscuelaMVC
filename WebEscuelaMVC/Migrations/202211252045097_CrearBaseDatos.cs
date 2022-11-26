namespace WebEscuelaMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearBaseDatos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aula",
                c => new
                    {
                        AulaId = c.Int(nullable: false, identity: true),
                        _int = c.Int(name: "int", nullable: false),
                        Estado = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.AulaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Aula");
        }
    }
}
