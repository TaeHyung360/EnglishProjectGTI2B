using System;
using System.Security.Cryptography;
using System.Text;

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
                ws.WebService service = new ws.WebService();
                String typeUser = service.login(user, password);
                if (typeUser.Equals("1"))
                {
                    Response.Redirect("client/client.aspx");
                }
                else if (typeUser.Equals("2"))
                {
                    Response.Redirect("receptionist/receptionist.aspx");
                }
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc);
            }
        }
    }
}