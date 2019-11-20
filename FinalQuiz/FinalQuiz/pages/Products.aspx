<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Site.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="FinalQuiz.pages.ViewProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="col-12" style="padding-top:15px;">
            <h2 class="heading">Products</h2>
        </div>
        <div class="col-1" style="padding-bottom:10px;">
            <asp:DropDownList CssClass="form-custom" ID="filterDropdown" runat="server" AutoPostBack="True" OnSelectedIndexChanged="filterDropdown_SelectedIndexChanged">
                <asp:ListItem Text="All" Selected="True" />
                <asp:ListItem Text="Bike" />
                <asp:ListItem Text="Clothing" />
                <asp:ListItem Text="Accessories" />
            </asp:DropDownList>
            </div>
        <div class="col-11" runat="server" id="adminContent">
            
            <div class="col-4" style="padding-bottom:10px;">
            
                <asp:TextBox ID="productName" CssClass="form-custom" placeholder="Name" runat="server"></asp:TextBox>
                <asp:Button ID="deleteBtn" CssClass="form-red" runat="server" Text="Delete Product" OnClick="deleteBtn_Click"/>
            </div>
            <div class="col-8" style="text-align:right; font-size:13px; text-decoration:none; color:#555;">
                <asp:Button ID="addBtn" CssClass="form-grey" runat="server" Text="Add Product" OnClick="addBtn_Click"/>
                <asp:Button ID="updateBtn" CssClass="form-grey" runat="server" Text="Update Product" OnClick="updateBtn_Click"/>
            </div>
        </div>
        <div class="col-12">
            
        </div>
        <div>
             <asp:GridView ID="productGridView" runat="server" Width="100%" AutoGenerateColumns="false" HeaderStyle-CssClass="header-grid" CssClass="data-grid">
                 <Columns>
                     <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
                     <asp:TemplateField HeaderText="Picture">
                         <ItemTemplate>
                             <asp:Image ID="imageTemplate" runat="server" Height="50px" Width="50px" ImageUrl='<%# "~/upload/"+ Convert.ToString(Eval("Picture")) %>' />
                         </ItemTemplate>
                     </asp:TemplateField>
                     <asp:BoundField DataField="Category" HeaderText="Category" />
                     <asp:BoundField DataField="Price" HeaderText="Price" />
                     <asp:BoundField DataField="Stock" HeaderText="Stock" />
                     <asp:TemplateField HeaderText="Details">
                         <ItemTemplate>
                             <asp:HyperLink ID="HyperLink1" NavigateUrl="~/pages/Register.aspx.cs" runat="server">See Details</asp:HyperLink>
                         </ItemTemplate>
                     </asp:TemplateField>
                 </Columns>
             </asp:GridView>
        </div>

    </div>
</asp:Content>
