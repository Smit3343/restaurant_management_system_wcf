using Restaurant_Management.Dto;
using Restaurant_Management.models;
using Restaurant_Management_Client.AccountServiceReference;
using Restaurant_Management_Client.OrderServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Restaurant_Management_Client
{
    public partial class myOrders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AccountServiceClient client = new AccountServiceClient();
            client.Open();
            string value = Request.Cookies["token"].Value;
            try
            {
                UserDto userDto = client.GetUserByToken(value);
                OrderServiceClient client1 = new OrderServiceClient();
                List<OrderDto> orders = client1.GetOrders(userDto.Id).ToList();
                if (orders.Count!=0)
                {
                    orderRepeater.DataSource = orders;
                    orderRepeater.DataBind();
                }
                else
                    OrderErr.Visible = true;
            }
            catch (Exception)
            {
                Response.Cookies["token"].Expires = DateTime.Now.AddDays(-1);
                Response.Redirect("/login.aspx");
            }
            client.Close();
        }
    }
}