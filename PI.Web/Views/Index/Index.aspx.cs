﻿using System;

namespace PI.Web.Views.Index
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string stEmail = string.Empty;
            if (!IsPostBack)
            {
                if (Request.QueryString["stEmail"] != null)
                    stEmail = Request.QueryString["stEmail"].ToString();

                //ALT + 126
                iCuenta.ImageUrl = "~/Images/" + Session["sessionEmail"].ToString() + ".jpg";
            }
        }
    }
}