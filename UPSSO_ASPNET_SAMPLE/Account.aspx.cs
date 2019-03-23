using System;
using System.Security.Claims;

namespace UPSSO_ASPNET_SAMPLE
{
    public partial class Account : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.Identity.IsAuthenticated)
            {
                ltMail.Text = User.Identity.Name;

                var identity = (ClaimsIdentity)User.Identity;
                ltDisplayName.Text = identity.FindFirst("name").Value;
            }
        }
    }
}