﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KutuphaneBlog.Entity;


namespace KutuphaneBlog
{
    public partial class WebForm13 : System.Web.UI.Page
    {
        DboGemlikKitabevimEntities db = new DboGemlikKitabevimEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["KATEGORIID"]);
            var kitaplar = db.TBL_BLOG.Where(x => x.BLOGKATEGORI == id).ToList();
            Repeater1.DataSource = kitaplar;
            Repeater1.DataBind();

            var kategoriler = db.TBL_KATEGORI.ToList();
            Repeater2.DataSource = kategoriler;
            Repeater2.DataBind();

            var enson = db.TBL_BLOG.ToList();
            Repeater3.DataSource = enson;
            Repeater3.DataBind();
        }
    }
}