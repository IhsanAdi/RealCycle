<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="FinalQuiz.pages.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField runat="server" ID="ProductID" />
    <div>
        <asp:gridview ID="detailGridView" runat="server" Width="100%" AutoGenerateColumns="false" HeaderStyle-CssClass="header-grid" CssClass="data-grid" >
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
            </Columns>
        </asp:gridview>
    </div>

    <div>
        <asp:TextBox ID="amount" runat="server" Visible="false" placeholder="Product Amount"></asp:TextBox>
    </div>

    <div>
        <asp:HyperLink runat="server" href='<%# "UpdateProduct.aspx?id=" + Eval("id") %>' style="text-decoration: none;">
            <asp:Button ID="updateBtn" runat="server" Text="Update" CausesValidation="false" UseSubmitBehavior="false" UserID='<%#Eval("Id") %>' Visible="false" />
        </asp:HyperLink>
    </div>

    <div>
        <asp:Button ID="cart" runat="server" Text="Add to Cart" OnClick="cart_Click" Visible ="false" />
    </div>

    <div>
        <asp:Label ID="errorLbl" runat="server" Text="" Visible="false"></asp:Label>
    </div>

</asp:Content>
