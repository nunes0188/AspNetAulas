using Aula01052017.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula01052017.View.Categorias {
    public partial class ListaCategoria : System.Web.UI.Page {

        BaseDadosClienteContainer contexto = new BaseDadosClienteContainer();
        TipoCliente categoria;

        protected void Page_Load(object sender, EventArgs e) {


            var categorias = contexto.TiposCliente;

            gvCategorias.DataSource = categorias.ToList();
            gvCategorias.DataBind();
        }

        protected void gvCategorias_RowCommand(object sender, GridViewCommandEventArgs e) {
            // Detectando a linha que foi clicada
            int linha = Convert.ToInt32(e.CommandArgument);

            // Recuperando o id do Objeto (lembrando que 2, do Cells[2], é a coluna onde esta o id)
            int idObjeto = Convert.ToInt32(gvCategorias.Rows[linha].Cells[2].Text);

            // Nome do comando para saber a acao
            string command = e.CommandName;

            // Proximos passos

            // adicionar id na Session

            if (command.Equals("Excluir")) {


                try {
                    categoria = contexto.TiposCliente.FirstOrDefault(x => x.Id.Equals(idObjeto));
                    contexto.TiposCliente.Remove(categoria);
                    contexto.SaveChanges();

                    Response.Redirect("ListaCategoria.aspx");

                } catch (Exception) {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Erro", "<script>alert('Não foi possível excluir');</script>", false);
                }

                // Redirecionando para tela de exclusao

            } else {
                if (command.Equals("Editar")) {

                    categoria = contexto.TiposCliente.FirstOrDefault(x => x.Id.Equals(idObjeto));
                    // Redirecionando para tela de edicao

                    Session["CatId"] = categoria.Id;

                    Response.Redirect("CadCategoria.aspx");
                }
            }
        }
    }
}