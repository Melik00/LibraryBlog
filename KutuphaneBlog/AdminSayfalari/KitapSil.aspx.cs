using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KutuphaneBlog.Entity;


namespace KutuphaneBlog
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        DboGemlikKitabevimEntities db = new DboGemlikKitabevimEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["BLOGID"]);
            var kitap = db.TBL_BLOG.Find(x);
            db.TBL_BLOG.Remove(kitap);
            db.SaveChanges();
            Response.Redirect("Kitaplar.aspx");

        }
    }
}