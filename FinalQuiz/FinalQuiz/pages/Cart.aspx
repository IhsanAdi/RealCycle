<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Site.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="FinalQuiz.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col-4" style="padding-bottom:10px;">
            
                <asp:TextBox ID="productName" CssClass="form-custom" runat="server"></asp:TextBox>
                <asp:Button ID="deleteBtn" CssClass="form-red" runat="server" Text="Delete Product" OnClick="deleteBtn_Click"/>
    </div>

    <div>
        <asp:GridView ID="cartGridView" runat="server" Width="100%" AutoGenerateColumns="false" HeaderStyle-CssClass="header-grid" CssClass="data-grid">
            <Columns>
                <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
                <asp:TemplateField HeaderText="Picture">
                    <ItemTemplate>
                        <asp:Image ID="imageTemplate" runat="server" Height="50px" Width="50px" ImageUrl='<%# "~/upload/"+ Convert.ToString(Eval("Picture")) %>'/>
                    </ItemTemplate>      
                </asp:TemplateField>
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                <asp:BoundField DataField="ProductPrice" HeaderText="Product Price" />
                <asp:TemplateField HeaderText="Delete">
                    <ItemTemplate>
                        <asp:Button ID="DeleteCartBtn" runat="server" Text="Delete" OnClick="DeleteCartBtn_Click" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
     </div>
        <asp:Label ID="CartLbl" runat="server" Text=""></asp:Label>
        <asp:Label ID="GrandTotalLbl" runat="server" Text=""></asp:Label>
    <asp:Button ID="CheckOutBtn" runat="server" Text="Checkout" OnClick="CheckoutBtn_Click" />
</asp:Content>
