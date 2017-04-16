<%@ Page Title="" Language="C#" MasterPageFile="~/MyMasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Cheroto.Web.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <div>
        Hello World!

        <asp:TextBox runat="server" ID="txtNumber"></asp:TextBox>
        <asp:Button runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" Text ="Do not click!"/>
        <asp:Literal runat ="server" ID="ltrHelloWorld"></asp:Literal>

    </div>

</asp:Content>

