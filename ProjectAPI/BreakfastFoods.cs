using System.ComponentModel.DataAnnotations;

namespace ProjectAPI
{
    public class BreakfastFoods
    {
        [Key]
        public required int Food_Id { get; set; }               // PK
       
        
        public required string Name { get; set; }
        public required int Calories { get; set; }
        public required string Food_Type { get; set; }
        public required Boolean Is_Hot { get; set; }
        public required string Recommended_Drink { get; set; }
    }
}