<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AppBrowser.aspx.cs" Inherits="Pomoce.App_Apps.AppBrowser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder1" runat="server">
    <style type="text/css">
        .auto-style1
        {
            display: block;
            width: 100%;
            height: 34px;
            padding: 6px 12px;
            font-size: 14px;
            line-height: 1.42857143;
            color: #555555;
            background-color: #fff;
            background-image: none;
            border: 1px solid #ccc;
            border-radius: 4px;
            -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
            box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
            -webkit-transition: border-color ease-in-out .15s, box-shadow ease-in-out .15s;
            -o-transition: border-color ease-in-out .15s, box-shadow ease-in-out .15s;
            -webkit-transition: border-color ease-in-out .15s, -webkit-box-shadow ease-in-out .15s;
            transition: border-color ease-in-out .15s, -webkit-box-shadow ease-in-out .15s;
            transition: border-color ease-in-out .15s, box-shadow ease-in-out .15s;
            transition: border-color ease-in-out .15s, box-shadow ease-in-out .15s, -webkit-box-shadow ease-in-out .15s;
            left: -1px;
            top: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <hr />
    <div class="input-group">
        <asp:TextBox class="form-control" ID="TextBox1" runat="server" aria-label="Search" type="text" Width="70%" ToolTip="Search" ValidateRequestMode="Disabled" />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="Button1_Click" type="button" CssClass="btn btn-primary">
                    <span class="glyphicon glyphicon-search"></span>
        </asp:LinkButton>
    </div>
    <hr />
    <asp:Repeater runat="server" ID="Repeater1" DataSourceID="SqlDataSource1">
        <ItemTemplate>
            <asp:Button ID="ImageButton1"
                OnClick="Unnamed_Click"
                CommandName='<%# Eval("Type").ToString().Trim() %>'
                CommandArgument='<%# Eval("Id").ToString().Trim() %>'
                Text='<%# Eval("Name").ToString().Trim() %>'
                runat="server"
                Height="150"
                Width="300"
                Style='<%# "background-image: url(../../Images/" + Eval("Type").ToString().Trim() + ".png); background-size: cover; font-weight: bold; text-align: center; line-height: 150px; text-shadow: -1px 0 black, 0 1px black, 1px 0 black, 0 -1px black; color: #FFFFFF; font-size: 24px;" %>' />
        </ItemTemplate>
    </asp:Repeater>
    <asp:SqlDataSource
        ID="SqlDataSource1"
        runat="server"
        ConnectionString="***REMOVED***"
        ProviderName="System.Data.SqlClient"
        SelectCommand="SELECT [UserApps].[Id], [UserApps].[Name], [AppTypes].[Name] as 'Type' FROM [UserApps] JOIN [AppTypes] ON [UserApps].[AppType]=[AppTypes].Id"></asp:SqlDataSource>
</asp:Content>
