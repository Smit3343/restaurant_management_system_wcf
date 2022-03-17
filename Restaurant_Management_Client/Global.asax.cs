using Restaurant_Management.Dto;
using Restaurant_Management.models;
using Restaurant_Management_Client.AccountServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Restaurant_Management_Client
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            var url = Request.Url.LocalPath;
            if (url != "/login.aspx" && url != "/register.aspx")
                if (Request.Cookies["token"] == null)
                    Response.Redirect("/login.aspx");
                else if (url.Contains("admin"))
                {
                    AccountServiceClient client = new AccountServiceClient();
                    client.Open();
                    UserDto user= client.GetUserByToken(Request.Cookies["token"].Value);
                    if(!user.Role.Equals("admin", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Response.Redirect("/home.aspx");
                    }
                }
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
        
    }
}