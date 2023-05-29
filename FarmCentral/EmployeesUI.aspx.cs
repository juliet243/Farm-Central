using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FarmCentral
{
    public partial class EmployeesUI : System.Web.UI.Page
    {

        string userId;

         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
         /// <summary>
         /// 
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["userId"] != null)
            {
                userId = Session["userId"].ToString();
            }
        }
         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}
//-----------------------------------------------------------------------------------------ooo000EndOfFile000ooo--------------------------------------------------------------------------------------------