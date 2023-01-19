using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.Personel
{
    public partial class Personeller : System.Web.UI.Page
    {
        Entities db = new Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var personell = db.TBLPERSONEL.ToList();
            Repeater1.DataSource = personell;
            Repeater1.DataBind();
        }
    }
}