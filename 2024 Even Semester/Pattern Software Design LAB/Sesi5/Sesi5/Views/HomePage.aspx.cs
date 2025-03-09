using Sesi5.Factories;
using Sesi5.Models;
using Sesi5.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sesi5.Views
{
    public partial class HomePage : System.Web.UI.Page
    {
        ProductRepository repo = new ProductRepository();
        ProductFactory factory = new ProductFactory();

        protected void Page_Load(object sender, EventArgs e)
        {
            TypeDropDownList.DataSource = new List<string>()
            {
                "Electronic", "Furniture", "Clothing"
            };
            TypeDropDownList.DataBind();

            RefreshGridView();
        }

        public void RefreshGridView()
        {
            GridViewProducts.DataSource = repo.GetAllProduct();
            GridViewProducts.DataBind();
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            String name = NameTextBox.Text;
            int.TryParse(PriceTextBox.Text, out int price);
            int.TryParse(StockTextBox.Text, out int stock);
            String type = TypeDropDownList.SelectedValue;
            int id = repo.GetLastId() + 1;

            Product product = factory.CreateProduct(id, name, type, price, stock);
            repo.InsertProduct(product);
            RefreshGridView();
        }
    }
}