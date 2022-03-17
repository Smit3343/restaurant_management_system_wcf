<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/masters/main.Master" CodeBehind="ItemDetails.aspx.cs" Inherits="Restaurant_Management_Client.ItemDetails" %>
<asp:Content runat="server" ContentPlaceHolderID="titleSection">Item Details</asp:Content>
<asp:Content ContentPlaceHolderID="contantSection" runat="server">

    <div class="container itemDetail">
        <div class="row">

            <div class="col-md-6">
                <asp:Image ID="itemImg" runat="server" />
            </div>
            <div class="col-md-6">
                <label>Name:</label>
                <asp:Label ID="NameField" runat="server"></asp:Label>
                <br />
                <label>Price:</label>
                ₹<asp:Label ID="PriceField" runat="server"></asp:Label>
                <br />
                <label>Decrption:</label>
                <asp:Label ID="DescrField" runat="server"></asp:Label>
                <br />
                <label>Category:</label>
                <asp:Label ID="CateField" runat="server"></asp:Label>
                <br />
                <br />
                <div class="form-group">
                    <label>Quantity </label>

                    &nbsp;<asp:TextBox ID="TextBox1" Width="81px" CssClass="form-control" runat="server" TextMode="Number"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" ControlToValidate="TextBox1" SetFocusOnError="true" Display="Dynamic" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please Provide Quantity"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator SetFocusOnError="true" ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="Quantity should be greater than 0" ForeColor="Red" ValidationExpression="^[1-9]\d*$"></asp:RegularExpressionValidator>
                    <br />
                </div>
                <br />
                <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" OnClick="Button1_Click" Text="Order" />
                <br />
                <br />
                <asp:Panel Visible="false" runat="server" CssClass="alert alert-success" ID="orderPlaced">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                    <a href="myOrders.aspx">Check Orders Now!</a>
                </asp:Panel>
            </div>
        </div>
    </div>
</asp:Content>
