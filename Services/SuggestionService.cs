using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductTrackerApp.Models;

namespace ProductTrackerApp.Services
{
    public class SuggestionService: ISuggestionService
    {
        // Add a new suggestion  
        public void AddSuggestion(Product product, string text)
        {
            Suggestion newSuggestion = new Suggestion
            {
                Id = Guid.NewGuid().ToString(),
                Product = product,
                Text = text,
                Status = Status.UNDER_REVIEW,
                SubmittedBy = DataStore.CurrentUser,
                SubmissionDate = DateTime.Now
            };
            DataStore.Suggestions.Add(newSuggestion);
        }

        // Update a suggestion's status  
        public void UpdateStatus(Suggestion suggestion, Status newStatus)
        {
            suggestion.Status = newStatus;
        }

        public List<Suggestion> GetSuggestionsByUser(User user)
        {
            return DataStore.Suggestions
                .Where(s => s.SubmittedBy == user)
                .ToList();
        }

        public List<Suggestion> GetAllSuggestions()
        {
            return DataStore.Suggestions.ToList();
        }
    }
}
