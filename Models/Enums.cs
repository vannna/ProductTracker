using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTrackerApp.Models
{
    public enum Status
    {
        UNDER_REVIEW,
        AWAITING,
        ACCEPTED,
        REJECTED
    }

    public enum Role
    {
        Administrator,
        User
    }
}
