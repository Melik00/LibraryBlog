using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KutuphaneBlog.Entity;

namespace KutuphaneBlog
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        DboGemlikKitabevimEntities db = new DboGemlikKitabevimEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write(Session["KULLANICI"].ToString());
            if (Session["KULLANICI"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
            else
            {
                Response.Write("Hoş Geldiniz: " + Session["KULLANICI"].ToString());
            }
            Repeater1.DataSource = db.TBL_BLOG.ToList();
            Repeater1.DataBind();
        }
    }
}