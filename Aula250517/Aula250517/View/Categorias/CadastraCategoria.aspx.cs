using Aula250517.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula250517.View.Categorias {
    public partial class CadastraCategoria : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void BtnSalvar_Click(object sender, EventArgs e) {

            BaseContainer contexto = new BaseContainer();

            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Erro", "<script>alert('Não foi possível cadastrar');</script>", false);
            try {
                Categoria categorias = new Categoria {
                    Nome = TxtNome.Text,
                    Descricao = TxtDescricao.Text,
                    Ativo = ChkAtivo.Checked,

                };
                contexto.Categorias.Add(categorias);
                contexto.SaveChanges();

            } catch {

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Erro", "<script>alert('Não foi possível cadastrar');</script>", false);
               
            }
        }

        }
    }