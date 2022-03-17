<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="updateUser.aspx.cs" MasterPageFile="~/masters/admin.Master" Inherits="Restaurant_Management_Client.admin.updateUser" %>

<asp:Content runat="server" ContentPlaceHolderID="titleSection">Update User</asp:Content>
<asp:Content ContentPlaceHolderID="contantSection" runat="server">
    <div class="heading_container heading_center">
        <h2>Update User
        </h2>
    </div>
    <div class="card">
        <asp:Panel runat="server" CssClass="alert alert-danger" ID="errPanel" Visible="false">
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </asp:Panel>
        <div class="card-body">

            <div>
                <div class="form-group">
                    <label>Id:</label>
                    <asp:Label ID="Label4" runat="server"></asp:Label>
                </div>
                <div class="form-group">
                    <lanel>Name</lanel>
                    <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" SetFocusOnError="true" Display="Dynamic" ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="Name required"></asp:RequiredFieldValidator>

                </div>
                <div class="form-group">
                    <label>Email:</label>
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </div>
                <div class="form-group">

                    <label>Role</label>
                    <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" SetFocusOnError="true" Display="Dynamic" ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="Role required"></asp:RequiredFieldValidator>
                    <br />
                </div>
                <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" OnClick="Button1_Click" Text="update" />
            </div>
        </div>
    </div>
</asp:Content>
