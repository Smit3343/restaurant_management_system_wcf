<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/masters/main.Master" CodeBehind="register.aspx.cs" Inherits="Restaurant_Management_Client.Register" %>

<asp:Content runat="server" ContentPlaceHolderID="titleSection">Sign Up</asp:Content>
<asp:Content ContentPlaceHolderID="contantSection" runat="server">
    <div class="heading_container heading_center">
        <h2>
          Sign Up
        </h2>
      </div>
    <div class="card">
        <asp:Panel runat="server" ID="errPanel" Visible="false">
            <div class="alert alert-danger" role="alert">
                <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>

            </div>
        </asp:Panel>
        <div class="card-body">
            <div class="form-group">
                <label>Name</label>
                <asp:TextBox CssClass="form-control" ID="NameField" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ForeColor="Red" SetFocusOnError="true" Display="Dynamic" runat="server" ControlToValidate="NameField" ErrorMessage="Name required"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <label>Email</label>
                <asp:TextBox CssClass="form-control" ID="EmailField" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="Red" SetFocusOnError="true"  runat="server" ControlToValidate="EmailField" ErrorMessage="Email required" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:CustomValidator ID="EmailFieldErr" runat="server" ForeColor="Red" SetFocusOnError="true" Display="Dynamic" ControlToValidate="EmailField" ErrorMessage="Email already registred" OnServerValidate="emailErr1_ServerValidate" ></asp:CustomValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ForeColor="Red" SetFocusOnError="true" Display="Dynamic" runat="server" ControlToValidate="EmailField"  ErrorMessage="Email address is not valid"  ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </div>
            <div class="form-group">
                <label>Password</label>
                <asp:TextBox ID="PasswordField" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ForeColor="Red" SetFocusOnError="true" Display="Dynamic" runat="server" ControlToValidate="PasswordField" ErrorMessage="Password required"></asp:RequiredFieldValidator>
            </div>
            <br />
            <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" OnClick="Button1_Click" Text="Register" />
            <br />
            <asp:HyperLink NavigateUrl="/login.aspx" runat="server">Already Have an Account?</asp:HyperLink>

        </div>
    </div>
    </div>
</asp:Content>