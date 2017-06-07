using Aula01052017.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula01052017.View.Categorias {
    public partial class CadCategoria : System.Web.UI.Page {
        BaseDadosClienteContainer contexto = new BaseDadosClienteContainer();
        TipoCliente categoria;

        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {

                if (Session["CatId"] != null) {


                    categoria = contexto.TiposCliente.Find((int)Session["CatId"]);

                    TxtTipo.Text = categoria.Tipo;
                    TxtDescricao.Text = categoria.Descricao;
                }

            }
        }

        protected void BtnSalvar_Click(object sender, EventArgs e) {

            if (Session["CatId"] != null) {

                categoria = contexto.TiposCliente.Find((int)Session["CatId"]);
                try {
                    categoria.Tipo = TxtTipo.Text;
                    categoria.Descricao = TxtDescricao.Text;

                    contexto.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
                    contexto.SaveChanges();

                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Erro", "<script>alert('Alterado com Sucesso');</script>", false);

                    Session.RemoveAll();
                    Response.Redirect("ListaCategoria.aspx");

                } catch {

                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Erro", "<script>alert('Não foi possível Alterar');</script>", false);


                }

            } else {

                try {
                    TipoCliente categorias = new TipoCliente {
                        Tipo = TxtTipo.Text,
                        Descricao = TxtDescricao.Text,

                    };

                    contexto.TiposCliente.Add(categorias);
                    contexto.SaveChanges();
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Erro", "<script>alert('Cadastrado com Sucesso');</script>", false);

                    Response.Redirect("CadCategoria.aspx");
                } catch {

                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Erro", "<script>alert('Não foi possível cadastrar');</script>", false);

                }
            }

        }

        protected void BtnCancelar_Click(object sender, EventArgs e) {

            Response.Redirect("CadCategoria.aspx");
        }
    }
}