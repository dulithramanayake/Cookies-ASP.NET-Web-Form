using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookies
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BUtton1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("Name", "Dulith");
            cookie.Expires = DateTime.Now.AddSeconds(10);
            //cookie.Expires=DateTime.MaxValue;
            Response.Cookies.Add(cookie);
            Response.Redirect("WebForm2.aspx");
        }
    }
}