using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class Yorumlar : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var t = (from x in db.Tbl_Yorum
                     select new
                     {
                         x.YorumID,
                         x.KullaniciAd,
                         x.Tbl_Blog.BlogBaslik,
                         x.Yorum
                     }).ToList();
            Repeater1.DataSource = t;
            Repeater1.DataBind();
        }
    }
}