using Microsoft.AspNet.FriendlyUrls;
using Microsoft.AspNet.Identity;
using Pomoce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Pomoce.App_Apps.hangman
{
    public partial class CreateHangmanApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            using(var _db = new Model.Model1())
            {
                if(output.Value != null || output.Value != "")
                {
                    string id = User.Identity.GetUserId<string>();
                    var app = new Model.UserApp()
                    {
                        Id = Guid.NewGuid(),
                        User = id,
                        Name = TextBox1.Text,
                        Data = output.Value,
                        AppType = _db.AppTypes.First(at => at.Name == "Hangman").Id
                    };

                    _db.UserApps.Add(app);
                    _db.SaveChanges();
                }
            }
        }
    }
}