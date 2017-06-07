using Aula01052017.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula01052017.View.Clientes {
    public partial class ListaCliente : System.Web.UI.Page {
        BaseDadosClienteContainer contexto = new BaseDadosClienteContainer();

        Cliente cliente;
 

        protected void Page_Load(object sender, EventArgs e) {


            var clientes = contexto.Clientes;

            gvClientes.DataSource = clientes.ToList();
            gvClientes.DataBind();
        }

        protected void gvClientes_RowCommand(object sender, GridViewCommandEventArgs e) {
           
            // Detectando a linha que foi clicada
            int linha = Convert.ToInt32(e.CommandArgument);

            // Recuperando o id do Objeto (lembrando que 2, do Cells[2], é a coluna onde esta o id)
            int idObjeto = Convert.ToInt32(gvClientes.Rows[linha].Cells[2].Text);

            // Nome do comando para saber a acao
            string command = e.CommandName;

            // Proximos passos

            // adicionar id na Session

            if (command.Equals("Excluir")) {


                try {
                    cliente = contexto.Clientes.FirstOrDefault(x => x.Id.Equals(idObjeto));
                    contexto.Clientes.Remove(cliente);
                    contexto.SaveChanges();

                    Response.Redirect("ListaCliente.aspx");

                } catch (Exception) {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Erro", "<script>alert('Não foi possível excluir');</script>", false);
                }

                // Redirecionando para tela de exclusao

            } else {
                if (command.Equals("Editar")) {
                    cliente = contexto.Clientes.FirstOrDefault(x => x.Id.Equals(idObjeto));
                    // Redirecionando para tela de edicao

                    Session["CliId"] = cliente.Id;

                    Response.Redirect("CadCliente.aspx");
                }
            }
        }
    }
}