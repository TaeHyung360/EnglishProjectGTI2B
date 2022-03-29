using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using demo.ws;
namespace demo.receptionist
{
    public partial class receptionist : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                ws.WebService service = new ws.WebService();
                int id = Convert.ToInt32(Session["id"].ToString());
                Reservation[] reservations = service.getReservationByIdReceptionist(id);
               

                ListBoxReservations.DataSource = reservations;
                ListBoxReservations.DataBind();
                
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
        }
    }
}