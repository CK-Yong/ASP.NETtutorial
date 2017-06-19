using System.Data.Entity.Migrations;

namespace ASP.NETtutorial.Migrations
{
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.Movies",
                    c => new
                    {
                        ID = c.Int(false, true),
                        Title = c.String(),
                        ReleaseDate = c.DateTime(false),
                        Genre = c.String(),
                        Price = c.Decimal(false, 18, 2)
                    })
                .PrimaryKey(t => t.ID);
        }

        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}