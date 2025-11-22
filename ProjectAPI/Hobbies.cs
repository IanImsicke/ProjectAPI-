using System.ComponentModel.DataAnnotations;

namespace ProjectAPI
{
    public class Hobbies
    {
        [Key]
        public required int Hobby_ID { get; set; }               // PK
       
        public required string Hobby_Name { get; set; }
        public required string Skill_Level { get; set; }
        public required int Weekly_Hours { get; set; }
        public required string Description { get; set; }
        public required string Category { get; set; }
    }
}