<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NearestStore.aspx.cs" Inherits="TryIt_AdelineTrisnobuwono.Contact" Async="True" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <!DOCTYPE html>
    <html lang="en">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Store Finder</title>
        <style>
            /* Add your CSS styles here */
            body {
                text-align: center;
            }

            .header {
                margin-top: 20px;
                font-size: 24px;
            }

            .subheader {
                font-size: 14px;
                color: gray;
            }

            .input-label {
                font-size: 14px;
                margin-top: 10px;
            }

            input[type="text"] {
                width: 80%;
                padding: 5px;
                }

            #searchButton {
                padding: 10px 20px;
                background-color: #007BFF;
                color: white;
                border: none;
                cursor: pointer;
                margin-top: 20px;
            }
        </style>
    </head>
    <body>
        <div class="header">
            <img src="storeFinderLogo.jpg" alt="Store Finder Logo" width="200" height="200">
            <br>
            Store Finder
        <div class="subheader">
            Powered by Yelp
        </div>
        </div>

        <div>
            <label class="input-label">What are you trying to find? (e.g. restaurants, bike repair shop, etc.)</label>
            <br>
            <input type="text" id="storeNameField" placeholder="Enter your search term" runat="server">
        </div>

        <div>
            <label class="input-label">Enter your location (e.g. city, address, zipcode) </label>
            <br>
            <input type="text" id="locationField" placeholder="Enter your location" runat="server">
        </div>

        <div>
             <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="SearchButton_ClickAsync" />
        </div>

        <div>
            <asp:Label ID="resultLabel" runat="server" Text=""></asp:Label>
        </div>
       

    </body>
    </html>

</asp:Content>
