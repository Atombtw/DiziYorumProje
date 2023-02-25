using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class BlogGuncelle : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["BlogID"]);
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

                var deger = db.Tbl_Blog.Find(y);
                TextBox1.Text = deger.BlogBaslik;
                TextBox2.Text = deger.BlogTarih.ToString();
                TextBox4.Text = deger.BlogIcerik;
                TextBox3.Text = deger.BlogGorsel;
                DropDownList1.SelectedValue = deger.BlogTur.ToString();
                DropDownList2.SelectedValue = deger.BlogKategori.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["BlogID"]);
            var deger = db.Tbl_Blog.Find(y);
            deger.BlogBaslik = TextBox1.Text;
            deger.BlogTarih = DateTime.Parse(TextBox2.Text);
            deger.BlogIcerik = TextBox4.Text;
            deger.BlogGorsel = TextBox3.Text;
            deger.BlogTur = int.Parse(DropDownList1.SelectedValue);
            deger.BlogKategori = int.Parse(DropDownList2.SelectedValue);
            db.SaveChanges();
            Response.Redirect("Bloglar.aspx");
        }
    }
}