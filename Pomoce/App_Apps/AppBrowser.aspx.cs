using System;
using System.Web.UI.WebControls;

namespace Pomoce.App_Apps
{
	public partial class AppBrowser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

		protected void Unnamed_Click(object sender, EventArgs e)
		{
			var btn = ((Button)sender);
			Response.Redirect($"~/App_Apps/{btn.CommandName}/{btn.CommandName}?id={btn.CommandArgument}");
		}

		protected void TextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			SqlDataSource1.SelectCommand = "SELECT [Table].[Id], [Table].[Name], [AppTypes].[Name] as 'Type' FROM [Table] JOIN [AppTypes] ON [Table].[AppType]=[AppTypes].Id WHERE [Table].[Name] LIKE '%" + TextBox1.Text + "%';";
		}
	}
}