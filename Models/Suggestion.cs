using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTrackerApp.Models
{
    public class Suggestion
    {
        public string Id { get; set; }
        public Product Product { get; set; }
        public string Text { get; set; }
        public Status Status { get; set; } = Status.UNDER_REVIEW; // Default to "UNDER REVIEW"  
        public User SubmittedBy { get; set; }
        public DateTime SubmissionDate { get; set; }

    }
}
