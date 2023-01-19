﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje
{
    public partial class Kategoriler : System.Web.UI.Page
    {
        Entities db=new Entities();

        protected void Page_Load(object sender, EventArgs e)
        {
            var degerler = db.TBLKATEGORI.ToList();
            Repeater1.DataSource= degerler;
            Repeater1.DataBind();
        }
    }
}