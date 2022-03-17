<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/masters/main.Master" CodeBehind="login.aspx.cs" Inherits="Restaurant_Management_Client.login" %>
<asp:Content runat="server" ContentPlaceHolderID="titleSection">Sign In</asp:Content>
<asp:Content ContentPlaceHolderID="contantSection" runat="server">
    <div class="heading_container heading_center">
        <h2>
          Sign In
        </h2>
      </div>
    <div class="card">
        <asp:Panel runat="server" CssClass="alert alert-danger" ID="errPanel" Visible="false">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </asp:Panel>
        <div class="card-body">

            <div>
                <div class="form-group">
                    <label>Email</label>
                    <asp:TextBox CssClass="form-control" ID="EmailField" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ForeColor="Red" SetFocusOnError="true" Display="Dynamic" ID="RegularExpressionValidator1" runat="server" ControlToValidate="EmailField" ErrorMessage="Enter valid email id" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ForeColor="Red" SetFocusOnError="true" Display="Dynamic" ID="RequiredFieldValidator2" runat="server" ControlToValidate="EmailField" ErrorMessage="Email id required"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <label>Password</label>
                    <asp:TextBox CssClass="form-control" ID="PasswordField" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" SetFocusOnError="true" Display="Dynamic" ID="RequiredFieldValidator1" runat="server" ControlToValidate="PasswordField" ErrorMessage="Password required"></asp:RequiredFieldValidator>
                </div>
                <br />
                <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" OnClick="Button1_Click" Text="Sign In" />
                <br />
                <br />
                <asp:HyperLink NavigateUrl="/register.aspx" runat="server">New User?</asp:HyperLink>

            </div>
        </div>
    </div>
</asp:Content>