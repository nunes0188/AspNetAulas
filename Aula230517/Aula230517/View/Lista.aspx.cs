using Aula230517.View.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula230517 {
    public partial class Lista : BasePage {
        protected void Page_Load(object sender, EventArgs e) {

            gvCategorias.DataSource = contexto.Categoria.ToList();

            gvCategorias.DataBind();
        }
    }
}