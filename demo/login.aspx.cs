using System;
using System.Security.Cryptography;
using System.Text;
using System.Web.Security;
using demo.ws;

namespace demo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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

            try
            {
                WebService service = new WebService();

             
                var userObj = service.login(user, password);

                if (userObj != null)
                {

                    Session["id"] = userObj.Id;
                    Session["name"] = userObj.Name;
                    Session["role"] = userObj.Type.ToString();
                    Session.Timeout = 20;

                    if (userObj.Type == TypeUser.Client)
                    {
                        FormsAuthentication.SetAuthCookie(userObj.Type.ToString(), true);
                        Response.Redirect("client/client.aspx");
                    }
                    else if (userObj.Type == TypeUser.Receptionist)
                    {
                        FormsAuthentication.SetAuthCookie(userObj.Type.ToString(), true);
                        Response.Redirect("receptionist/receptionist.aspx");
                    }
                    else
                    {
                        Warninglogin.Text = "Please enter a valid username and password";
                    }
                }

            }
            catch(Exception exc)
            {
                Console.WriteLine(exc);
            }
        }
    }
}