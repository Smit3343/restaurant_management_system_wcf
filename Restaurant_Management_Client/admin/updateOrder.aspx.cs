using Restaurant_Management.Dto;
using Restaurant_Management_Client.OrderServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Restaurant_Management_Client.admin
{
    public partial class updateOrder : System.Web.UI.Page
    {
        int id;
        OrderDtoAdmin order;
        protected void Page_Load(object sender, EventArgs e)
        {

            id = Convert.ToInt32(Request.QueryString["id"]);

            if (!IsPostBack)
            {
                OrderServiceClient client = new OrderServiceClient();
                client.Open();
                try
                {
                    order=client.GetOrderById(id);
                    Label1.Text = order.Id.ToString();
                    Label2.Text = order.UserId.ToString();
                    Label3.Text = order.ItemId.ToString();
                    Label4.Text = order.ItemName.ToString();
                    TextBox1.Text = order.ItemQuantity.ToString();
                    Label6.Text = order.Total.ToString();
                    TextBox2.Text = order.Status;
                    Label7.Text = order.Orderdate.ToString();

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
            OrderServiceClient client = new OrderServiceClient();
            client.Open();
            try
            {
                OrderDtoAdmin order1 = client.GetOrderById(id);
                order1.ItemQuantity =Convert.ToInt32(TextBox1.Text);
                order1.Status = TextBox2.Text;
                client.UpdateOrder(order1);
                Response.Redirect("/admin/Orders.aspx");

            }
            catch (Exception ex)
                {
                errPanel.Visible = true;
                Label8.Text = ex.Message;
                }
                finally
                {
                    client.Close();
                }
        }
    }
}