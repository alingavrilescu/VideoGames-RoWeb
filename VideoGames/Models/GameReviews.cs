namespace VideoGames.Models
{
    public class GameReviews
    {
        public GameReviews(Games gameItem, List<Review> reviewList)
        {
            GamesItem = gameItem;
            ReviewList = reviewList;
        }
        public Games GamesItem { get; set; }
        public List<Review> ReviewList { get; set; }
    }
}
