using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace AspNetWebFormsSample
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string con = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string con = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            //string key1 = ConfigurationManager.AppSettings["Test1"];
            string key2 = ConfigurationManager.AppSettings["TestKey"];
            string key3 = ConfigurationManager.AppSettings["Test"];

        }
    }
}