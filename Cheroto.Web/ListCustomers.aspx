﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MyMasterPage.Master" AutoEventWireup="true" CodeBehind="ListCustomers.aspx.cs" Inherits="Cheroto.Web.ListCustomers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderHead" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBody" runat="server">
    <asp:DataGrid runat="server" EditItemStyle-BackColor="GreenYellow" ID="dgdCustomers"></asp:DataGrid>
</asp:Content>
