﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

using Pomoce.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pomoce
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateUser_Click(object sender, EventArgs e)
        {
			//var userStore = new AspNetUserStore();
			//var manager = new AspNetUserManager(userStore);
			//var user = new AspNetUser() { UserName = UserName.Text };

			//IdentityResult result = manager.Create(user, Password.Text);

			//if (result.Succeeded)
			//{
			//	var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
			//	var userIdentity = manager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
			//	authenticationManager.SignIn(new AuthenticationProperties() { }, userIdentity);
			//	Response.Redirect("~/Login.aspx");
			//}
			//else
			//{
			//	StatusMessage.Text = result.Errors.FirstOrDefault();
			//}
		}
    }
}