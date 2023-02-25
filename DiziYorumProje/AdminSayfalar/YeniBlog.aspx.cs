using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class YeniBlog : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                {

                }
                var t = (from x in db.Tbl_Tur
                         select new
                         {
                             x.TurAd,
                             x.TurID
                         }).ToList();
                DropDownList1.DataSource = t;
                DropDownList1.DataBind();

                var tt = (from x in db.Tbl_Kategori
                          select new
                          {
                              x.KategoriID,
                              x.KategoriAd
                          }).ToList();
                DropDownList2.DataSource = tt;
                DropDownList2.DataBind();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            
            Tbl_Blog t = new Tbl_Blog();
            t.BlogBaslik = TextBox1.Text;
            t.BlogTarih = DateTime.Parse(TextBox2.Text);
            t.BlogGorsel = TextBox3.Text;
            t.BlogTur = int.Parse(DropDownList1.SelectedValue);
            t.BlogKategori = int.Parse(DropDownList2.SelectedValue);
            db.Tbl_Blog.Add(t);
            db.SaveChanges();
            Response.Redirect("Bloglar.aspx");
        }
    }
}