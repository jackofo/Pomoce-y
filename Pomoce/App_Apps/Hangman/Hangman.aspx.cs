using Pomoce.Model;

using System;
using System.Linq;
using System.Threading;
using System.Web.UI.WebControls;

namespace Pomoce
{
	public partial class HangmanTest : System.Web.UI.Page
    {
        public string data;
        protected void Page_Load(object sender, EventArgs e)
		{
            Guid id = Guid.Parse(Request.QueryString["id"]);
            using (var _db = new Model1())
            {
				data = _db.UserApps.First(ua => ua.Id == id).Data;
            }
        }

        protected void Data_Load(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            ((HiddenField)sender).Value = data;
        }
    }
}