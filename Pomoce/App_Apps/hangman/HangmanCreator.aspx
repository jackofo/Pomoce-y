<%@ Page Title="Hangman Creator - POMOCE-Y" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HangmanCreator.aspx.cs" Inherits="Pomoce.App_Apps.hangman.HangmanCreator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Button" />
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="Button1" EventName="Click" />
        </Triggers>
    </asp:UpdatePanel>
    
</asp:Content>
