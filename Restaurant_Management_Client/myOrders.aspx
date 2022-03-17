<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/masters/main.Master" CodeBehind="myOrders.aspx.cs" Inherits="Restaurant_Management_Client.myOrders" %>

<asp:Content runat="server" ContentPlaceHolderID="titleSection">Orders</asp:Content>
<asp:Content ContentPlaceHolderID="contantSection" runat="server">
    <section id="orders">
      <div class="container">
          <div class="heading_container heading_center">
        <h2>
          Orders
        </h2>
      </div>
          <asp:Label ID="OrderErr" Text="No orders yet placed" runat="server" Visible="false"></asp:Label>

          <table class="table">
          <asp:Repeater ID="orderRepeater" runat="server">
            <HeaderTemplate>
  <thead>
    <tr>
      <th scope="col">Order Id</th>
      <th scope="col">Item Name</th>
      <th scope="col">Item Price</th>
      <th scope="col">Item Quantity</th>
      <th scope="col">Total</th>
      <th scope="col">Status</th>
      <th scope="col">Orderdate</th>
       
    </tr>
  </thead>
              </HeaderTemplate>
              <ItemTemplate>
      
    <tr>
      <th><%#Eval("Id") %></th>
      <td><%#Eval("ItemName") %></td>
      <td>₹<%#Eval("ItemPrice") %></td>
      <td><%#Eval("ItemQuantity") %></td>
        <td>₹<%#Eval("Total") %></td>
        <td><%#Eval("Status") %></td>
        <td><%#Eval("Orderdate") %></td>

    </tr>
      </ItemTemplate>
              </asp:Repeater>
</table>
          
          </div>
        </section>
    </asp:Content>
