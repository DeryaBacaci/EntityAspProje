using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje
{
    public partial class Logın : System.Web.UI.Page
    {
        Entities db = new Entities();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            //var sorgu = from x in db.TBLADMIN
            //            where x.KULLANICI == TxtKullaniciAdi.Text &&  x.SIFRE == TxtSifre.Text
            //            select x;
            //          if(sorgu.Any())
            //{
            //    Response.Redirect("Kategoriler.aspx");
            //}
            //          else
            //{
            //   TxtKullaniciAdi.Text=  ("Kullanıcı adı veya şifre hatalı");
            //}


            var model = db.TBLADMIN.FirstOrDefault(x => x.KULLANICI == TxtKullaniciAdi.Text && x.SIFRE == TxtSifre.Text);

            if(model!=null)
            {
                Session.Add("admin",TxtKullaniciAdi.Text);
                Response.Redirect("Kategoriler.aspx");
            }
            else
            {
                TxtKullaniciAdi.Text = "Hatalı Giriş";
                Response.Write("Kullanıcı adı veya Şifre Hatalı");
            }
        }
    }
}