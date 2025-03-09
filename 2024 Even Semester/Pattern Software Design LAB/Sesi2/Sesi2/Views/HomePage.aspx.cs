using Sesi2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sesi2.Views
{
    public partial class HomePage : System.Web.UI.Page
    {
        Database1Entities1 db = new Database1Entities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Models.item> items;

            items = db.items.ToList();

            GridViewItems.DataSource = items;
            GridViewItems.DataBind();
        }
    }
}