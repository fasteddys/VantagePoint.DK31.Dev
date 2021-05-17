
Basic Migration Blueprint showing overall build-up and most use cases in FluentMigrator:
1. Creating tables, defining fields and adding defaults/constraints
2. Altering tables, fields and constraints
3. Renaming tables, fields and constraints


    <code>


    [Migration(20210109094500)]
    public class DefaultDB_20210109_194500_Module_BasicActions : Migration
    {
        public override void Up()
        {
                // (1) Creating objects:
                // Schemas, tables, defining fields and adding defaults/constraints
                
                Create.Schema("mov");

                Create.Table("Movie").InSchema("mov")
                    .WithColumn("MovieId").AsInt32()
                        .Identity().PrimaryKey().NotNullable()
                    .WithColumn("Title").AsString(200).NotNullable()
                    .WithColumn("Description").AsString(1000).Nullable()
                    .WithColumn("Storyline").AsString(Int32.MaxValue).Nullable()
                    .WithColumn("Year").AsInt32().Nullable()
                    .WithColumn("ReleaseDate").AsDateTime().Nullable()
                    .WithColumn("Runtime").AsInt32().Nullable()
                ;  

                Create.Table("MovieGenres").InSchema("mov")
                    .WithColumn("MovieGenreId").AsInt32()
                        .Identity().PrimaryKey().NotNullable()
                    .WithColumn("MovieId").AsInt32().NotNullable()
                        .ForeignKey("FK_MovieGenres_MovieId", "mov", "Movie", "MovieId")
                    .WithColumn("GenreId").AsInt32().NotNullable()
                        .ForeignKey("FK_MovieGenres_GenreId", "mov", "Genre", "GenreId")
                ;

                Create.Table("Person").InSchema("mov")
                    .WithColumn("PersonId").AsInt32().Identity()
                      .PrimaryKey().NotNullable()
                    .WithColumn("Firstname").AsString(50).NotNullable()
                    .WithColumn("Lastname").AsString(50).NotNullable()
                    .WithColumn("BirthDate").AsDateTime().Nullable()
                    .WithColumn("BirthPlace").AsString(100).Nullable()
                    .WithColumn("Gender").AsInt32().Nullable()
                    .WithColumn("Height").AsInt32().Nullable()
                ;

                Create.Table("MovieCast").InSchema("mov")
                    .WithColumn("MovieCastId").AsInt32().Identity()
                        .PrimaryKey().NotNullable()
                    .WithColumn("MovieId").AsInt32().NotNullable()
                        .ForeignKey("FK_MovieCast_MovieId", "mov", "Movie", "MovieId")
                    .WithColumn("PersonId").AsInt32().NotNullable()
                        .ForeignKey("FK_MovieCast_PersonId", "mov", "Person", "PersonId")
                    .WithColumn("Character").AsString(50).Nullable()
                ;

                Create.ForeignKey() // You can name your FK or leave it empty
                    .FromTable("Users").ForeignColumn("CompanyId")
                    .ToTable("Company").PrimaryColumn("Id");


                // (2) Altering objects: 
                // Tables, fields and constraints

                Alter.Table("Movie").InSchema("mov")
                    .AddColumn("Kind").AsInt32().NotNullable()
                        .WithDefaultValue(1)
                ;

                Alter.Table("Movie").InSchema("mov")
                    .AddColumn("GenreId").AsInt32().Nullable()
                        .ForeignKey("FK_Movie_GenreId", "mov", "Genre", "GenreId")
                ;

                Alter.Table("Movie").InSchema("mov")
                    .AlterColumn("GenreId").AsInt16().NotNullable()
                    .SetExistingRowsTo(1);
                ;


                // (3) Renaming tables, fields

                Rename.Table("Users").To("UsersNew");
                Rename.Column("LastName").OnTable("Users").To("Surname");

        }



        public override void Down()
        {
        }
    
       

    </code>

Sign-off:  
Jan-9/2021: emmanuel.sosa@planetaweb.do

