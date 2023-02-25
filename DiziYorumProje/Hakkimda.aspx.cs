using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziYorumProje.Entity;

namespace DiziYorumProje
{
    public partial class Hakkimda : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var hakkimizda = db.Tbl_Hakkımızda.ToList();
            Repeater1.DataSource = hakkimizda;
            Repeater1.DataBind();
        }
    }
}