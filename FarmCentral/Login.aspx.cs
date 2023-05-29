using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace FarmCentral
{
    public partial class Login : System.Web.UI.Page
    {

        private string checkEmail;
        private string checkPassword;

        //Get set methods tp use to store email and passwords to be checked inside database
        public string CheckName { get => checkEmail; set => checkEmail = value; }
        public string CheckPassword { get => checkPassword; set => checkPassword = value; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
         /// <summary>
         /// Method to log user in to the website
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        protected void btnLogin_Click(object sender, EventArgs e)
        {

            checkEmail = txtEmailLogin.Text;
            checkPassword = txtPasswrdLogin.Text;
            DbController dbControl = new DbController();
            int userIn;
            bool a = drpDwnRoleLogin.SelectedItem.Value == "FarmerRole" ;       //boolean expression to evaluate the submitted farmer account
            bool b = drpDwnRoleLogin.SelectedItem.Value.Equals("EmployeeRole"); //boolean expression to evaluate the submitted employee account


            if (a==true)
            {
                userIn = dbControl.LoginFarmer(checkEmail, checkPassword);
                if (userIn == 1)
                {
                    ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Login Successful!');window.location='FarmersUI.aspx';", true); //This pop up message will let user know if their login in was successful or not.
                    Session["userId"] = checkEmail;
                }
                else
                {
                    ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('User Not Found');window.location='Login.aspx';", true);
                }
            }
            else if (b == true)
            {
                
                userIn = dbControl.LoginEmployeesRegistered(checkEmail, checkPassword);
                if (userIn.Equals(1))
                {
                    ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Login Successful!');window.location='EmployeesUI.aspx';", true);
                    Session["userIdEmployee"] = checkEmail;
                }
                else
                {
                    ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('User Not Found');window.location='Login.aspx';", true);
                }
            }          
        }
         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}
 //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------