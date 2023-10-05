<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WordCount.aspx.cs" Inherits="TryIt_AdelineTrisnobuwono.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1 style="font-size: 36px;">Word Count Web App</h1>
    </div>

    <div class="input-section">

        <h2 style="font-size: 18px;">Enter file path (with or without .txt):</h2>
        <h2 style="font-size: 12px;">NOTE: use sample texts "small_text" and "large_text" or type in your full file path (e.g. C:\Desktop\sampleTextFile) </h2>
        <asp:TextBox ID="TextBox1" runat="server" Style="width: 300px;"></asp:TextBox>
        <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" CssClass="btn btn-primary" />
    </div>

    <div class="result-section">
        <h2 style="font-size: 18px;">Word count in the file:</h2>
        <asp:Label ID="ResultLabel" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
