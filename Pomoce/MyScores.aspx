<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyScores.aspx.cs" Inherits="Pomoce.MyScores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <hr />
    <h2>My scores:</h2>
    <hr />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Model1 %>" SelectCommand="SELECT [UserApps].Name, UserScores.Score FROM UserScores INNER JOIN [UserApps] ON UserScores.User_Id = @UserId">
        <SelectParameters>
            <asp:Parameter Name="UserId" DbType="String" />
        </SelectParameters>
    </asp:SqlDataSource>
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-striped" DataSourceID="SqlDataSource1" BorderStyle="None" GridLines="None">
    <AlternatingRowStyle BorderStyle="None" />
    <Columns>
        <asp:BoundField DataField="Name" HeaderText="App" SortExpression="Name" />
        <asp:BoundField DataField="Score" HeaderText="Score" SortExpression="Score" />
    </Columns>
    <EditRowStyle BorderStyle="None" />
    <EmptyDataRowStyle BorderStyle="None" />
    <HeaderStyle CssClass="thead-light" BorderStyle="None" />
    <RowStyle BorderStyle="None" />
    <SelectedRowStyle BorderStyle="None" />
</asp:GridView>
    
</asp:Content>
