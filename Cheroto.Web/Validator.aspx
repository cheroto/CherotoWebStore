<%@ Page Title="" Language="C#" MasterPageFile="~/MyMasterPage.Master" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="Cheroto.Web.Validator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <div>
        Please insert your R.G. 
        <asp:TextBox runat="server" ID="txtRG"></asp:TextBox>
        <asp:Button runat="server" ID="btnValidate" Text="Validate R.G." OnClick="btnValidate_Click"/>
        <asp:Literal runat ="server" ID="ltrIsValid"></asp:Literal>
    </div>

</asp:Content>
