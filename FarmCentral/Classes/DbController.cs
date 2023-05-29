using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FarmCentral
{
    public class DbController
    {
        SqlConnection con; //Creating an object of Sql Connection
        SqlCommand cmd;

         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Constructor Containing SQL Connection String
        /// </summary>
        /// 
        public DbController()
        {
            con = new SqlConnection("Server=tcp:farmcentralst10082143.database.windows.net,1433;Initial Catalog=FarmCentralDb;Persist Security Info=False;User ID=admst10082143;Password=Giftonly89;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            
        }
         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// This Method Will Save Farmer Data To The Database
        /// </summary>
        /// <param name="usr"></param>

        public void registerFarmers(Users usr)
        {
            con.Open();
            string name = usr.Name;
            string surname = usr.Surname;
            // string dob = usr.DateOfBirth;
            string email = usr.Email;
            string passwrd = usr.Password;

            cmd = new SqlCommand("insert into Farmers values (@name, @surname, @email, @password)", con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@surname", surname);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", hashPassword(passwrd));
            cmd.ExecuteNonQuery();
            con.Close();

        }
         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// This Method Will Save Employee Data To The Database
        /// </summary>
        public void registerEmployees(Users usr)
        {
            con.Open();
            string name = usr.Name;
            string surname = usr.Surname;
            // string dob = usr.DateOfBirth;
            string email = usr.Email;
            string passwrd = usr.Password;

            cmd = new SqlCommand("insert into Employees values (@name, @surname, @email, @password)", con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@surname", surname);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", hashPassword(passwrd));
            cmd.ExecuteNonQuery();
            con.Close();
        }
         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// This Method Will Be Used To Hash The Password Of Farmers And Employees After They Register.
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>

        //https://www.youtube.com/watch?v=L3H967B-DZ8&t=359s
        public string hashPassword(string password)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            Byte[] password_bytes = Encoding.ASCII.GetBytes(password);
            sha1.ComputeHash(password_bytes);
            Byte[] encrypted_bytes = sha1.ComputeHash(password_bytes);

            return Convert.ToBase64String(encrypted_bytes);
        }
         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// This Method Will Be Used To Login A Farmer To The Application. The Method Will Search For The User Id and Return 1 If The User Has Been Found.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public int LoginFarmer(string name, string pass)
        {

            int count = 0;
            con.Open();
            try
            {
                cmd = new SqlCommand("select count(1) from Farmers where email=@username and password=@password", con);
                cmd.Parameters.AddWithValue("@username", name);
                cmd.Parameters.AddWithValue("@password", hashPassword(pass));

                cmd.ExecuteNonQuery();
                count = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }

            catch (Exception ex)
            {
                ex.ToString();

            }
            return count;
        }
         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// This method will be used to find a Farmer In The Database In Order To Display Thier Data
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int FindFarmer(string name)
        {

            int count = 0;
            con.Open();
            try
            {
                cmd = new SqlCommand("select count(1) from Farmers where email=@username", con);
                cmd.Parameters.AddWithValue("@username", name);
                cmd.ExecuteNonQuery();
                count = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
            }

            catch (Exception ex)
            {
                ex.ToString();
                //   MessageBox.Show(ex.Message);

            }
            return count;

        }
         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// This Method Will Login Employees To The Website
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public int LoginEmployeesRegistered(string email, string password)
        {
            int count = 0;
            con.Open();
            string con1 = "select count(1) from Employees where email='" + email + "' and password='" + hashPassword(password) + "'";
            cmd = new SqlCommand(con1, con);

            cmd.ExecuteNonQuery();

            count= Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();


            return count;
        }
         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// This Method Will Save Products To The Database.
        /// </summary>
        /// <param name="prod"></param>
        /// <param name="tableName"></param>
        /// <param name="email"></param>

        public void InsertProductToTable(Products prod,string tableName,string email)
        {
            con.Open();

            string productName = prod.ProductName;
            int productQuantity = prod.ProductQty;
            int prodId = 1;


            string query = "Insert into " + tableName + " values (@productName, @productQuantity, @email)";

                cmd = new SqlCommand(query, con);
            
                cmd.Parameters.AddWithValue("@productName", productName);
                cmd.Parameters.AddWithValue("@productQuantity", productQuantity);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.ExecuteNonQuery();
            

            con.Close();
        }
         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// This Method Will Display Products On The Website Depending On Category Selected By User
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="userId"></param>
        /// <param name="gridView"></param>

        public void DisplayProducts(string tableName, string userId,GridView gridView)
        {
               string query = "select * from " + tableName +" where email = @user";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@user", userId);
               // cmd.ExecuteNonQuery();

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                gridView.DataSource = sdr;             
                gridView.DataBind();
                con.Close();          
        }
         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
         /// <summary>
         /// Method that will display all farmer data
         /// </summary>
         /// <param name="userId"></param>
         /// <param name="gridView"></param>
        public void DisplayAllProducts( string userId, GridView gridView)
        {
            string query = "select * from Fruits F, Vegetables V, Meat M, Dairy D where F.email=@user and V.email=@user and M.email=@user and D.email=@user";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@user", userId);
            // cmd.ExecuteNonQuery();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            gridView.DataSource = sdr;
            gridView.DataBind();
            con.Close();

        }
         //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

    }
}
//-----------------------------------------------------------------------------------------ooo000EndOfFile000ooo--------------------------------------------------------------------------------------------