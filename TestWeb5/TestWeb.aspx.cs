﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWeb5
{
    public partial class TestWeb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblShow.Text = DateTime.Now.ToString();
        }
    }
}