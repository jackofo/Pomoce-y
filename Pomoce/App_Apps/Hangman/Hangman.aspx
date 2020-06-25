<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Hangman.aspx.cs" Inherits="Pomoce.HangmanTest" %>

<asp:Content ID="Content0" ContentPlaceHolderID="HeadPlaceHolder1" runat="server">
    <script src="Build/UnityLoader.js"></script>
    <script>
        var unityInstance = UnityLoader.instantiate("unityContainer", "Build/hm.json");

        function GetStrings() {
            var data = document.getElementById("MainContent_data").value;
            unityInstance.SendMessage('EventSystem', 'GetStrings', data);
        }

        function SubmitScore(score) {
            console.log(score);
            document.getElementById("MainContent_submitscore").value = score;
            document.getElementById("<%=btn.ClientID%>").click();
            
        }
    </script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:HiddenField ID="data" Value="" runat="server" OnLoad="Data_Load" />
    <asp:HiddenField ID="submitscore" runat="server" OnValueChanged="btnNew_Click" />
    <asp:Button hidden ID="btn" runat="server" OnClick="btnNew_Click" />
    <div id="unityContainer" style="width: 600px; height: 300px; margin: auto"></div>
    </asp:Content>
