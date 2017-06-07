using Aula250517.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula250517.View.Produtos {
    public partial class ListaProdutos : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {


            BaseContainer contexto = new BaseContainer();

            var produtos = contexto.Produtos;

            gvProdutos.DataSource = produtos.ToList();
            gvProdutos.DataBind();

        }
    }
}