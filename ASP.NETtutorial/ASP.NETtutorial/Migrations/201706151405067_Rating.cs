using System.Data.Entity.Migrations;

namespace ASP.NETtutorial.Migrations
{
    public partial class Rating : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Rating", c => c.String());
        }

        public override void Down()
        {
            DropColumn("dbo.Movies", "Rating");
        }
    }
}