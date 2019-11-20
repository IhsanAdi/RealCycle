<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FinalQuiz.pages.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div runat="server" id="guestContent">
        <div class="landing">
            <div class="container">
                <div class="col-6">
                </div>
            </div>
        </div>
        <div class="container">
        <div class="about">
            <div class="container">
                <h2>Top Products</h2>
                <asp:Repeater id="topCatalog" runat="server">
                   <ItemTemplate>
                        <div class="col-4">
                            <div class="box-products">
                                <img src="<%# "../upload/"+ Convert.ToString(Eval("Picture")) %>" class="img-responsive"/>
                                <div class="info">
                                    <h4><%# Eval("ProductName") %></h4>
                                    <p>Rp.<%# Eval("Price") %></p>
                                </div>
                            </div>
                        </div>
                   </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
            </div>
    </div>

    <div runat="server" id="memberContent">
        <div class="landing">
            <div class="container">
                <div class="col-6">
                </div>
            </div>
        </div>
        <div class="container">
        <div class="about">
            <div class="container">
                <h2>Top Products</h2>
                <asp:Repeater id="topCatalogMember" runat="server">
                   <ItemTemplate>
                        <div class="col-4">
                            <div class="box-products">
                                <img src="<%# "../upload/"+ Convert.ToString(Eval("Picture")) %>" class="img-responsive"/>
                                <div class="info">
                                    <h4><%# Eval("ProductName") %></h4>
                                    <p>Rp.<%# Eval("Price") %></p>
                                </div>
                            </div>
                        </div>
                   </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
            </div>
    </div>

    <div runat="server" id="adminContent">
        <div class="landing">
            <div class="container">
                <div class="col-6">
                </div>
            </div>
        </div>
        <div class="container">
        <div class="about">
            <div class="container">
                <h2>Top Products</h2>
                <asp:Repeater id="topCatalogAdmin" runat="server">
                   <ItemTemplate>
                        <div class="col-4">
                            <div class="box-products">
                                <img src="<%# "../upload/"+ Convert.ToString(Eval("Picture")) %>" class="img-responsive"/>
                                <div class="info">
                                    <h4><%# Eval("ProductName") %></h4>
                                    <p>Rp.<%# Eval("Price") %></p>
                                </div>
                            </div>
                        </div>
                   </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
            </div>
    </div>
</asp:Content>
