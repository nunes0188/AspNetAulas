using Aula01052017.Model;
using Aula01052017.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula01052017.View.Clientes {
    public partial class CadCliente : System.Web.UI.Page {
        BaseDadosClienteContainer contexto = new BaseDadosClienteContainer();
        TipoCliente tipoCliente = new TipoCliente();
        Cliente cliente;

        protected void Page_Load(object sender, EventArgs e) {

            if (!IsPostBack) {

                var categorias = contexto.TiposCliente;
                DLTipoCliente.DataValueField = "Id";
                DLTipoCliente.DataTextField = "Tipo";

                DLTipoCliente.DataSource = categorias.ToList();
                DLTipoCliente.DataBind();

                if (Session["CliId"] != null) {


                    cliente = contexto.Clientes.Find((int)Session["CliId"]);

                    TxtNome.Text = cliente.Nome;
                    TxtSNome.Text = cliente.SobreNome;
                    TxtCPF.Text = cliente.CPF;
                    TxtEndereco.Text = cliente.endereco;
                    DLTipoCliente.SelectedValue = cliente.TipoClienteId.ToString();
                }
            }
        }

        protected void BtnSalvar_Click(object sender, EventArgs e) {

            if (Session["CliId"] != null) {

                cliente = contexto.Clientes.Find((int)Session["CliId"]);
                try {
                    cliente.Nome = TxtNome.Text;
                    cliente.SobreNome = TxtSNome.Text;
                    cliente.CPF = TxtCPF.Text;
                    cliente.endereco = TxtEndereco.Text;
                    cliente.TipoClienteId = Convert.ToInt32(DLTipoCliente.SelectedValue);

                    contexto.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                    contexto.SaveChanges();

                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Erro", "<script>alert('Alterado com Sucesso');</script>", false);

                    Session.RemoveAll();
                    Response.Redirect("ListaCliente.aspx");

                } catch {

                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Erro", "<script>alert('Não foi possível Alterar');</script>", false);


                }

            } else {
                try {

                    Cliente clientes = new Cliente {
                        Nome = TxtNome.Text,
                        SobreNome = TxtSNome.Text,
                        CPF = TxtCPF.Text,
                        endereco = TxtEndereco.Text,
                        TipoClienteId = Convert.ToInt32(DLTipoCliente.SelectedValue),

                    };


                    contexto.Clientes.Add(clientes);
                    contexto.SaveChanges();

                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Erro", "<script>alert('Cadastrado com Sucesso');</script>", false);

                    Response.Redirect("CadCliente.aspx");

                } catch {

                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Erro", "<script>alert('Não foi possível cadastrar');</script>", false);

                }
            }
        }

        protected void BtnCancelar_Click(object sender, EventArgs e) {

            Response.Redirect("CadCliente.aspx");

        }
    }
}