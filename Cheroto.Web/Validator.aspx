<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="Cheroto.Web.Validator" %>

<%@ Register Src="~/WebControls/Menu.ascx" TagPrefix="uc1" TagName="Menu" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <uc1:Menu runat="server" ID="Menu" />
        <div>
            Please insert your R.G. 
            <asp:TextBox runat="server" ID="txtRG"></asp:TextBox>
            <asp:Button runat="server" ID="btnValidate" Text="Validate R.G." OnClick="btnValidate_Click"/>
            <asp:Literal runat ="server" ID="ltrIsValid"></asp:Literal>
        </div>
    </form>
</body>
</html>
