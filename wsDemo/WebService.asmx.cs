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
        public List<Reservation> getReservationByIdClient(int id)
        {
            string BDpath = Server.MapPath("~/database.db");

            Console.WriteLine(BDpath);

            List<Reservation> reservations = new List<Reservation>();

            using (SQLiteConnection conn = new SQLiteConnection("Data Source =" + BDpath + ";Version=3;"))
            {

                string query = "SELECT * FROM Reservation inner join Room on Reservation.idRoom = Room.id WHERE idClient = @id";
                SQLiteCommand command = new SQLiteCommand(query, conn);
                command.Parameters.AddWithValue("@id", id);
                command.Prepare();


               
                try
                {
                    conn.Open();

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            reservations.Add(new Reservation(reader));
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
            return reservations;
        }

        [WebMethod]
        public List<Reservation> getReservationByIdReceptionist(int id)
        {
            string BDpath = Server.MapPath("~/database.db");

            Console.WriteLine(BDpath);

            List<Reservation> reservations = new List<Reservation>();

            using (SQLiteConnection conn = new SQLiteConnection("Data Source =" + BDpath + ";Version=3;"))
            {

                string query = "SELECT * FROM Reservation inner join Room on Reservation.idRoom = Room.id WHERE idReceptionist = @id";
                SQLiteCommand command = new SQLiteCommand(query, conn);
                command.Parameters.AddWithValue("@id", id);
                command.Prepare();

                try
                {
                    conn.Open();

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            reservations.Add(new Reservation(reader));
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
            return reservations;
        }

        [WebMethod]
        public bool addReservation(int idClient,int idReceptionist,string idRoom, string reservationName, string arrivalDate,int nights)
        {
            bool res = false;

            string BDpath = Server.MapPath("~/database.db");

            Console.WriteLine(BDpath);

            using (SQLiteConnection conn = new SQLiteConnection("Data Source =" + BDpath + ";Version=3;"))
            {

                string query = "INSERT INTO Reservation VALUES (NULL, @idClient, @idReceptionist, @idRoom, @reservationName, @arrivalDate, @nights)";
                SQLiteCommand command = new SQLiteCommand(query, conn);
                command.Parameters.AddWithValue("@idClient", idClient);
                command.Parameters.AddWithValue("@idReceptionist", idReceptionist);
                command.Parameters.AddWithValue("@idRoom", idRoom);
                command.Parameters.AddWithValue("@reservationName", reservationName);
                command.Parameters.AddWithValue("@arrivalDate", arrivalDate);
                command.Parameters.AddWithValue("@nights", nights);
                command.Prepare();

                try
                {
                    conn.Open();
                    res = (command.ExecuteNonQuery() > 0);         
                }
                catch (SqlException exc)
                {
                    Console.WriteLine("Error Generated. Details: " + exc.ToString());
                    res = false;
                }
                finally
                {
                    conn.Close();
                }
            }
            return res;
        }

        [WebMethod]
        public bool updateReservation(int id, int idClient, string idRoom, string reservationName, string arrivalDate, int nights)
        {
            bool res = false;

            string BDpath = Server.MapPath("~/database.db");

            Console.WriteLine(BDpath);

            using (SQLiteConnection conn = new SQLiteConnection("Data Source =" + BDpath + ";Version=3;"))
            {

                string query = "UPDATE Reservation SET idClient=@idClient, reservationName=@reservationName, idRoom=@idRoom, arrivalDate=@arrivalDate, reservationNights=@nights WHERE Reservation.id=@id;";
                SQLiteCommand command = new SQLiteCommand(query, conn);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@idClient", idClient);
                command.Parameters.AddWithValue("@idRoom", idRoom);
                command.Parameters.AddWithValue("@reservationName", reservationName);
                command.Parameters.AddWithValue("@arrivalDate", arrivalDate);
                command.Parameters.AddWithValue("@nights", nights);
                command.Prepare();

                try
                {
                    conn.Open();
                    res = (command.ExecuteNonQuery() > 0);
                }
                catch (SqlException exc)
                {
                    Console.WriteLine("Error Generated. Details: " + exc.ToString());
                    res = false;
                }
                finally
                {
                    conn.Close();
                }
            }
            return res;
        }

        [WebMethod]
        public bool deleteReservation(int id)
        {
            bool res = false;

            string BDpath = Server.MapPath("~/database.db");

            Console.WriteLine(BDpath);

            using (SQLiteConnection conn = new SQLiteConnection("Data Source =" + BDpath + ";Version=3;"))
            {

                string query = "DELETE FROM Reservation WHERE id=@id;";
                SQLiteCommand command = new SQLiteCommand(query, conn);
                command.Parameters.AddWithValue("@id", id);
                command.Prepare();

                try
                {
                    conn.Open();
                    res = (command.ExecuteNonQuery() > 0);
                }
                catch (SqlException exc)
                {
                    Console.WriteLine("Error Generated. Details: " + exc.ToString());
                    res = false;
                }
                finally
                {
                    conn.Close();
                }
            }
            return res;
        }
    }
}