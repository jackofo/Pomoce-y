using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI.WebControls;

using Pomoce.Models;

namespace Pomoce.Model
{
	public class UserScore
	{
		public Guid Id { get; set; }
		public int Score { get; set; }
		public ApplicationUser User { get; set; }
		public UserApp App { get; set; }
	}
}