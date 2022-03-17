<%@ Page Language="C#" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" MasterPageFile="~/masters/admin.Master" CodeBehind="dashboard.aspx.cs" Inherits="Restaurant_Management_Client.admin.dashboard" %>

<asp:Content runat="server" ContentPlaceHolderID="titleSection">Admin Dashboard</asp:Content>
<asp:Content runat="server" ContentPlaceHolderID="contantSection">
    <div class="container" id="dashboard">
        <asp:Panel runat="server" CssClass="alert alert-danger" ID="errPanel" Visible="false">
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </asp:Panel>
       <label> Number Of Users:</label><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    <table class="table">
        <thead>
            <tr>
                <th scope="col">Id</th>
                <th scope="col">Email</th>
                <th scope="col">Name</th>
                <th scope="col">Role</th>
                <th scope="col">Action</th>
            </tr>
        </thead>
        <tbody>
            <asp:Repeater ID="userTable" runat="server">
                <ItemTemplate>
                    <tr>
                        <th><%#Eval("Id") %></th>
                        <td><%#Eval("Email") %></td>
                        <td><%#Eval("Name") %></td>

                        <td><%#Eval("Role") %></td>
                        <td>
                            <asp:Button runat="server" OnCommand="userUpdate_Command" CommandArgument='<%#Eval("Id") %>' Text="update" CssClass="btn btn-primary" />
                            <asp:Button runat="server" OnCommand="userDelete_Command" CommandArgument='<%#Eval("Id") %>' Text="delete" CssClass="btn btn-danger" />
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    
    </div>

</asp:Content>
