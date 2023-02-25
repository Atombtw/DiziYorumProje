using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class Hakkimizda : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = 1;
            var deger = db.Tbl_Hakkımızda.Find(id);
            TextBox4.Text = deger.Aciklama;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var deger = db.Tbl_Hakkımızda.Find(1);
            deger.Aciklama = TextBox1.Text;
            db.SaveChanges();
            Response.Redirect("Hakkimizda.aspx");
        }
    }
}