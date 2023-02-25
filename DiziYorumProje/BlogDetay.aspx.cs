using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["BlogID"]);
            var blog = db.Tbl_Blog.Where(x => x.BlogID == id).ToList();
            Repeater1.DataSource = blog;
            Repeater1.DataBind();

            var yorumlar = db.Tbl_Yorum.Where(x => x.YorumBlog == id).ToList();
            Repeater2.DataSource = yorumlar;
            Repeater2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["BlogID"]);
            Tbl_Yorum t = new Tbl_Yorum();
            t.KullaniciAd = TextBox1.Text;
            t.Mail = TextBox2.Text;
            t.Yorum = TextBox3.Text;
            t.YorumBlog = id;
            db.Tbl_Yorum.Add(t);
            db.SaveChanges();
            Response.Redirect("BlogDetay.aspx?BlogID=" + id);
        }
    }
}