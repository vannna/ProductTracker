using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTrackerApp.Models
{
    public static class DataStore
    {
        // Static lists to hold application data  
        public static List<User> Users = new List<User>();
        public static List<Product> Products = new List<Product>();
        public static List<Suggestion> Suggestions = new List<Suggestion>();

        // Track current user  
        public static User? CurrentUser;
        // Static constructor for initialization  
        static DataStore()
        {
            // Add sample users  
            Users.Add(new User
            {
                Username = "admin",
                Role = Role.Administrator,
                Password = "admin123"
            });
            Users.Add(new User
            {
                Username = "user1",
                Role = Role.User,
                Password = "user123"
            });
            // Add sample products  
            Products.Add(new Product { Id = 1, Name = "Product A" });
            Products.Add(new Product { Id = 2, Name = "Product B" });

            // Initialize suggestions
            Suggestions.Add(new Suggestion
            {
                Id = Guid.NewGuid().ToString(),
                Product = Products[0],
                Text = "Test suggestion",
                Status = Status.UNDER_REVIEW,
                SubmittedBy = Users[0],
                SubmissionDate = DateTime.Now
            });
        }
    }
}