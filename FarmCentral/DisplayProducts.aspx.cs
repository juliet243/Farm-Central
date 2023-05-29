using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FarmCentral
{
    public partial class DisplayProducts : System.Web.UI.Page
    {
        //This variable will store(using Sessions) the userId logged into the web application 
        string usrId = ""; 
        DbController db = new DbController(); //Creating an object of Db Controller Class

         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
         /// <summary>
         /// 
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
         /// Metgod that will display data on web form via means of a grid view.
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        protected void btnDsplyProd_Click(object sender, EventArgs e)
        {

            string Id = txtEmail.Text; 
            int count = db.FindFarmer(Id); //Valling the Find Farmer method to look for farmer inside the database

            if(count ==1) //If statement that will be executed if farmer is found iside database
            {
                string tblName;
                if (drpDwnProductCategory.SelectedItem.Value.Equals("DisplayAll")) 
                {
                    db.DisplayAllProducts(Id, gVDisplay);
                }
                else if (drpDwnProductCategory.SelectedItem.Value.Equals("DisplayFruits"))
                {
                    tblName = "Fruits";
                    db.DisplayProducts(tblName, Id, gVDisplay);
                }
                else if (drpDwnProductCategory.SelectedItem.Value.Equals("DisplayVegetables"))
                {
                    tblName = "Vegetables";
                    db.DisplayProducts(tblName, Id, gVDisplay);
                }
                else if (drpDwnProductCategory.SelectedItem.Value.Equals("DisplayDairy"))
                {
                    tblName = "Dairy";
                    db.DisplayProducts(tblName, Id, gVDisplay);
                }
                else if (drpDwnProductCategory.SelectedItem.Value.Equals("DisplayMeat"))
                {
                    tblName = "Meat";
                    db.DisplayProducts(tblName, Id, gVDisplay);
                }
            }
            else
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('User/Farmer Does Not Exist');window.location='DisplayProducts.aspx';", true);
            }       
        }
         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}
//-----------------------------------------------------------------------------------------ooo000EndOfFile000ooo--------------------------------------------------------------------------------------------