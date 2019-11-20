<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Site.Master" AutoEventWireup="true" CodeBehind="Transaction.aspx.cs" Inherits="FinalQuiz.Transaction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <asp:GridView ID="cartGridView" runat="server" Width="100%" AutoGenerateColumns="false" HeaderStyle-CssClass="header-grid" CssClass="data-grid">
            <Columns>
                <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
                <asp:TemplateField HeaderText="Picture">
                    <ItemTemplate>
                        <asp:Image ID="imageTemplate" runat="server" Height="50px" Width="50px" ImageUrl='<%# "~/upload/"+ Convert.ToString(Eval("Picture")) %>'/>
                    </ItemTemplate>      
                </asp:TemplateField>
                <asp:BoundField DataField="TransactionDate" HeaderText="Transaction Date" />
                <asp:BoundField DataField="ProductPrice" HeaderText="Member Name" />
                <asp:BoundField DataField="GrandTotal" HeaderText="Transaction Status"/>
                <asp:BoundField DataField="GrandTotal" HeaderText="Product Name"/>
                <asp:BoundField DataField="GrandTotal" HeaderText="Quantity Status"/>
                        <asp:BoundField DataField="GrandTotal" HeaderText="Product Price"/>
                            <asp:BoundField DataField="GrandTotal" HeaderText="Subtotal"/>
                                <asp:BoundField DataField="GrandTotal" HeaderText="Grand Total Status"/>
                                    <asp:BoundField DataField="GrandTotal" HeaderText="Transaction Status"/>
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>
