<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Cheroto.Web.Default" %>

<%@ Register Src="~/WebControls/Menu.ascx" TagPrefix="uc1" TagName="Menu" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <uc1:Menu runat="server" id="Menu" />
        <div>
            Hello World!

            <asp:TextBox runat="server" ID="txtNumber"></asp:TextBox>
            <asp:Button runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" Text ="Do not click!"/>
            <asp:Literal runat ="server" ID="ltrHelloWorld"></asp:Literal>

        </div>
    </form>
</body>
</html>
