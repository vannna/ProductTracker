using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductTrackerApp.Models;

namespace ProductTrackerApp.Services
{
    public interface ISuggestionService
    {
        void AddSuggestion(Product product, string text);
        void UpdateStatus(Suggestion suggestion, Status newStatus);
        List<Suggestion> GetSuggestionsByUser(User user);
        List<Suggestion> GetAllSuggestions();
    }
}
