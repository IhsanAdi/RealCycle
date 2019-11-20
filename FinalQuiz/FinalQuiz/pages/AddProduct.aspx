<%@ Page Title="" Language="C#" MasterPageFile="~/pages/Site.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="FinalQuiz.pages.AddProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="box-auth">
            <div class="col-6" style="padding:5px;">
        <div>
            <asp:Label ID="productNameLbl" CssClass="label_login" runat="server" Text="Product Name"></asp:Label>
            <asp:TextBox ID="productNameTextBox" CssClass="form_login" runat="server"></asp:TextBox>
            <asp:Label ID="erorName" Visible="false" runat="server" Text="Cannot be Empty" style="color:red ; font-style:italic"></asp:Label>

        </div>
            
        <div>
            <asp:Label ID="categoryLbl" CssClass="label_login" runat="server" Text="Category"></asp:Label>
            <asp:TextBox ID="categoryTextBox" CssClass="form_login" runat="server"></asp:TextBox>
            <asp:Label ID="errorCategoryLbl" Visible="false" runat="server" Text="Cannot be Empty or Must be filled with Bike, Clothing, or Accessories" style="color:red ; font-style:italic"></asp:Label>
        </div>

        <div>
            <asp:Label ID="priceLbl" CssClass="label_login" runat="server" Text="Price"></asp:Label>
            <asp:TextBox ID="priceTextBox" CssClass="form_login" runat="server"></asp:TextBox>
            <asp:Label ID="errorPriceLbl" Visible="false" runat="server" Text="Cannot be Empty or Must be filled with numbers and greater than 0" style="color:red ; font-style:italic"></asp:Label>
        </div>

        

                </div>

            <div class="col-6" style="padding:5px;">
                <div>
            <asp:Label ID="stockLbl" CssClass="label_login" runat="server" Text="Stock"></asp:Label>
            <asp:TextBox ID="stockTextBox" CssClass="form_login" runat="server"></asp:TextBox>
            <asp:Label ID="errorStockLbl" Visible="false" runat="server" Text="Cannot be Empty or Must be filled with numbers and greater than 0" style="color:red ; font-style:italic"></asp:Label>
        </div>
        <div>
            <asp:Label ID="pictureLbl" CssClass="label_login" runat="server" Text="Picture"></asp:Label>
            <asp:FileUpload CssClass="form_login" ID="imageFileUpload" runat="server" />
            <asp:RegularExpressionValidator ID="regexValidator" runat="server"
                 ControlToValidate="imageFileUpload"
                 ErrorMessage="Only .JPG & .PNG images are allowed" 
                 ValidationExpression="(.*\.([Jj][Pp][Gg])|.*\.([Pp][Nn][Gg])$)">
            </asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator ControlToValidate="imageFileUpload" ID="imageRequiredFieldValidator" runat="server" ErrorMessage="Image can't be empty" style="color:red ; font-style:italic"></asp:RequiredFieldValidator>
        </div>

        <div>
            <asp:Label ID="DescriptionLbl" CssClass="label_login" runat="server" Text="Description"></asp:Label>
            <asp:TextBox ID="descriptionTextBox" CssClass="form_login" runat="server"></asp:TextBox>
            <asp:Label ID="errorDescriptionLbl" Visible="false" runat="server" Text="Cannot be Empty or Must be filled with 7 words description." style="color:red ; font-style:italic"></asp:Label>
        </div>

        </div>

        <div class="col-12">
            <asp:Button ID="addProductBtn" CssClass="login_button" runat="server" Text="Add Product" OnClick="addProductBtn_Click" />
         </div>

        <div class="col-12" style="padding:10px; text-align:center;">
            <asp:hyperlink ID="ProductList" NavigateUrl="~/pages/Products.aspx" runat="server">Back to Product List</asp:hyperlink>
        </div>
        </div>
    </div>
</asp:Content>
