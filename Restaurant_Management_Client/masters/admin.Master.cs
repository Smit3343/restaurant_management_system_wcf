using Restaurant_Management.Dto;
using Restaurant_Management_Client.AccountServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Restaurant_Management_Client.masters
{
    public partial class admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AccountServiceClient client = new AccountServiceClient();
            client.Open();
            try
            {
                if (Request.Cookies["token"] != null)
                {
                    string token = Request.Cookies["token"].Value;
                    UserDto userDto = client.GetUserByToken(token);
                    userName.Visible = true;
                    signoutLink.Visible = true;
                    userName.Text = userDto.Email;
                    signInLink.Visible = false;

                }
            }
            catch (Exception)
            {
                Response.Cookies["token"].Expires = DateTime.Now.AddDays(-1);
                Response.Redirect("/login.aspx");
            }
            finally
            {
                client.Close();
            }
        }
        protected void logoutlink_Click(object sender, EventArgs e)
        {
            Response.Cookies["token"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect("/login.aspx");
        }
    }
}