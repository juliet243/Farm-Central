using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FarmCentral
{
    public partial class _Default : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Method To Redirect Winow To Login Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
         /// <summary>
         /// Method To Redirect Winow To Register Window
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}
//-----------------------------------------------------------------------------------------ooo000EndOfFile000ooo--------------------------------------------------------------------------------------------