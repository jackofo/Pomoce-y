<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateHangmanApp.aspx.cs" Inherits="Pomoce.App_Apps.hangman.CreateHangmanApp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Add name:</h2>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <h2>Add words:</h2>
    <div id="creator">
        <div id="added">
        </div>
        <input type="text" id="input" value="" />
        <button onclick="AddText();return false;">+</button>
        <asp:HiddenField ID="output" runat="server" Value="" />
        <br />
        <asp:Button runat="server" OnClick="Unnamed1_Click" Text="Create" />
    </div>
    <script src="../../Scripts/HangmanCreator.js"></script>
</asp:Content>
