using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using wsDemo.model;

namespace demo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session != null)
            {
                if (HttpContext.Current.User.Identity.IsAuthenticated && Session["role"] == TypeUser.Client.ToString())
                {
                    Response.Redirect("Client.aspx");
                }
                else if (HttpContext.Current.User.Identity.IsAuthenticated && Session["role"] == TypeUser.Recepcionist.ToString())
                {
                    Response.Redirect("Receptionist.aspx");
                }
            }
            else
            {
                if (!Page.IsPostBack)
                {

                }
            }
        }
        protected void button_Click_Login(object sender, EventArgs e)
        {
            string user = txtUserName.Value.ToString();

            string password = txtUserPass.Value.ToString();

            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                password = BitConverter.ToString(data).Replace("-", string.Empty);
            }

            WebService service = new WebService();

            String userData = service.login(user, password);

            
        }
    }
}