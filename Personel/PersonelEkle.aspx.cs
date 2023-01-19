using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Personel
{
    public partial class PersonelEkle : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Entities db = new Entities();
            TBLPERSONEL p = new TBLPERSONEL();
            p.PERSONELADSOYAD = TxtPrAD.Text;
            db.TBLPERSONEL.Add(p);
            db.SaveChanges();
            Response.Redirect("Personeller.aspx");

        }
    }
}