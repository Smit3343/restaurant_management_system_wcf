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
    public partial class Orders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                updateOrderTable();
            }
        }
        void updateOrderTable()
        {
            OrderServiceClient client = new OrderServiceClient();
            client.Open();
            try
            {
                List<OrderDtoAdmin> orders = client.GetAllOrders().ToList();
                Label4.Text = orders.Count.ToString();
                orderRepeater.DataSource = orders;
                orderRepeater.DataBind();
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
        protected void OrderUpdate_Command(object sender, CommandEventArgs e)
        {
            Response.Redirect("/admin/updateOrder.aspx?id=" + e.CommandArgument.ToString());
        }

        protected void OrderDelete_Command(object sender, CommandEventArgs e)
        {
            OrderServiceClient client = new OrderServiceClient();
            client.Open();
            try
            {
                client.DeleteOrder(Convert.ToInt32(e.CommandArgument));
                updateOrderTable();
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