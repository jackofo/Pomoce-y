using Microsoft.AspNet.Identity;

using System;
using System.Linq;

using Pomoce.Models;

namespace Pomoce.App_Apps.hangman
{
	public partial class CreateHangmanApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            using(var _db = new ApplicationDbContext())
            {
                if(output.Value != null || output.Value != "")
                {
                    string id = User.Identity.GetUserId<string>();
                    var user = _db.Users.First(u => u.Id == id);
                    var app = new Model.UserApp()
                    {
                        Id = Guid.NewGuid(),
                        User = user,
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