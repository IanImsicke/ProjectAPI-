using Microsoft.EntityFrameworkCore;

namespace ProjectAPI
{ 

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TeamMembers> TeamMembers { get; set; }
        public DbSet<Hobbies> Hobbies { get; set; }
        public DbSet<BreakfastFoods> BreakfastsFoods { get; set; }
        public DbSet<FavoriteGames> FavoriteGames { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // ---- SEED TEAM MEMBERS ----------------------
            modelBuilder.Entity<TeamMembers>().HasData(
                new TeamMembers
                {
                    Team_Member_Id = 1,
                    Full_Name = "Ian Imsicke",
                    Birthdate = new DateOnly(2005, 1, 20),
                    College_Program = "Information Technology",
                    Year_In_Program = "2nd Year",
                    Email = "imsickia@mail.uc.edu",
                    Favorite_Color = "Red"
                },
                new TeamMembers
                {
                    Team_Member_Id = 2,
                    Full_Name = "?",
                    Birthdate = new DateOnly(2000, 9, 2),
                    College_Program = "?",
                    Year_In_Program = "?",
                    Email = "?",
                    Favorite_Color = "?"
                },
                new TeamMembers
                {
                    Team_Member_Id = 3,
                    Full_Name = "?",
                    Birthdate = new DateOnly(2000, 9, 2),
                    College_Program = "?",
                    Year_In_Program = "?",
                    Email = "?",
                    Favorite_Color = "?"
                },
                new TeamMembers
                {
                    Team_Member_Id = 4,
                    Full_Name = "?",
                    Birthdate = new DateOnly(2000, 9, 2),
                    College_Program = "?",
                    Year_In_Program = "?",
                    Email = "?",
                    Favorite_Color = "?"
                }

            );

            // ---- SEED HOBBIES ---------------------------
            modelBuilder.Entity<Hobbies>().HasData(
                new Hobbies
                {
                    Hobby_ID = 1,
                    Hobby_Name = "Gaming",
                    Skill_Level = "Intermediate",
                    Weekly_Hours = 17,
                    Description = "Playing video games with friends",
                    Category = "Indoor"
                },
                new Hobbies
                {
                    Hobby_ID = 2,
                    Hobby_Name = "?",
                    Skill_Level = "?",
                    Weekly_Hours = 4,
                    Description = "?",
                    Category = "?"
                },
                new Hobbies
                {
                    Hobby_ID = 3,
                    Hobby_Name = "?",
                    Skill_Level = "?",
                    Weekly_Hours = 4,
                    Description = "?",
                    Category = "?"
                },
                new Hobbies
                {
                    Hobby_ID = 4,
                    Hobby_Name = "?",
                    Skill_Level = "?",
                    Weekly_Hours = 4,
                    Description = "?",
                    Category = "?"
                }
            );

            // ---- SEED BREAKFAST FOODS --------------------
            modelBuilder.Entity<BreakfastFoods>().HasData(
                new BreakfastFoods
                {
                    Food_Id = 1,
                    Name = "Breakfast Crunchwrap",
                    Calories = 670,
                    Food_Type = "Wrap",
                    Is_Hot = true,
                    Recommended_Drink = "Orange Juice"
                },
                new BreakfastFoods
                {
                    Food_Id = 2,
                    Name = "?",
                    Calories = 250,
                    Food_Type = "?",
                    Is_Hot = true,
                    Recommended_Drink = "?"
                },
                 new BreakfastFoods
                 {
                     Food_Id = 3,
                     Name = "?",
                     Calories = 250,
                     Food_Type = "?",
                     Is_Hot = true,
                     Recommended_Drink = "?"
                 },
                  new BreakfastFoods
                  {
                      Food_Id = 4,
                      Name = "?",
                      Calories = 250,
                      Food_Type = "?",
                      Is_Hot = true,
                      Recommended_Drink = "?"
                  }
            );

            // ---- SEED FAVORITE GAMES ---------------------
            modelBuilder.Entity<FavoriteGames>().HasData(
                new FavoriteGames
                {
                    Game_Id = 1,
                    Title = "Red Dead Redemption 2",
                    Genre = "Action-Adventure",
                    Hours_Played = 210,
                    Platform = "PC",
                    Release_Year = 2018
                },
                new FavoriteGames
                {
                    Game_Id = 2,
                    Title = "?",
                    Genre = "?",
                    Hours_Played = 300,
                    Platform = "?",
                    Release_Year = 2017
                },
                 new FavoriteGames
                 {
                     Game_Id = 3,
                     Title = "?",
                     Genre = "?",
                     Hours_Played = 300,
                     Platform = "?",
                     Release_Year = 2017
                 },
                  new FavoriteGames
                  {
                      Game_Id = 4,
                      Title = "?",
                      Genre = "?",
                      Hours_Played = 300,
                      Platform = "?",
                      Release_Year = 2017
                  }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}