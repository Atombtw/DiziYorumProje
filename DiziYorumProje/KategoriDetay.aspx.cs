using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje
{
    public partial class KategoriDetay : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["KategoriID"]);

            var bloglar = db.Tbl_Blog.Where(z => z.BlogKategori == x).ToList();
            Repeater1.DataSource = bloglar;
            Repeater1.DataBind();

            var kategoriler = db.Tbl_Kategori.ToList();
            Repeater2.DataSource = kategoriler;
            Repeater2.DataBind();

            Repeater3.DataSource = db.Tbl_Blog.OrderByDescending(z => z.BlogID).Take(5).ToList();
            Repeater3.DataBind();

            Repeater4.DataSource = db.Tbl_Yorum.OrderByDescending(z => z.YorumID).Take(5).ToList();
            Repeater4.DataBind();
        }
    }
}