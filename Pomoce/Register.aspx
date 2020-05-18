<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Pomoce.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div style="font-family: Arial, Helvetica, sans-serif; font-size: small">
        <h4 style="font-size: medium">Register a new user</h4>
        <hr />
        <p>
            <asp:Literal runat="server" ID="StatusMessage" />
        </p>
        <div style="margin-bottom: 10px">
            <asp:Label ID="Label1" runat="server" AssociatedControlID="UserName" Text="User name" CssClass="text-dark"></asp:Label>
            <div>
                <asp:TextBox ID="UserName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div style="margin-bottom: 10px">
            <asp:Label ID="Label2" runat="server" AssociatedControlID="Password" Text="Password" CssClass="text-dark"></asp:Label>
            <div>
                <asp:TextBox ID="Password" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div style="margin-bottom: 10px">
            <asp:Label ID="Label3" runat="server" AssociatedControlID="ConfirmPassword" Text="Confirm password" CssClass="text-dark"></asp:Label>
            <div>
                <asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div>
            <div>
                <asp:Button ID="CreateUser" runat="server" OnClick="CreateUser_Click" Text="Register" CssClass="btn btn-dark" />
            </div>
        </div>
    </div>
</asp:Content>
