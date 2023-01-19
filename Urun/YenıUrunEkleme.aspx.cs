using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Urun
{
    public partial class YenıUrunEkleme : System.Web.UI.Page
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
            }
        }

        protected void BtnUrunEkle_Click(object sender, EventArgs e)
        {


            TBLURUNLER t = new TBLURUNLER();
            t.URUNAD = TxtUrunAd.Text;
            t.URUNSTOK = short.Parse(TxtStok.Text);
            t.URUNMARKA = TxtUrunMarka.Text;
            t.URUNFIYAT = decimal.Parse(TxtFıyat.Text);
            t.URUNKATEGORI = byte.Parse(DropDownList1.SelectedValue.ToString());
            t.DURUM = true;
            //TxtFıyat.Text = DropDownList1.SelectedValue;
            db.TBLURUNLER.Add(t);
            db.SaveChanges();
            Response.Redirect("Urunler.aspx");
        }
    }
}