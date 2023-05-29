using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FarmCentral
{
    public partial class Register : System.Web.UI.Page
    {
        Users users = new Users();
        public List<Users> farmersUsersList = new List<Users>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
         /// <summary>
         /// Method that will register user and store data inside the database
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if(drpDwnRole.SelectedItem.Value.Equals("FarmerRole")) 
            {
                int count = 0;
                users.Name = txtName.Text;
                users.Surname = txtSurname.Text;
                users.Email = txtEmail.Text;
                users.Password = txtPassword.Text;
                farmersUsersList.Add(users);
                DbController db = new DbController();
                count = db.LoginFarmer(users.Email, users.Password);
                if (count == 0)
                {
                    db.registerFarmers(users);
                    ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Farmer Successfully Added To System!');window.location='Login.aspx';", true);
                    //Response.Redirect("Login.aspx");
                }
                else
                {
                    ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('User Email Already Exists');window.location='Login.aspx';", true);
                }
            }
            else if(drpDwnRole.SelectedItem.Value.Equals("EmployeeRole")) //Elsee statement if user selects employee role not farmer role
            {
                int count = 0;
                users.Name = txtName.Text;
                users.Surname = txtSurname.Text;
                users.Email = txtEmail.Text;
                users.Password = txtPassword.Text;
                farmersUsersList.Add(users);
                DbController db = new DbController();
                count = db.LoginEmployeesRegistered(users.Email, users.Password);
                if (count == 0)
                {
                    db.registerFarmers(users);
                    ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Farmer Successfully Added To System!');window.location='Login.aspx';", true);
                    //Response.Redirect("Login.aspx");
                }
                else
                {
                    ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('User Email Already Exists');window.location='Login.aspx';", true);
                }
            }           
        }
         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}
//-----------------------------------------------------------------------------------------ooo000EndOfFile000ooo--------------------------------------------------------------------------------------------