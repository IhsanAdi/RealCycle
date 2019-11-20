<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Site.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="FinalQuiz.pages.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Label">Old Password</asp:Label>
    <asp:TextBox ID="oldPass" TextMode="Password" runat="server"></asp:TextBox>

    <asp:Label ID="Label2" runat="server" Text="Label">New Password</asp:Label>
    <asp:TextBox ID="newPass" TextMode="Password" runat="server"></asp:TextBox>

    <asp:Label ID="Label3" runat="server" Text="Label">Confirm Password</asp:Label>
    <asp:TextBox ID="confPass" TextMode="Password" runat="server"></asp:TextBox>

    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
    <asp:Label ID="msgLabel" Visible="false" runat="server" Text=""></asp:Label>
</asp:Content>
