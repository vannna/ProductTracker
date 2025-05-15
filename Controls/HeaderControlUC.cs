using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductTrackerApp.Controls
{
    public partial class HeaderControlUC : UserControl
    {
        // Event to notify when logout is clicked
        public event EventHandler LogoutClicked;

        public HeaderControlUC()
        {
            InitializeComponent();
            // Wire up the button's Click event
            buttonLogout.Click += (s, e) => LogoutClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
