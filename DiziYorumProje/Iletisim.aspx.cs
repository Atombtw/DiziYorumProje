using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje
{
    public partial class Iletisim : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Tbl_Iletisim t = new Tbl_Iletisim();
            t.AdSoyad = TextBox1.Text;
            t.Mail = TextBox2.Text;
            t.Telefon = TextBox3.Text;
            t.Konu = TextBox4.Text;
            t.Mesaj = TextBox5.Text;
            db.Tbl_Iletisim.Add(t);
            db.SaveChanges();
        }
    }
}