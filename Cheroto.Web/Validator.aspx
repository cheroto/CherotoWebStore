<%@ Page Title="" Language="C#" MasterPageFile="~/MyMasterPage.Master" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="Cheroto.Web.Validator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">

    <div>
        <p>Please insert your R.G. </p>
        <asp:TextBox runat="server" ID="txtRG"></asp:TextBox>
        <asp:Button runat="server" ID="btnValidateRG" Text="Validate R.G." OnClick="btnValidateRG_Click"/>
        <br />
        <asp:Literal runat ="server" ID="ltrIsValidRG"></asp:Literal>

        <br/>

        <p>Please insert your CPF</p>
        <asp:TextBox runat="server" ID="txtCPF"></asp:TextBox>
        <asp:Button runat="server"  ID="btnValidateCPF" Text="Validate CPF." OnClick="btnValidateCPF_Click" />
        <br/>
        <asp:Literal runat="server" ID="ltrIsValidCPF"></asp:Literal>
    </div>

</asp:Content>
