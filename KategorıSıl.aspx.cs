using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje
{
    public partial class KategorıSıl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Entities db = new Entities();
            int x = Convert.ToInt32(Request.QueryString["KATEGORIID"]);
            var p = db.TBLKATEGORI.Find(x);
            db.TBLKATEGORI.Remove(p);
            db.SaveChanges();
            Response.Redirect("Kategoriler.aspx");
        }
    }
}