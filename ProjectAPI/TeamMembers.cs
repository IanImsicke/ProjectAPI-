using System.ComponentModel.DataAnnotations;

namespace ProjectAPI
{
    public class TeamMembers
    {
        [Key]
        public required int Team_Member_Id { get; set; }               // PK
       
        public required string Full_Name { get; set; }
        public required DateOnly Birthdate { get; set; }
        public required string College_Program { get; set; }
        public required string Year_In_Program { get; set; }
        public required string Email { get; set; }
        public required string Favorite_Color {  get; set; }
    }
}