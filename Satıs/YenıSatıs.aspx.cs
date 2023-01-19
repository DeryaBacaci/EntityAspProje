using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Satıs
{
    public partial class YenıSatıs : System.Web.UI.Page
    {
        Entities db = new Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                var urun = (from x
                                   in db.TBLURUNLER
                                   select new
                                   {
                                       x.URUNID,
                                       x.URUNAD
                                   }).ToList();
                DropDownList1.DataTextField = "URUNAD";
                DropDownList1.DataValueField = "URUNID";
                DropDownList1.DataSource = urun;
                DropDownList1.DataBind();

                var mus = (from x
                                   in db.TBLMUSTERI
                                   select new
                                   {
                                       x.MUSTERIID,
                               MUSTERITAMAD= x.MUSTERIAD+" "+x.MUSTERISOYAD
                                   }).ToList();
                DropDownList2.DataTextField = "MUSTERITAMAD";
                DropDownList2.DataValueField = "MUSTERIID";
                DropDownList2.DataSource = mus;
                DropDownList2.DataBind();


                var per = (from x
                                  in db.TBLPERSONEL
                            select new
                            {
                                x.PERSONELID,
                                x.PERSONELADSOYAD
                            }).ToList();
                DropDownList3.DataTextField = "PERSONELADSOYAD";
                DropDownList3.DataValueField = "PERSONELID";
                DropDownList3.DataSource = per;
                DropDownList3.DataBind();


            }
        }

        protected void BtnYenıSatıs_Click(object sender, EventArgs e)
        {
            TBLSATIS t = new TBLSATIS();
            t.MUSTERI= int.Parse(DropDownList2.SelectedValue);
            t.URUN = int.Parse(DropDownList1.SelectedValue);
            t.PERSONEL = byte.Parse(DropDownList3.SelectedValue);
            t.FIYAT = decimal.Parse(TxtFıyat.Text);
            db.TBLSATIS.Add(t);
            db.SaveChanges();
            Response.Redirect("Satıslar.aspx");
        }
    }
}