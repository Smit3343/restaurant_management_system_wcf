<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddItem.aspx.cs" MasterPageFile="~/masters/admin.Master" Inherits="Restaurant_Management_Client.admin.AddItem" %>

<asp:Content runat="server" ContentPlaceHolderID="titleSection">Add Item</asp:Content>
<asp:Content ContentPlaceHolderID="contantSection" runat="server">
    <div class="heading_container heading_center">
        <h2>Add Item
        </h2>
    </div>
    <div class="card">
        <asp:Panel runat="server" CssClass="alert alert-danger" ID="errPanel" Visible="false">
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </asp:Panel>
        <div class="card-body">

            <div>
                <div class="form-group">
                    <lanel>Name</lanel>
                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" SetFocusOnError="true" Display="Dynamic" ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Name required"></asp:RequiredFieldValidator>
                    
                </div>
                <div class="form-group">

                    <label>Price</label>
                    <asp:TextBox CssClass="form-control" TextMode="Number" ID="TextBox3" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" SetFocusOnError="true" Display="Dynamic" ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="Price required"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator SetFocusOnError="true" ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox3" Display="Dynamic" ErrorMessage="Price should be greater than 0" ForeColor="Red" ValidationExpression="^[1-9]\d*$"></asp:RegularExpressionValidator>
                    
                </div>
                <div class="form-group">

                    <label>Description</label>
                    <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" SetFocusOnError="true" Display="Dynamic" ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox4" ErrorMessage="Description required"></asp:RequiredFieldValidator>

                </div>
                <div class="form-group">

                    <label>Category</label>
                    <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ForeColor="Red" SetFocusOnError="true" Display="Dynamic" ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox5" ErrorMessage="Category required"></asp:RequiredFieldValidator>

                </div>
                <div class="form-group">

                    <label>Photo</label>
                    <asp:FileUpload CssClass="form-control" ID="FileUpload1" runat="server" />
                    <asp:RequiredFieldValidator ForeColor="Red" SetFocusOnError="true" Display="Dynamic" ID="RequiredFieldValidator5" runat="server" ControlToValidate="FileUpload1" ErrorMessage="Please Upload File"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator
                            runat="server"
                            ValidationExpression="([a-zA-Z\\].*(.jpg|.png|.jpeg)$)"
                            ErrorMessage="only this image format allowed:jpg,jpeg,png"
                            ControlToValidate="FileUpload1"
                            ForeColor="Red"
                            Display="Dynamic"></asp:RegularExpressionValidator>
                </div>
                <br />
                <asp:Button ID="Button2" CssClass="btn btn-primary" runat="server" OnClick="Button2_Click" Text="Add" />
                <div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
