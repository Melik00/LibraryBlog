using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KutuphaneBlog.Entity;

namespace KutuphaneBlog
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        DboGemlikKitabevimEntities db = new DboGemlikKitabevimEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.TBL_BLOG.Count().ToString();
            Label2.Text = db.TBL_YORUM.Count().ToString();
            Label3.Text = db.TBL_BLOG.Where(x => x.BLOGTUR == 2).Count().ToString();
            Label4.Text = db.TBL_BLOG.Where(x => x.BLOGTUR == 3).Count().ToString();
            Label5.Text = db.TBL_BLOG.Where(x => x.BLOGTUR == 4).Count().ToString();
            Label6.Text = db.TBL_BLOG.Where(y=> y.BLOGID == db.TBL_YORUM.GroupBy(x => x.YORUMBLOG).OrderByDescending(x => x.Count()).Select(z => z.Key).FirstOrDefault()).Select(k=>k.BLOGBASLIK).FirstOrDefault();

        }
    }
}