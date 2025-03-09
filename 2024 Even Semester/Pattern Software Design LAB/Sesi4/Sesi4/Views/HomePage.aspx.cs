using Sesi4.Factories;
using Sesi4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sesi4.Views
{
    public partial class HomePage : System.Web.UI.Page
    {
        Database1Entities1 db = new Database1Entities1();

        public void RefreshGridView()
        {
            GridViewDatabase.DataSource = db.Items.ToList();
            GridViewDatabase.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshGridView();
            DropDownItemType.DataSource = db.Item_Type.Select(x => x.name).ToList();
            DropDownItemType.DataBind();
        }

        protected void AddItemButton_Click(object sender, EventArgs e)
        {
            String name = NameTextBox.Text;
            int price = Convert.ToInt32(PriceTextBox.Text);
            int stock = Convert.ToInt32(StockTextBox.Text);
            String type = db.Item_Type.Where(x => x.name == DropDownItemType.Text).Select(x => x.id).FirstOrDefault();

            Item item = ItemFactory.CreateItem(name, type, price, stock);
            db.Items.Add(item);
            db.SaveChanges();

            RefreshGridView();
        }
    }
}