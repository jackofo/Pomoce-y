<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HangmanTest.aspx.cs" Inherits="Pomoce.HangmanTest" %>

<asp:Content ID="Content0" ContentPlaceHolderID="HeadPlaceHolder1" runat="server">
    <script src="Build/UnityLoader.js"></script>
    <script>
        UnityLoader.instantiate("unityContainer", "Build/op.json");
    </script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="unityContainer" style="width: 600px; height: 300px; margin: auto"></div>
</asp:Content>
