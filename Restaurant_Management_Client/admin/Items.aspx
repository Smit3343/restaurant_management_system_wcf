<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/masters/admin.Master" CodeBehind="Items.aspx.cs" Inherits="Restaurant_Management_Client.admin.Items" %>

<asp:Content runat="server" ContentPlaceHolderID="titleSection">Items</asp:Content>
<asp:Content ContentPlaceHolderID="contantSection" runat="server">
    <div class="container" id="dashboard">

        <asp:Panel runat="server" CssClass="alert alert-danger" ID="errPanel" Visible="false">
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </asp:Panel>
        <label>Number Of Items:</label><asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/admin/AddItem.aspx">Add Item</asp:HyperLink>
        <br />
        <br />
        <table class="table">
            <thead>
                <tr>
                    <th scope="col">Id</th>
                    <th scope="col">Name</th>
                    <th scope="col">Price</th>
                    <th scope="col">Category</th>
                    <th scope="col">Description</th>
                    <th scope="col">Image</th>
                    <th scope="col">Action</th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="itemtable" runat="server">
                    <ItemTemplate>
                        <tr>
                            <th><%#Eval("Id") %></th>
                            <td><%#Eval("Name") %></td>
                            <td><%#Eval("Price") %></td>
                            <td><%#Eval("Category") %></td>
                            <td><%#Eval("Description") %></td>
                            <td>
                                <asp:Image ID="itemImg" Width="50px" Height="50px" ImageUrl='<%#GetImage(Eval("ImagePath"))%>' runat="server" /></td>
                            <td>
                                <asp:Button runat="server" OnCommand="update_Command" CommandArgument='<%#Eval("Id") %>' Text="update" CssClass="btn btn-primary" />
                                <asp:Button runat="server" OnCommand="delete_Command" CommandArgument='<%#Eval("Id") %>' Text="delete" CssClass="btn btn-danger" />
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>
</asp:Content>
