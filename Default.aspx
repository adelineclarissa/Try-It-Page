<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TryIt_AdelineTrisnobuwono._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1>Welcome to my TryIt web application!</h1>
        <p>Project 3 Assignment 3 -  Adeline C. Trisnobuwono </p>
        <br />
        <h4>Navigate to the TryIt pages using the navigation bar or the buttons below.</h4>
    </div>

    <div>
        <asp:Button ID="btnWordCount" runat="server" Text="Try Word Count" OnClick="btnWordCount_Click" />
        <span class="button-space"></span>
        <asp:Button ID="btnNearbyStore" runat="server" Text="Try Nearest Store" OnClick="btnNearbyStore_Click" />
    </div>

</asp:Content>