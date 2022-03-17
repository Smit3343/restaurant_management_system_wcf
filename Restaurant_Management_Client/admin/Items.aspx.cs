using Restaurant_Management;
using Restaurant_Management_Client.ItemServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Restaurant_Management_Client.admin
{
    public partial class Items : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                updateItemTable();
            }
        }
        void updateItemTable()
        {
            ItemServiceClient client = new ItemServiceClient();
            client.Open();
            try
            {
                List<Item> items = client.GetItems().ToList();
                Label1.Text = items.Count.ToString();
                itemtable.DataSource = items;
                itemtable.DataBind();
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
        protected void update_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("/admin/updateItem.aspx?id=" + e.CommandArgument.ToString());
        }

        protected void delete_Command(object sender, CommandEventArgs e)
        {
            ItemServiceClient client = new ItemServiceClient();
            client.Open();
            client.DeleteItem(Convert.ToInt32(e.CommandArgument));
            client.Close();
            updateItemTable();
        }
        public string GetImage(object imgName)
        {
            ItemServiceClient client = new ItemServiceClient();
            client.Open();
            byte[] img = client.getItemPhoto(imgName.ToString());
            client.Close();
            if (img != null)
                return "data:image;base64," + Convert.ToBase64String(img);
            else
                return null;
        }
    }
}