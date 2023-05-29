using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FarmCentral
{
    public partial class DisplayProductsFarmer : System.Web.UI.Page
    {
        string usrId = ""; //Variable to store user email from session
        DbController db = new DbController();

         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
         /// <summary>
         /// Default constructor with a session storing farmer email address
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["userId"] != null)
            {
                usrId = Session["userId"].ToString();
            }
        }
         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
         /// <summary>
         /// This Method will display products of a farmer on their personal account.
         ///
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        protected void btnDsplyProdFarmer_Click(object sender, EventArgs e)
        {
            string tblName; //Local variable to store name of the table selected in the if statetemnts below
            if (drpDwnProductCategory.SelectedItem.Value.Equals("selectCategory"))
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "Message", "Select A Category');window.location='DisplayProducts.aspx';", true);
            }
            else if (drpDwnProductCategory.SelectedItem.Value.Equals("CategoryFruits"))
            {
                tblName = "Fruits";
                db.DisplayProducts(tblName, usrId, gViewDisplayPrd);
            }
            else if (drpDwnProductCategory.SelectedItem.Value.Equals("CategoryVegetables"))
            {
                tblName = "Vegetables";
                db.DisplayProducts(tblName, usrId, gViewDisplayPrd);
            }
            else if (drpDwnProductCategory.SelectedItem.Value.Equals("CategoryDairy"))
            {
                tblName = "Dairy";
                db.DisplayProducts(tblName, usrId, gViewDisplayPrd);
            }
            else if (drpDwnProductCategory.SelectedItem.Value.Equals("CategoryMeat"))
            {
                tblName = "Meat";
                db.DisplayProducts(tblName, usrId, gViewDisplayPrd);
            }
        }
         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}
//-----------------------------------------------------------------------------------------ooo000EndOfFile000ooo--------------------------------------------------------------------------------------------