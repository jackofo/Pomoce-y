using Microsoft.AspNet.Identity;

using Pomoce.Model;

using System;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Web.UI.WebControls;

namespace Pomoce
{
	public partial class HangmanTest : System.Web.UI.Page
	{
		public Guid appId;
		public string data;
		protected void Page_Load(object sender, EventArgs e)
		{
			appId = Guid.Parse(Request.QueryString["id"]);
			using (var _db = new Model1())
			{
				data = _db.UserApps.First(ua => ua.Id == appId).Data;
			}
		}

		protected void Data_Load(object sender, EventArgs e)
		{
			Thread.Sleep(1000);
			((HiddenField)sender).Value = data;
		}

		protected void btnNew_Click(object sender, EventArgs e)
		{
			if (User.Identity.IsAuthenticated)
			{
				using (var model = new Model1())
				{
					var id = User.Identity.GetUserId();
					var app = model.UserApps.First(a => a.Id == appId);
					var user = model.AspNetUsers.First(u => u.Id == id);
					model.UsersScores.Add(
						new UserScore 
						{ 
							Score = int.Parse(submitscore.Value), 
							Id = Guid.NewGuid(), 
							User = user, 
							App = app }
						);
					model.SaveChanges();
				}
			}
		}
	}
}