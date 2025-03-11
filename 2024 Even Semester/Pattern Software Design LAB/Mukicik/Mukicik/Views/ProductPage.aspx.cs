using Mukicik.Factories;
using Mukicik.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mukicik.Views
{
    public partial class ProductPage : System.Web.UI.Page
    {
        ProductFactory factory = new ProductFactory();
        ProductRepo repo = new ProductRepo();
        public void RefreshGridView()
        {
            GridViewProduct.DataSource = repo.GetAllProducts();
            GridViewProduct.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshGridView();
        }

        protected void IncreaseButton_Click(object sender, EventArgs e)
        {
            int.TryParse(InputProductIdTextBox.Text, out int productId);
            int.TryParse(ValueTextBox.Text, out int value);
            repo.IncreaseProductPrice(productId, value);
            RefreshGridView();
        }

        protected void DecreaseButton_Click(object sender, EventArgs e)
        {
            int.TryParse(InputProductIdTextBox.Text, out int productId);
            int.TryParse(ValueTextBox.Text, out int value);
            repo.DecreaseProductPrice(productId, value);
            RefreshGridView();
        }
    }
}