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
    public partial class AddItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if(IsValid)
            {
                Item item = new Item
                {
                    Name = TextBox2.Text,
                    Price = Convert.ToInt32(TextBox3.Text),
                    Category = TextBox5.Text,
                    Description = TextBox4.Text,
                };
                ItemServiceClient client = new ItemServiceClient();
                client.Open();
                try
                {
                    int id = client.AddItem(item);
                    client.UploadImage(id, FileUpload1.FileBytes);
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
}