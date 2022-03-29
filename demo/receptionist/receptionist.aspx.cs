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
        Reservation[] reservations;
        int reservationId;
        int idReceptionist;
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            try
            {
                ws.WebService service = new ws.WebService();
                idReceptionist = Convert.ToInt32(Session["id"].ToString());
                reservations = service.getReservationByIdReceptionist(idReceptionist);
                if (Session["idRes"] != null)
                {
                    id = Convert.ToInt32(Session["idRes"].ToString());
                }
                
                if (ListBoxReservations.Items.Count == 0)
                {
                    foreach (Reservation reservation in reservations)
                    {
                        ListBoxReservations.Items.Add(reservation.Name);
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
        }

        protected void ButtonSelect_Click(object sender, EventArgs e)
        {
            if (ListBoxReservations.SelectedItem != null)
            {
                Reservation res = getReservationSelectedListBox();
                Session["idRes"] = res.Id;
                ResIdClient.Text = res.IdClient.ToString();
                // ResIdReceptionist.Text = reservation.IdRecepcionist.ToString();
                ResRoom.Text = res.Room.ID.ToString();
                ResName.Text = res.Name.ToString();
                ResArrivalDate.Text = res.ArrivalDate.ToString();
                ResNights.Text = res.Nights.ToString();
               
            }
        }

        private Reservation getReservationSelectedListBox()
        {
            foreach (Reservation reservation in reservations)
            {
                if (reservation.Name == ListBoxReservations.SelectedItem.ToString())
                {
                    return reservation;
                }
            }

            return null;
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                
                ws.WebService service = new ws.WebService();
                int idClient = Int32.Parse(ResIdClient.Text);
                string room = ResRoom.Text;
                string name = ResName.Text;
                string arrivalDate = ResArrivalDate.Text;
                int nights = Int32.Parse(ResNights.Text);
                bool res = service.updateReservation(id, idClient, room, name, arrivalDate, nights);
                if (res == true)
                {
                    stateInfo.Text = "Update book is complete";
                    Page.Response.Redirect(Page.Request.Url.ToString());
                }
                else
                {
                    stateInfo.Text = "ERROR updating book";
                }

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
                stateInfo.Text = "ERROR updating book";
            }
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {

                ws.WebService service = new ws.WebService();
                
                bool res = service.deleteReservation(id);
                if (res == true)
                {
                    stateInfo.Text = "Delete book is complete";
                    Page.Response.Redirect(Page.Request.Url.ToString());
                }
                else
                {
                    stateInfo.Text = "ERROR in delete book";
                }

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
                stateInfo.Text = "ERROR in delete book";
            }
        }

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                
                    ws.WebService service = new ws.WebService();
                    int idClient = Int32.Parse(ResIdClient.Text);
                    string room = ResRoom.Text;
                    string name = ResName.Text;
                    string arrivalDate = ResArrivalDate.Text;
                    int nights = Int32.Parse(ResNights.Text);
                    bool res = service.addReservation(idClient, idReceptionist, room, name, arrivalDate, nights);
                    if (res == true)
                    {
                        stateInfo.Text = "Add book is complete";
                        Page.Response.Redirect(Page.Request.Url.ToString());
                    }
                    else
                    {
                        stateInfo.Text = "ERROR adding book";
                    }
                
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
                stateInfo.Text = "ERROR adding book";
            }
        }
    }
}