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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AccountServiceClient client = new AccountServiceClient("BasicHttpBinding_IAccountService");
            client.Open();
            if (Request.Cookies["token"] != null)
            {
                string value = Request.Cookies["token"].Value;
                if (client.isValidToken(value))
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
                AccountServiceReference.AccountServiceClient client = new AccountServiceReference.AccountServiceClient("BasicHttpBinding_IAccountService");
                client.Open();
                User user = new User
                {
                    Name = NameField.Text,
                    Email = EmailField.Text,
                    Password = PasswordField.Text,
                };
                try
                {
                    client.Register(user);
                    Response.Redirect("/home.aspx");
                }
                catch (Exception ex)
                {
                    errPanel.Visible = true;
                    Label5.Text = ex.Message;
                }
                finally
                {
                    client.Close();

                }
            }
            
        }


        protected void emailErr1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            AccountServiceReference.AccountServiceClient client = new AccountServiceReference.AccountServiceClient("BasicHttpBinding_IAccountService");
            client.Open();
            try
            {
                UserDto user = client.getUser(EmailField.Text);
                if (user != null)
                    args.IsValid = false;
                else
                    args.IsValid = true;
            }
            catch(Exception ex)
            {
                errPanel.Visible = true;
                    Label5.Text = ex.Message;
            }
            client.Close();
        }
    }
}