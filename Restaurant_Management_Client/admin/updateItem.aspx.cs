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
    public partial class upadateItem : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["id"]);

            if (!IsPostBack)
            {
                ItemServiceClient client = new ItemServiceClient();
                client.Open();
                try
                {
                    Item item = client.GetItem(id);
                    Label2.Text = id.ToString();
                    TextBox2.Text = item.Name;
                    TextBox3.Text = item.Price.ToString();
                    TextBox4.Text = item.Description;
                    TextBox5.Text = item.Category;
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            ItemServiceClient client = new ItemServiceClient();
            client.Open();
            try
            {
                Item item = new Item
                {
                    Id = id,
                    Name = TextBox2.Text,
                    Price = Convert.ToInt32(TextBox3.Text),
                    Description = TextBox4.Text,
                    Category = TextBox5.Text
                };
                client.UpdateItem(item);
                if(FileUpload1.HasFile)
                {
                    client.UploadImage(id, FileUpload1.FileBytes);
                }
                Response.Redirect("/admin/Items.aspx");
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