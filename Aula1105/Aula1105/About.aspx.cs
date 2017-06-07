﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula1105 {
    public partial class About : Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                txtData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e) {
            txtData.Text = calDataInicio.SelectedDate.ToString("dd/MM/yyyy");
        }
    }
}