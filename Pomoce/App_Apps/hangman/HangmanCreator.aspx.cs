using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pomoce.App_Apps.hangman
{
    public partial class HangmanCreator : System.Web.UI.Page
    {
        List<string> Words { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Words = new List<string>();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "" || TextBox1.Text != null)
            {
                Words.Add(TextBox1.Text);
                TextBox1.Text = "";
                int count = 0;

                if (ViewState["ButtonCount"] != null)
                {
                    count = (int)ViewState["ButtonCount"];
                }

                count++;
                ViewState["ButtonCount"] = count;

                foreach (var w in Words)
                {
                    Literal literal = new Literal();
                    literal.Text = w;
                    literal.ID = "lit" + w;

                    UpdatePanel1.ContentTemplateContainer.Controls.Add(literal);
                }
            }
        }
    }
}