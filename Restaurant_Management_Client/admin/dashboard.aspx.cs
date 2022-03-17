using Restaurant_Management;
using Restaurant_Management.Dto;
using Restaurant_Management.models;
using Restaurant_Management_Client.AccountServiceReference;
using Restaurant_Management_Client.ItemServiceReference;
using Restaurant_Management_Client.OrderServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Restaurant_Management_Client.admin
{
    public partial class dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

                updateUserTable();
            }
        }
        
        void updateUserTable()
        {
            AccountServiceClient client = new AccountServiceClient();
            client.Open();
            try
            {
                List<UserDto> users = client.GetUsers().ToList();
                Label3.Text = users.Count.ToString();
                userTable.DataSource = users;
                userTable.DataBind();
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
        
        protected void userUpdate_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("/admin/updateUser.aspx?id=" + e.CommandArgument.ToString());
        }

        protected void userDelete_Command(object sender, CommandEventArgs e)
        {
            AccountServiceClient client = new AccountServiceClient();
            client.Open();
            client.DeleteUser(Convert.ToInt32(e.CommandArgument));
            client.Close();
            updateUserTable();
        }

        
    }
}