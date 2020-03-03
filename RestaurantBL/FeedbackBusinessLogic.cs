using RestaurantDAL;
using RestaurantEntity;

namespace RestaurantBL
{
    public class FeedbackBusinessLogic
    {
        public static void AddFeedback(CustomerFeedback feedback)
        {
            FeedbackRepository.AddFeedback(feedback);
        }
    }
}
