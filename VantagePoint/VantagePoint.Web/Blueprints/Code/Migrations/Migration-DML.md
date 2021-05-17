
DML Migration Blueprint showing most data manipulation cases in FluentMigrator:
1. Sql-Insert
2. Sql-Update
3. Sql-Delete/Drop
4. Script execution 
5. If-expressions 


    <code>

    [Migration(20210109125500)]
    public class DefaultDB_20210109_125500_Module_DmlActions : Migration
    {
        public override void Up()
        {

                // (1) Sql-Insert
                // Inserting records using explicit data values 

                Insert.IntoTable("Movie").InSchema("mov")
                .Row(new
                {
                    Title = "The Matrix",
                    Description = "A computer hacker learns from mysterious rebels about the true nature of his reality..",
                    Storyline = "Thomas A. Anderson is a man living two lives. By day he is an average computer programmer..",
                    Year = 1999,
                    ReleaseDate = new DateTime(1999, 03, 31),
                    Runtime = 136
                })
                .Row(new
                {
                    Title = "Pulp Fiction",
                    Description = "The lives of two mob hit men, a boxer, a gangster's wife, and a pair of diner bandits..",
                    Storyline = "Jules Winnfield and Vincent Vega are two hitmen who are out to retrieve a suitcase stolen from..",
                    Year = 1994,
                    ReleaseDate = new DateTime(1994, 10, 14),
                    Runtime = 154
                })
                .Row(new
                {
                    Title = "The Good, the Bad and the Ugly",
                    Description = "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a..",
                    Storyline = "Blondie (The Good) is a professional gunslinger who is out trying to earn a few dollars. Angel Eyes..",
                    Year = 1969,
                    ReleaseDate = new DateTime(1969, 01, 13),
                    Runtime = 161
                })
                .Row(new
                {
                    Title = "Fight Club",
                    Description = "An insomniac office worker, looking for a way to change his life, crosses paths with a devil-may-care..",
                    Storyline = "A ticking-time-bomb insomniac and a slippery soap salesman channel primal male aggression into a shocking..",
                    Year = 1999,
                    ReleaseDate = new DateTime(1999, 10, 15),
                    Runtime = 139
                });



                //* (2) Sql-Update
                // Using Where-expressions or affecting all rows

                Update.Table("Users")
                    .Set(new { Name = "John" })
                    .Where(new { Name = "Johnanna" });
                

                Update.Table("Bar")
                    .Set(new { SomeDate = DateTime.Today })
                    .AllRows();


                // (3) Sql-Delete/Drop: 
                // Tables, fields, constraints, data

                Delete.ForeignKey("FK_Movie_GenreId").OnTable("Movie").InSchema("mov");
                Delete.Column("AllowSubscription").Column("SubscriptionDate").FromTable("Users");

                Delete.FromTable("Users").AllRows(); // delete all rows
                Delete.FromTable("Users").Row(new { FirstName = "John" }); // delete all rows with FirstName==John
                Delete.FromTable("Users").IsNull("Username"); //Delete all rows where Username is nul



                // (4) Executing Sql scripts
                // Inline & using separate files 

                Execute.Sql(
                @"INSERT INTO mov.MovieGenres (MovieId, GenreId) 
                    SELECT m.MovieId, m.GenreId 
                    FROM mov.Movie m 
                    WHERE m.GenreId IS NOT NULL");


                // Execute script in separate file 
                Execute.EmbeddedScript(@"VBS-Kiosk_v3.sql");


                // (5) Conditional expressions
                // Checking Database engine, If-Expressions

                IfDatabase("Sqlite")
                    .Create.Table("Users")
                    .WithColumn("Id").AsInt16().PrimaryKey()
                    .WithColumn("Name").AsString().NotNullable();

                // If-Exists Expessions  
                if (!Schema.Table("Users").Column("FirstName").Exists())
                {
                    this.Create.Column("FirstName").OnTable("Users").AsAnsiString(128).Nullable();
                }
        }


        public override void Down()
        {
        }
    

    </code>


Sign-off:  
Jan-9/2021: emmanuel.sosa@planetaweb.do

