using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje
{
    public partial class KategorıGuncelle : System.Web.UI.Page
    {
        Entities db = new Entities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                int id = Convert.ToInt32(Request.QueryString["KATEGORIID"]);
                txtıd.Text = id.ToString();
                var ktgr = db.TBLKATEGORI.Find(id);
                txtad.Text = ktgr.KATEGORIAD.ToString();
            }
        }

        protected void BtnKtgrGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["KATEGORIID"]);
            var ktgr = db.TBLKATEGORI.Find(id);
            ktgr.KATEGORIAD=txtad.Text;
            db.SaveChanges();
            Response.Redirect("Kategoriler.aspx");
        }
    }
}