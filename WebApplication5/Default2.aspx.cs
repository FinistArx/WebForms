﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class default2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MusikCentre mcObject = new MusikCentre(false, 100, 50);
            Session["MusikCentreKey"] = mcObject;
        }
    }
}