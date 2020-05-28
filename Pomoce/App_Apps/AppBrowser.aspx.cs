using Pomoce.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pomoce.App_Apps
{
    public partial class AppBrowser : System.Web.UI.Page
    {
        protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var row = GridView1.SelectedRow;
            string redirectUrl = "~/";
            string type = row.Cells[3].Text.Trim();
            switch (type)
            {
                case "Hangman":
                    redirectUrl = "/App_Apps/hangman/HangmanTest";
                    break;
                default:
                    Response.Redirect(redirectUrl);
                    break;
            }
            redirectUrl += "?id=" + row.Cells[1].Text;
            Response.Redirect(redirectUrl);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}