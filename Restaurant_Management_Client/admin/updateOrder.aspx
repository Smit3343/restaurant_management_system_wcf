<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="updateOrder.aspx.cs" MasterPageFile="~/masters/admin.Master" Inherits="Restaurant_Management_Client.admin.updateOrder" %>

<asp:Content runat="server" ContentPlaceHolderID="titleSection">Update Order</asp:Content>
<asp:Content ContentPlaceHolderID="contantSection" runat="server">
    <div class="heading_container heading_center">
        <h2>Update Order
        </h2>
    </div>
    <div class="card">
        <asp:Panel runat="server" CssClass="alert alert-danger" ID="errPanel" Visible="false">
            <asp:Label ID="Label8" runat="server"></asp:Label>
        </asp:Panel>
        <div class="card-body">

            <div>
                <div class="form-group">
                    <label>Id:</label>
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </div>
                <div class="form-group">

                    <label>UserId:</label>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </div>
                <div class="form-group">

                    <label>Item Id:</label>
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </div>
                <div class="form-group">

                    <label>Item Name:</label>
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                </div>
                <div class="form-group">

                    <label>Item Price:</label>
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                </div>
                <div class="form-group">

                    <label>Item Quantity:</label>
                    <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" TextMode="Number"></asp:TextBox>
<asp:RequiredFieldValidator ForeColor="Red" ControlToValidate="TextBox1" SetFocusOnError="true" Display="Dynamic" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Provide Quantity"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator SetFocusOnError="true" ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="Quantity should be greater than 0" ForeColor="Red" ValidationExpression="^[1-9]\d*$"></asp:RegularExpressionValidator>

                </div>
                <div class="form-group">

                    <label>Total:</label>
                    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
                </div>
                <div class="form-group">

                    <label>Status:</label>
                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ForeColor="Red" ControlToValidate="TextBox2" SetFocusOnError="true" Display="Dynamic" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Status Required"></asp:RequiredFieldValidator>

                </div>
                <div class="form-group">

                    <label>Order date:</label>
                    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                </div>
                <br />
                <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" OnClick="Button1_Click" Text="update" />
            </div>
        </div>
    </div>
</asp:Content>
