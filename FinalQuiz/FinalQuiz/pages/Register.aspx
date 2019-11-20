<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="FinalQuiz.pages.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="box-auth">
        <div class="col-6" style="padding:5px;">
            <div>
                <asp:Label ID="nameLbl" CssClass="label_login" runat="server" Text="Name"></asp:Label>
                <asp:TextBox CssClass="form_login" ID="nameTextBox" runat="server"></asp:TextBox>
                <asp:Label ID="erorName" Visible="false" runat="server" Text="Cannot be Empty" style="color:red ; font-style:italic"></asp:Label>
            </div>

        
            <div>
                <asp:Label ID="emailLbl" CssClass="label_login" runat="server" Text="Email"></asp:Label>
                <asp:TextBox CssClass="form_login" ID="emailTextBox" runat="server"></asp:TextBox>
                <asp:Label ID="errorEmailLbl" Visible="false" runat="server" Text="Cannot be Empty or Email has been registered" style="color:red ; font-style:italic"></asp:Label>
            </div>

        
         <div>
            <asp:Label ID="passwordLbl" CssClass="label_login" runat="server" Text="Password"></asp:Label>
            <asp:TextBox CssClass="form_login" ID="passwordTextBox" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Label ID="errorPasswordLbl" Visible="false" runat="server" Text="Cannot be Empty or Must be filled with alphanumeric" style="color:red ; font-style:italic"></asp:Label>
            <asp:Label ID="errorPasswordLbl2" Visible="false" runat="server" Text="Minimum 8 characters" style="color:red ; font-style:italic"></asp:Label>
        </div>

        <div>
            <asp:Label ID="confirmPasswordLbl" CssClass="label_login" runat="server" Text="Confirm Password"></asp:Label>
            <asp:TextBox CssClass="form_login" ID="confirmPasswordTextBox" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Label ID="errorConfirmPassword" Visible="false" runat="server" Text="Cannot be Empty or Password doesn't match" style="color:red ; font-style:italic"></asp:Label>
        </div>
</div>
         <div class="col-6" style="padding:5px;">
        <div>
            <asp:Label ID="genderLbl" CssClass="label_login" runat="server" Text="Gender"></asp:Label>
            <asp:RadioButtonList CssClass="label_login" ID="Gender" runat="server">
                <asp:ListItem Value="Male"> Male</asp:ListItem>
                <asp:ListItem Value="Female"> Female</asp:ListItem>
            </asp:RadioButtonList>
        </div>

        <div style="margin-top:25px;">
            <asp:Label ID="DOBLbl" CssClass="label_login" runat="server" Text="Date of Birth"></asp:Label>
            <asp:TextBox CssClass="form_login" ID="DOBTextBox" runat="server" TextMode="Date"></asp:TextBox>
            <asp:Label ID="errorDOBLbl" Visible="false" runat="server" Text="Cannot be Empty or Minimum age is 17 years old" style="color:red ; font-style:italic"></asp:Label>
        </div>

        <div>
            <asp:Label ID="phoneLbl" CssClass="label_login" runat="server" Text="Phone Number"></asp:Label>
            <asp:TextBox CssClass="form_login" ID="phoneTextBox" runat="server"></asp:TextBox>
            <asp:Label ID="errorPhoneLbl" Visible="false" runat="server" Text="Cannot be Empty or Must be filled with numeric characters" style="color:red ; font-style:italic"></asp:Label>
            <asp:Label ID="errorPhoneLbl2" Visible="false" runat="server" Text="Must be filled with 10 - 12 characters" style="color:red ; font-style:italic"></asp:Label>
        </div>

        <div>
            <asp:Label ID="addressLbl" CssClass="label_login" runat="server" Text="Address"></asp:Label>
            <asp:TextBox CssClass="form_login" ID="addressTextBox" runat="server"></asp:TextBox>
            <asp:Label ID="errorAddressLbl" Visible="false" runat="server" Text="Cannot be Empty or Must be ends with \'Street\'" style="color:red ; font-style:italic"></asp:Label>
        </div>

</div>

        <div class="col-12">
            <div>
                <asp:Button CssClass="login_button" ID="registerBtn" runat="server" Text="Sign Up" OnClick="registerBtn_Click" />
            </div>
        </div>

        </div>
</asp:Content>
