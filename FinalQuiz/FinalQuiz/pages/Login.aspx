<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FinalQuiz.pages.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="box-auth">
            <div>
                <asp:Label CssClass="label_login" ID="emailLbl" runat="server" Text="E-mail"></asp:Label>
                <asp:TextBox CssClass="form_login" ID="emailTextBox" runat="server"></asp:TextBox>
                <asp:Label ID="errorEmailLbl" Visible="false" runat="server" Text="Email can't be empty" style="color:red ; font-style:italic"></asp:Label>
           
            </div>

            <div>
                <asp:Label CssClass="label_login" ID="passwordLbl" runat="server" Text="Password"></asp:Label>
                <asp:TextBox CssClass="form_login" ID="passwordTextBox" runat="server" TextMode="Password"></asp:TextBox>
                <asp:Label ID="errorPasswordLbl" Visible="false" runat="server" Text="Password can't be empty" style="color:red ; font-style:italic"></asp:Label>
            
            </div>
        
            <div class="checkboxStyle">
                <asp:CheckBox ID="rememberCheckBox" runat="server" Text="Remember Me"/>
            </div>

            <div>
                <asp:Button CssClass="login_button" ID="loginBtn" runat="server" Text="Sign In" OnClick="loginBtn_Click" />
            </div>

            <div>
                <asp:Label ID="errorLoginLbl" Visible="false" runat="server" Text="Invalid Email or Password" style="color:red ; font-style:italic"></asp:Label>
                <asp:Label ID="errorLoginLbl2" Visible="false" runat="server" Text="User doesn't exists" style="color:red ; font-style:italic"></asp:Label>
            </div>
        </div>
</asp:Content>
