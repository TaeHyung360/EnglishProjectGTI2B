﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.UI.HtmlControls;

using demo.ws;

namespace demo
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Guardamos la master page
            MasterPage master = (MasterPage)this.Master;
            //Tomamos el elemento html que queremos
            HtmlGenericControl heading = (HtmlGenericControl)master.FindControl("caption");

        }

        protected void button_Click_reservation(object sender, EventArgs e)
        {
            Response.Redirect("Contact.aspx");
        }

        /*
        protected void button_Click(object sender, EventArgs e)
        {

            WebService service = new WebService();

            string name = txtBox.Text;

            //Guardamos la master page
            MasterPage master = (MasterPage)this.Master;
            //Tomamos el elemento html que queremos
            HtmlGenericControl heading = (HtmlGenericControl)master.FindControl("caption");

            heading.InnerText = "Hola " + service.get(name).ToString();

        }
        */

    }
}