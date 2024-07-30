using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KutuphaneBlog.Entity;


namespace KutuphaneBlog
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        DboGemlikKitabevimEntities db = new DboGemlikKitabevimEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var kitaplar = db.TBL_BLOG.ToList();
            Repeater1.DataSource = kitaplar;
            Repeater1.DataBind();
        }
    }
}