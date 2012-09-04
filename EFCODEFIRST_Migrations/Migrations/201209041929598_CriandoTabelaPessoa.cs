namespace EFCODEFIRST_Migrations.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class CriandoTabelaPessoa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Pessoas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("Pessoas");
        }
    }
}
