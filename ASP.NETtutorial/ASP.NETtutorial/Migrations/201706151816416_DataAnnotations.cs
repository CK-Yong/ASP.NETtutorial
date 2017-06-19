using System.Data.Entity.Migrations;

namespace ASP.NETtutorial.Migrations
{
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Title", c => c.String(maxLength: 60));
            AlterColumn("dbo.Movies", "Genre", c => c.String(false, 30));
            AlterColumn("dbo.Movies", "Rating", c => c.String(maxLength: 5));
        }

        public override void Down()
        {
        }
    }
}