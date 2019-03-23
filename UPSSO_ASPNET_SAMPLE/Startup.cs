using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Extensions;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OpenIdConnect;
using Owin;

[assembly: OwinStartup(typeof(UPSSO_ASPNET_SAMPLE.Startup))]

namespace UPSSO_ASPNET_SAMPLE
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // --- START COPY FROM HERE --- //
            app.SetDefaultSignInAsAuthenticationType(CookieAuthenticationDefaults.AuthenticationType);

            app.UseCookieAuthentication(new CookieAuthenticationOptions());

            app.UseOpenIdConnectAuthentication(
            new OpenIdConnectAuthenticationOptions
            {
                ClientId = System.Web.Configuration.WebConfigurationManager.AppSettings["ida:ClientId"],
                Authority = System.Web.Configuration.WebConfigurationManager.AppSettings["ida:AADInstance"] + System.Web.Configuration.WebConfigurationManager.AppSettings["ida:TenantId"],
                PostLogoutRedirectUri = "https://localhost:44374/",
            }
            );

            app.UseStageMarker(PipelineStage.Authenticate);
            // --- END COPY --- //
        }
    }
}
