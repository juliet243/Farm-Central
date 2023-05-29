using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace FarmCentral
{
    public partial class AddNewProduct : System.Web.UI.Page
    {
        Products prod = new Products();
        public List<Products> productsList = new List<Products>();
        DbController db = new DbController(); //Creating an object of the Database Controller Class
        string userId = ""; //Variable to use to store user id/email from session


         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
         /// <summary>
         /// Constructor that will take in user id value stored by making use of sessions.
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {           
            if (Session["userId"] != null)
            {
                userId = Session["userId"].ToString();
            }
        }
         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// This method will allow a farmer to upload their products into a common database that links each product to their ID.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        protected void btnAddNewPrdct_Click(object sender, EventArgs e)
        {
            if (drpDwnProductCtgry.SelectedItem.Value.Equals("FruitsCategory"))
            {
                string tableName = "Fruits"; //Storing the name of the table to pass as an argument to DbController Class
                prod.ProductName = txtItemNameAdded.Text;
                prod.ProductQty = Convert.ToInt32(txtItemQtyAdded.Text);
                productsList.Add(prod);
                db.InsertProductToTable(prod,tableName,userId);

            }
            else if (drpDwnProductCtgry.SelectedItem.Value.Equals("VegetablesCategory"))
            {
                string tableName = "Vegetables";  //Storing the name of the table to pass as an argument to DbController Class
                prod.ProductName = txtItemNameAdded.Text;
                prod.ProductQty = Convert.ToInt32(txtItemQtyAdded.Text);
                productsList.Add(prod);
                db.InsertProductToTable(prod, tableName, userId);
            }
            else if(drpDwnProductCtgry.SelectedItem.Value.Equals("DairyCategory"))
            {
                string tableName = "Dairy";  //Storing the name of the table to pass as an argument to DbController Class
                prod.ProductName = txtItemNameAdded.Text;
                prod.ProductQty = Convert.ToInt32(txtItemQtyAdded.Text);
                productsList.Add(prod);
                db.InsertProductToTable(prod, tableName, userId);
            }
            else if(drpDwnProductCtgry.SelectedItem.Value.Equals("MeatCategory"))
            {
                string tableName = "Meat";  //Storing the name of the table to pass as an argument to DbController Class
                prod.ProductName = txtItemNameAdded.Text;
                prod.ProductQty = Convert.ToInt32(txtItemQtyAdded.Text);
                productsList.Add(prod);
                db.InsertProductToTable(prod, tableName, userId);
            }
        }
         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}
//-----------------------------------------------------------------------------------------ooo000EndOfFile000ooo--------------------------------------------------------------------------------------------