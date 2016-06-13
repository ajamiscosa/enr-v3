using System;
using Telerik.WinControls.UI;

namespace Enrollment.Controls
{
    public partial class CreateUser : RadPageViewPage
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void SaveAction(object sender, EventArgs e)
        {
            RadPageView pageView = (RadPageView)this.Parent;
            pageView.Pages.Remove(this);
        }


    }
}
