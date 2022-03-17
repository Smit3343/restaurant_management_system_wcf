<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" MasterPageFile="~/masters/admin.Master" Inherits="Restaurant_Management_Client.admin.Orders" %>


<asp:Content runat="server" ContentPlaceHolderID="titleSection">Orders</asp:Content>
<asp:Content ContentPlaceHolderID="contantSection" runat="server">
    <div class="container" id="dashboard">
        <asp:Panel runat="server" CssClass="alert alert-danger" ID="errPanel" Visible="false">
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </asp:Panel>
        <label>    Number Of Orders:</label><asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
    <table class="table">
        <asp:Repeater ID="orderRepeater" runat="server">
            <HeaderTemplate>
                <thead>
                    <tr>
                        <th scope="col">Order Id</th>
                        <th scope="col">User Id</th>
                        <th scope="col">Item Id</th>
                        <th scope="col">Item Name</th>
                        <th scope="col">Item Price</th>
                        <th scope="col">Item Quantity</th>
                        <th scope="col">Total</th>
                        <th scope="col">Status</th>
                        <th scope="col">Orderdate</th>
                        <th scope="col">Action</th>
                    </tr>
                </thead>
            </HeaderTemplate>
            <ItemTemplate>

                <tr>
                    <th><%#Eval("Id") %></th>
                    <th><%#Eval("UserId") %></th>
                    <th><%#Eval("ItemId") %></th>
                    <td><%#Eval("ItemName") %></td>
                    <td>₹<%#Eval("ItemPrice") %></td>
                    <td><%#Eval("ItemQuantity") %></td>
                    <td>₹<%#Eval("Total") %></td>
                    <td><%#Eval("Status") %></td>
                    <td><%#Eval("Orderdate") %></td>
                    <td>
                        <asp:Button runat="server" OnCommand="OrderUpdate_Command" CommandArgument='<%#Eval("Id") %>' Text="update" CssClass="btn btn-primary" />
                        <asp:Button runat="server" OnCommand="OrderDelete_Command" CommandArgument='<%#Eval("Id") %>' Text="delete" CssClass="btn btn-danger" />
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
    </div>
</asp:Content>