<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Site.Master" AutoEventWireup="true" CodeBehind="Members.aspx.cs" Inherits="FinalQuiz.pages.Members" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="container">
        <div class="col-12">
            <h2 class="heading" style="padding-top:15px;">Manage Member</h2>
        </div>
        <div class="col-12" style="padding-bottom:10px;">
            <asp:TextBox ID="emailTextBox" CssClass="form-custom" placeholder="Email" runat="server"></asp:TextBox>
            <asp:Button ID="adminBtn" CssClass="form-green" runat="server" Text="Set as Admin" OnClick="adminBtn_Click" />
            <asp:Button ID="deleteBtn" CssClass="form-red" runat="server" Text="Delete Member" OnClick="deleteBtn_Click" />
        </div>
        <div>
            <asp:GridView CssClass="data-grid" HeaderStyle-CssClass="header-grid" AutoGenerateColumns="false" ID="userGridView" runat="server">
                <Columns>
                     <asp:BoundField DataField="Name" HeaderText="User Name" />
                     <asp:BoundField DataField="Email" HeaderText="Email" />
                     <asp:BoundField DataField="PhoneNumber" HeaderText="Phone Number" />
                 </Columns>
            </asp:GridView>
        </div>

        
    </div>
</asp:Content>
