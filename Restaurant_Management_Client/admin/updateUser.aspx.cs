using Restaurant_Management.Dto;
using Restaurant_Management_Client.AccountServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Restaurant_Management_Client.admin
{
    public partial class updateUser : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["id"]);

            if (!IsPostBack)
            {
                AccountServiceClient client = new AccountServiceClient();
                client.Open();
                try
                {
                    UserDto user = client.GetUserById(id);
                    Label4.Text = id.ToString();
                    TextBox1.Text = user.Name;
                    Label3.Text = user.Email;
                    TextBox3.Text = user.Role;
                }
                catch (Exception)
                {
                    Response.Redirect("/admin/dashboard.aspx");
                }
                finally
                {
                    client.Close();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AccountServiceClient client = new AccountServiceClient();
            client.Open();
            try
            {
                UserDto user = new UserDto
                {
                    Id = id,
                    Name = TextBox1.Text,
                    Email=Label3.Text,
                    Role=TextBox3.Text
                };
                client.UpdateUser(user);
                Response.Redirect("/admin/dashboard.aspx");
            }
            catch (Exception ex)
            {
                errPanel.Visible = true;
                Label2.Text = ex.Message;
            }
            finally
            {
                client.Close();
            }
        }
    }
}