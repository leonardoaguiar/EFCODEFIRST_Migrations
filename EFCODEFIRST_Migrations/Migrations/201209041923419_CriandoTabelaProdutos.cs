namespace EFCODEFIRST_Migrations.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class CriandoTabelaProdutos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Produtos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Descricao = c.String(),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        validade = c.DateTime(nullable: false),
                        Comentarios = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("Produtos");
        }
    }
}
