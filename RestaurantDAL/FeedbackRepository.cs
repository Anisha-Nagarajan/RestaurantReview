using RestaurantEntity;
namespace RestaurantDAL
{
    public class FeedbackRepository
    {
        public static void AddFeedback(CustomerFeedback feedback)
        {
            using (var restaurantDb = new RestaurantDbContext())
            {
                restaurantDb.Feedbacks.Add(feedback);
                restaurantDb.SaveChanges();
            }
        }
    }
}
