namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Drama')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Fantacy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Horror')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Animation')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Adventure')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (7, 'Fiction')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (8, 'Science Fiction')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (9, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (10, 'Anime')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (11, 'War')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (12, 'Comedy')");
        }

        public override void Down()
        {
        }
    }
}
