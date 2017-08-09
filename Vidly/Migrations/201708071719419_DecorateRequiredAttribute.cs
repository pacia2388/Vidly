namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DecorateRequiredAttribute : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "DateRelease", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "DateRelease", c => c.DateTime());
        }
    }
}
