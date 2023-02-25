using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class YorumSil : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["YorumID"]);
            var t = db.Tbl_Yorum.Find(x);
            db.Tbl_Yorum.Remove(t);
            db.SaveChanges();
            Response.Redirect("Yorumlar.aspx");
        }
    }
}