﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProje.Entity;

namespace EntityAspProje.LinquKartlar
{
    public partial class Istatıstık : System.Web.UI.Page
    {
        Entities db = new Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.TBLURUNLER.Count().ToString();
            Label2.Text=db.TBLMUSTERI.Count().ToString();
            Label3.Text=db.TBLSATIS.Sum(x=>x.FIYAT).ToString();
            Label4.Text = db.TBLURUNLER.Count().ToString();
            Label5.Text = db.TBLURUNLER.Count(x=>x.DURUM==true).ToString();
            Label6.Text = db.TBLURUNLER.Count(x => x.DURUM == false).ToString();
            Label7.Text = (from x in db.TBLURUNLER orderby x.URUNSTOK descending select x.URUNAD).FirstOrDefault();


        }
    }
}