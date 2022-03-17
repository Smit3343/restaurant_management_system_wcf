using Restaurant_Management.Dto;
using Restaurant_Management.models;
using Restaurant_Management_Client.AccountServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Restaurant_Management_Client
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AccountServiceClient client = new AccountServiceClient("BasicHttpBinding_IAccountService");
            client.Open();
            if (Request.Cookies["token"] != null)
            {
                string value = Request.Cookies["token"].Value;
                if(client.isValidToken(value))
                {
                    Response.Redirect("/home.aspx");
                }
                else
                {
                    Response.Cookies["token"].Expires = DateTime.Now.AddDays(-1);
                }
            }
            client.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(IsValid)
            {
                AccountServiceClient client = new AccountServiceClient("BasicHttpBinding_IAccountService");
                client.Open();
                try
                {
                    Credentials credentials = new Credentials
                    {
                        Email = EmailField.Text,
                        Password = PasswordField.Text
                    };
                    string token = client.Login(credentials);
                    Label1.Text = token;
                    HttpCookie cookie = new HttpCookie("token");
                    cookie.Value = token;
                    cookie.Expires = DateTime.Now.AddHours(3);
                    Response.SetCookie(cookie);
                    UserDto user = client.GetUserByToken(token);
                    if (user.Role.Equals("admin", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Response.Redirect("/admin/dashboard.aspx");
                    }
                    else
                        Response.Redirect("/home.aspx");
                }
                catch (Exception ex)
                {
                    errPanel.Visible = true;
                    Label1.Text = ex.Message;
                }
                finally
                {
                    client.Close();

                }
            }
            
        }
    }
}