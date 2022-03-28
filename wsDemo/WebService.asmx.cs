using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using System.Text;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Web.Security;
using System.Data;
using wsDemo.Model;

namespace wsDemo
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {


        [WebMethod]
        public string get(string userName)
        {
            string BDpath = Server.MapPath("~/database.db");

            Console.WriteLine(BDpath);

            String userNameSaved = "";

            using (SQLiteConnection conn = new SQLiteConnection("Data Source =" + BDpath + ";Version=3;"))
            {

                string query = "SELECT * FROM users WHERE users.user='" + userName + "'";

                SQLiteCommand comm = new SQLiteCommand(query, conn);

                try
                {
                    conn.Open();

                    using (SQLiteDataReader reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            userNameSaved = reader.GetString(0);
                            FormsAuthentication.SetAuthCookie(userNameSaved, true);

                        }
                    }
                }
                catch (SqlException exc)
                {
                    Console.WriteLine("Error Generated. Details: " + exc.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }

            return userNameSaved;
        }

        [WebMethod]
        public User login(string user, string password)
        {
            string BDpath = Server.MapPath("~/database.db");

            Console.WriteLine(BDpath);


            User userRes = null;

            using (SQLiteConnection conn = new SQLiteConnection("Data Source =" + BDpath + ";Version=3;"))
            {

                string query = "SELECT * FROM User WHERE User.userName='" + user + "' AND User.password= '" + password + "'";

                SQLiteCommand comm = new SQLiteCommand(query, conn);
                try
                {
                    conn.Open();

                    using (SQLiteDataReader reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            userRes = new User(reader);
                        }
                    }
                }
                catch (SqlException exc)
                {
                    Console.WriteLine("Error Generated. Details: " + exc.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
            return userRes;
        }

        [WebMethod]
        public String getReservationByIdClient(int id)
        {
            string BDpath = Server.MapPath("~/database.db");

            Console.WriteLine(BDpath);

            string typeUser = "";

            using (SQLiteConnection conn = new SQLiteConnection("Data Source =" + BDpath + ";Version=3;"))
            {

                string query = "SELECT * FROM User WHERE User.userName='" + user + "' AND User.password= '" + password + "'";

                SQLiteCommand comm = new SQLiteCommand(query, conn);
                try
                {
                    conn.Open();

                    using (SQLiteDataReader reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String userName = reader.GetString(4);
                            FormsAuthentication.SetAuthCookie(userName, true);
                            typeUser = reader.GetInt32(3).ToString();
                            return typeUser;
                        }
                    }
                }
                catch (SqlException exc)
                {
                    Console.WriteLine("Error Generated. Details: " + exc.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
            return typeUser;
        }
    }
}