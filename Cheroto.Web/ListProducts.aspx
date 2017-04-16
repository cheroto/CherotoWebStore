<%@ Page Title="" Language="C#" MasterPageFile="~/MyMasterPage.Master" AutoEventWireup="true" CodeBehind="ListProducts.aspx.cs" Inherits="Cheroto.Web.ListProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <asp:DataGrid runat="server" ID="dgdProducts" ></asp:DataGrid>
</asp:Content>
