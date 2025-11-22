using System.ComponentModel.DataAnnotations;

namespace ProjectAPI
{
    public class FavoriteGames
    {
        [Key]
        public required int Game_Id { get; set; }               // PK
       
        public required string Title { get; set; }
        public required string Genre { get; set; }
        public required int Hours_Played { get; set; }
        public required string Platform { get; set; }
        public required int Release_Year { get; set; }
    }
}