<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Logowanie.aspx.cs" Inherits="Pomoce.Logowanie" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <script>  
       function FunForLoginValidation() {  
           var objValid = true;  
           var objUserName = $("[id$=txtUserName]").val();  
           var objPassword = $("[id$=txtPassword]").val();  
           if (objUserName == "") {  
               $('[id$=lblErrUserName]').text("User Name is required");  
               $('[id$=lblErrUserName]').css("color", "#FF0000");  
               $("[id$=txtUserName]").addClass("Error-control");  
               objValid = false;  
           }  
           else {  
               $('[id$=lblErrUserName]').text("");  
               $('[id$=lblErrUserName]').css("color", "#FFFFFF");  
               $("[id$=txtUserName]").removeClass("Error-control");  
           }  
  
           if (objPassword == "") {  
               $('[id$=lblErrPassword]').text("Password is required");  
               $('[id$=lblErrPassword]').css("color", "#FF0000");  
               $("[id$=txtPassword]").addClass("Error-control");  
               objValid = false;  
           }  
           else {  
               $('[id$=lblErrPassword]').text("");  
               $('[id$=lblErrPassword]').css("color", "#FFFFFF");  
               $("[id$=txtPassword]").removeClass("Error-control");  
           }  
           return objValid;  
       }  
       function AcceptAlphanumeric(evt) {  
           var key = evt.keyCode;  
           return ((key >= 48 && key <= 57) || (key >= 65 && key <= 90) || (key >= 95 && key <= 122));  
       }  
       function NotAllowSingleDoubleQuotes(e) {  
           var charCode = e.keyCode;  
           if (charCode == 34)  
               return false;  
           if (charCode == 39)  
               return false;  
       }  
   </script>  

    <div class="container">  
           <div class="row">  
               <div class="col-lg-5 col-md-6 col-sm-8 col-xl-12 " style="margin: auto; float: initial; padding-top: 12%">  
                   <div class="row userInfo">  
  
                       <div class="panel panel-default ">  
                           <div class="panel-heading">  
                               <h3 class="panel-title" style="text-align: center; font-weight: bold">  
                                   <a class="collapseWill">Login to your Account</a>  
                               </h3>  
                           </div>  
                           <div id="collapse1" class="panel-collapse collapse in">  
                               <div class="panel-body">  
                                   <fieldset>  
                                       <div class="form-group">  
                                           <div class="col-md-"></div>  
                                           <label class="col-md-12 control-label" for="prependedcheckbox">  
                                               User ID  
                                           </label>  
                                           <div class="col-md-12">  
                                               <div class="input-group">  
                                                   <span class="input-group-addon">  
                                                       <i class="fa fa-user"></i>  
                                                   </span>  
                                                   <asp:TextBox ID="txtUserName" CssClass="form-control" placeholder="Enter User ID" runat="server"></asp:TextBox>  
                                               </div>  
                                               <asp:Label ID="lblErrUserName" CssClass="help-block" runat="server" Text="" ForeColor="White"></asp:Label>  
                                           </div>  
  
                                           <label class="col-md-12 control-label" for="prependedcheckbox">  
                                               Password  
                                           </label>  
                                           <div class="col-md-12">  
                                               <div class="input-group">  
                                                   <span class="input-group-addon">  
                                                       <i class="fa fa-lock"></i>  
                                                   </span>  
                                                   <asp:TextBox ID="txtPassword" CssClass="form-control" placeholder="Enter Your Password" runat="server" TextMode="Password"></asp:TextBox>  
                                               </div>  
                                               <asp:Label ID="lblErrPassword" CssClass="help-block" runat="server" Text="" ForeColor="White"></asp:Label>  
                                           </div>  
  
                                           <div class="col-md-12">  
                                               <div class="col-lg-6">  
                                                   <asp:CheckBox ID="chbRemember" Visible="false" runat="server" Text="Remember" />  
                                               </div>  
                                               <div class="col-lg-6">  
                                                   <div class="input-group" style="width: 100%">  
                                                       <asp:Button ID="btnLogin" CssClass="btn btn-success" Text="Login" OnClientClick="return FunForLoginValidation()" runat="server" Style="width: 100%" />  
                                                   </div>  
                                               </div>  
                                           </div>  
                                       </div>  
                                   </fieldset>  
  
                               </div>  
                           </div>  
  
                           <div class="panel-heading">  
                               <div class="panel-title" style="text-align: right">  
                                   <a class="collapseWill" href="ForgetPassword.aspx" style="font-size: x-small">Forgot Username or Password?  
                                   </a>  
                               </div>  
                           </div>  
                       </div>  
                   </div>  
               </div>  
           </div>  
       </div>  
</asp:Content>
