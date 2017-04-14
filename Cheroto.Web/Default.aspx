<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Cheroto.Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Hello World!

            <asp:TextBox runat="server" ID="txtNumber"></asp:TextBox>
            <asp:Button runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" Text ="Do not click!"/>
            <asp:Literal runat ="server" ID="ltrHelloWorld"></asp:Literal>

        </div>
    </form>
</body>
</html>
