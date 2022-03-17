using Restaurant_Management;
using Restaurant_Management.Dto;
using Restaurant_Management_Client.AccountServiceReference;
using Restaurant_Management_Client.ItemServiceReference;
using Restaurant_Management_Client.OrderServiceReference;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Restaurant_Management_Client
{
    public partial class home : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                try
                {
                    ItemServiceClient client1 = new ItemServiceClient();
                    client1.Open();
                    List<Item> items = client1.GetItems().ToList().Take<Item>(9).ToList();
                    itemRepeater.DataSource = items;
                    itemRepeater.DataBind();
                    client1.Close();
                }
                catch (Exception)
                {

                }
            }

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

        protected void all_Command(object sender, CommandEventArgs e)
        {
            ItemServiceClient client = new ItemServiceClient();
            client.Open();
            string arg = e.CommandArgument.ToString();
            if(arg.Equals("all", StringComparison.CurrentCultureIgnoreCase))
            {
                List<Item> items = client.GetItems().ToList().Take<Item>(9).ToList();
                itemRepeater.DataSource = items;
                itemRepeater.DataBind();
            }
            else
            {
                List<Item> items = client.getItemBycategory(arg).ToList().Take<Item>(9).ToList();
                itemRepeater.DataSource = items;
                itemRepeater.DataBind();
            }
            client.Close();
        }

    }
}