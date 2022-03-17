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

namespace Restaurant_Management_Client
{
    public partial class ItemDetails : System.Web.UI.Page
    {
        Item item;
        UserDto user;
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            string token=Request.Cookies["token"].Value;
            AccountServiceClient client1 = new AccountServiceClient();
            client1.Open();
            user = client1.GetUserByToken(token);
            if (id != null)
            {
                ItemServiceClient client = new ItemServiceClient();
                client.Open();
                try
                {
                    item = client.GetItem(Convert.ToInt32(id));
                    byte[] img= client.getItemPhoto(item.ImagePath);
                    itemImg.ImageUrl = "data:image;base64," + Convert.ToBase64String(img);
                    NameField.Text = item.Name;
                    PriceField.Text = item.Price.ToString();
                    DescrField.Text = item.Description;
                    CateField.Text = item.Category;
                }
                catch (Exception)
                {
                    Response.Redirect("/home.aspx");
                }
                client.Close();
            }
            else
                Response.Redirect("/home.aspx");
            client1.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(IsValid)
            {
                Order order = new Order
                {
                    ItemId = item.Id,
                    Quantity = Convert.ToInt32(TextBox1.Text),
                    UserId = user.Id,
                };
                OrderServiceClient client = new OrderServiceClient();
                client.Open();
                try
                {
                    client.PlaceOrder(order);
                    orderPlaced.Visible = true;
                    Label1.Text = "order placed successfully";
                }
                catch (Exception ex)
                {
                    orderPlaced.Visible = true;
                    orderPlaced.CssClass = "alert alert-danger";
                    Label1.Text = ex.Message;
                }
            }
            
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            int que=Convert.ToInt32(TextBox1.Text);
            if (que < 0)
                args.IsValid = false;
            else
                args.IsValid = true;
        }
    }
}