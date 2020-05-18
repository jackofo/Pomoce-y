<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Pomoce.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div style="font-family: Arial, Helvetica, sans-serif; font-size: small">
        <div>
            <h4 style="font-size: medium">Log In</h4>
            <hr />
            <asp:PlaceHolder runat="server" ID="LoginStatus" Visible="false">
                <p>
                    <asp:Literal runat="server" ID="StatusText" />
                </p>
            </asp:PlaceHolder>
            <asp:PlaceHolder runat="server" ID="LoginForm" Visible="false">
                <div style="margin-bottom: 10px">
                    <asp:Label runat="server" AssociatedControlID="UserName" CssClass="text-dark">User name</asp:Label>
                    <div>
                        <asp:TextBox runat="server" ID="UserName" CssClass="form-control" />
                    </div>
                </div>
                <div style="margin-bottom: 10px">
                    <asp:Label runat="server" AssociatedControlID="Password" CssClass="text-dark">Password</asp:Label>
                    <div>
                        <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                    </div>
                </div>
                <div style="margin-bottom: 10px">
                    <div>
                        <asp:Button runat="server" OnClick="SignIn" Text="Log in" CssClass="btn btn-dark" />
                    </div>
                </div>
            </asp:PlaceHolder>
            <asp:PlaceHolder runat="server" ID="LogoutButton" Visible="false">
                <div>
                    <div>
                        <asp:Button runat="server" OnClick="SignOut" Text="Log out" CssClass="btn btn-dark" />
                    </div>
                </div>
            </asp:PlaceHolder>
        </div>
    </div>
</asp:Content>
