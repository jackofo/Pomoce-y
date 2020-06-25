<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Hangman.aspx.cs" Inherits="Pomoce.HangmanTest" %>

<asp:Content ID="Content0" ContentPlaceHolderID="HeadPlaceHolder1" runat="server">
    <script src="Build/UnityLoader.js"></script>
    <script>
        var unityInstance = UnityLoader.instantiate("unityContainer", "Build/hm.json");

        function GetStrings() {
            var data = document.getElementById("MainContent_data").value;
            unityInstance.SendMessage('EventSystem', 'GetStrings', data);
        }
    </script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:HiddenField ID="data" Value="" runat="server" OnLoad="Data_Load" />
    <div id="unityContainer" style="width: 600px; height: 300px; margin: auto"></div>
</asp:Content>
