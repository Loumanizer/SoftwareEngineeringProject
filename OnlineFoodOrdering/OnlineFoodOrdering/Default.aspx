<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="OnlineFoodOrdering._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br /> 
    <h1>Chef: John Doe </h1>
    <div class="row">
        <h3>Order Lists</h3>
       <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" DoubleClick="ListBox1_SelectedIndexChanged">
            <asp:ListItem>Classic Quarter Chicken Dinner</asp:ListItem>
            <asp:ListItem>Half Chicken Dinner</asp:ListItem>
            <asp:ListItem>Double Leg Dinner</asp:ListItem>
            <asp:ListItem>Quarter Chicken & Shrimp Dinner</asp:ListItem>
        </asp:ListBox>
         &nbsp;&nbsp;&nbsp;
         <h3>Prepared Lists</h3>
        <asp:ListBox ID="ListBox2" runat="server" AutoPostBack="True" DoubleClick="ListBox2_SelectedIndexChanged">
            <asp:ListItem>GOURMET CHEESEBURGER</asp:ListItem>
            <%--<asp:ListItem>CRISPY CHICKEN</asp:ListItem> 
            <asp:ListItem>HAWAIIAN Beef</asp:ListItem>--%>
        </asp:ListBox>
    </div>

<%--    <div class="row">
        <h1>Chef: John Doe </h1>
        <div id="OrderLists" class="col-md-4">            
            <h2>Order Lists</h2>
            <ul id="parent-list"> 
                <li></li>
                <li></li>
                <li></li>
                <li></li>
                <li>BBQ CHICKEN</li>
            </ul>
            
        </div>
         <asp:ListBox ID="ListBox1" runat="server">
                            <asp:ListItem Text="Red" Value="red"></asp:ListItem>
                            <asp:ListItem Text="Blue" Value="blue"></asp:ListItem>
                            <asp:ListItem Text="Green" Value="green"></asp:ListItem>
                        </asp:ListBox>
        <div class="row">
            <div id="OrderReady" class="col-md-4">
                <h2>Ready to deliver orders</h2>
                <ul>
                    <li>Classic Quarter Chicken Dinner</li>              
                </ul>
            
            </div>
        </div>
    </div>--%>

</asp:Content>
