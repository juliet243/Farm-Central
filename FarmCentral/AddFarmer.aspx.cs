using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace FarmCentral
{
    public partial class AddFarmer : System.Web.UI.Page
    {

        Users users = new Users(); //Object on Users Class
        public List<Users> farmersUsersList = new List<Users>(); //Users custom List to store farmers

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        protected void Page_Load(object sender, EventArgs e)
        {

        }
         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
         /// <summary>
         /// Method To Be Executed After User Presses Save Button.
         /// This Method Will Allow A Farm Central Employee To Add A Farmer To The Database.
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        protected void btnSaveFarmer_Click(object sender, EventArgs e)
        {
           
            int count = 0;
            users.Name = txtFarmrNameAdded.Text;
            users.Surname = txtFarmerSurnameAdded.Text;
            users.Email = txtFarmerEmalAdded.Text;
            users.Password = txtPasswrd.Text;
            farmersUsersList.Add(users);
            DbController db = new DbController();
            count = db.LoginFarmer(users.Email, users.Password);
            if (count == 0)
            {
                db.registerFarmers(users);
                ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Farmer Successfully Added To System!');window.location='EmployeesUI.aspx';", true);
                //Response.Redirect("Login.aspx");
            }
            else
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('User Email Already Exists');window.location='AddFarmer.aspx';", true);
            }
            
        }
         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}
//-----------------------------------------------------------------------------------------ooo000EndOfFile000ooo--------------------------------------------------------------------------------------------