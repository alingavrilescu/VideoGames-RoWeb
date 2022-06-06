using System.ComponentModel.DataAnnotations;

namespace VideoGames.Models
{
    public class Review
    {
        public int Id { get; set; } 
        public string? Name { get; set; }
        public string? ReviewContent { get; set; }

        [DataType(DataType.Date)]
        public DateTime PostDate { get; set; }
        public int GameId { get; set; }
    }
}
