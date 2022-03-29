
using System;
using System.Collections.Generic;
using demo.ws;

namespace demo.client
{
    public partial class client : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                ws.WebService service = new ws.WebService();
                int id = Convert.ToInt32(Session["id"].ToString());
                Reservation[] reservations = service.getReservationByIdClient(id);
                GridView1.DataSource = reservations;
                GridView1.DataBind();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
        }
    }
}