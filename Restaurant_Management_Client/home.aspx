<%@ Page Language="C#" AutoEventWireup="true" MaintainScrollPositionOnPostBack="true" MasterPageFile="~/masters/main.Master" CodeBehind="home.aspx.cs" Inherits="Restaurant_Management_Client.home" %>
<asp:Content runat="server" ContentPlaceHolderID="titleSection">Home</asp:Content>
<asp:Content ContentPlaceHolderID="contantSection" runat="server">
    <!-- banner section -->
    <section id="banner">
      <div class="container">
        <div class="row">
          <div class="col-md-6">
            <p class="promo-title">Add a joy of best taste</p>
            <p>The only thing we love more than food is you!</p>
            <a class="orderNowBtn" href="/Items.aspx">Order Now</a>
          </div>
          <div class="col-md-6 text-center">
            <img src="static/images/burger_slide.png" class="img-fluid">
          </div>
        </div>
      </div>
      <img src="static/images/wave1.png" class="botom-img">
    </section>
        
        <br />
        <br />
        <br />
        <br />
       <section class="food_section layout_padding-bottom">
    <div class="container">
      <div class="heading_container heading_center">
        <h2>
          Our Menu
        </h2>
      </div>
      <ul class="filters_menu">
        <li ><asp:LinkButton OnCommand="all_Command" CommandArgument="All" CssClass="active" Text="All"  runat="server"/></li>
        <li><asp:LinkButton OnCommand="all_Command" CommandArgument="Pizza" Text="Pizza"  runat="server"/></li>
        <li><asp:LinkButton OnCommand="all_Command" CommandArgument="Burger" Text="Burger"  runat="server"/></li>
        <li><asp:LinkButton OnCommand="all_Command" CommandArgument="Pasta" Text="Pasta"  runat="server"/></li>
        <li><asp:LinkButton OnCommand="all_Command" CommandArgument="Fries" Text="Fries"  runat="server"/></li>
      </ul>
      <div class="filters-content">
          
        <div class="row grid">
            <asp:Repeater ID="itemRepeater" runat="server">
            <ItemTemplate>
          <div class="col-sm-6 col-lg-4">
            <div class="box">

                <div class="img-box">
                  <asp:Image id="itemImg" ImageUrl='<%#GetImage(Eval("ImagePath"))%>' runat="server" />
                </div>
                <div class="detail-box">
                  <h5>
                    <asp:Label Text='<%#Eval("Name") %>' runat="server"></asp:Label>
                  </h5>
                  <p>
                    <asp:Label Text='<%#Eval("Description") %>' runat="server"></asp:Label>
                  </p>
                  <div class="options">
                    <h6>
                       ₹<asp:Label Text='<%#Eval("Price") %>' runat="server"></asp:Label>

                    </h6>
                    <a href='/itemDetails.aspx?id=<%#Eval("Id") %>' ><i class='fa-solid fa-cart-shopping'></i></a>
                  </div>
                </div>
            </div>
          </div>
                </ItemTemplate>
          </asp:Repeater>
        </div>
            
      </div>

        <div class="btn-box">
            <a href="/Items.aspx">
              View More
            </a>
          </div>
    </div>
  </section> 
</asp:Content>
