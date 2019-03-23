<%@ Page Title="My Account" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Account.aspx.cs" Inherits="UPSSO_ASPNET_SAMPLE.Account" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your account information.</h3>
    <p>
        <strong>Display Name: </strong>
        <asp:Literal ID="ltDisplayName" runat="server"></asp:Literal>
    </p>
    <p>
        <strong>Email Address: </strong>
        <asp:Literal ID="ltMail" runat="server"></asp:Literal>
    </p>
</asp:Content>
