using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Urun
{
    public partial class UrunGuncelle : System.Web.UI.Page
    {
        Entities db = new Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                var kategorısec = (from x in db.TBLKATEGORI select new { x.KATEGORIID, x.KATEGORIAD }).ToList();
                DropDownList1.DataTextField = "KATEGORIAD";
                DropDownList1.DataValueField = "KATEGORIID";
                DropDownList1.DataSource = kategorısec;
                DropDownList1.DataBind();


                int id = Convert.ToInt32(Request.QueryString["URUNID"]);
                var p = db.TBLURUNLER.Find(id);
                TxtUrunAd.Text = p.URUNAD;
                TxtStok.Text = p.URUNSTOK.ToString();
                TxtUrunMarka.Text = p.URUNMARKA;
                TxtFıyat.Text = p.URUNFIYAT.ToString();
                DropDownList1.SelectedValue=p.URUNKATEGORI.ToString();  
            }
        }

        protected void BtnUrunGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["URUNID"]);
            var P = db.TBLURUNLER.Find(id);
            P.URUNAD = TxtUrunAd.Text;
            P.URUNSTOK = short.Parse(TxtStok.Text);
            P.URUNMARKA = TxtUrunMarka.Text;
            P.URUNFIYAT = decimal.Parse(TxtFıyat.Text);
            P.URUNKATEGORI =byte.Parse(DropDownList1.SelectedValue.ToString());
            db.SaveChanges();
            Response.Redirect("Urunler.aspx");
        }
    }
}