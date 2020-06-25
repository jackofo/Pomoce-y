using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Microsoft.AspNet.Identity;

namespace Pomoce
{
	public partial class MyScores : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			SqlDataSource1.SelectParameters["UserId"].DefaultValue = User.Identity.GetUserId();
		}
	}
}