using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aula01052017.Model;

namespace Aula01052017.Controller {
    public class Categoria {

        private static BaseDadosClienteContainer contexto = new BaseDadosClienteContainer();



        //Retorna um cliente pelo nome exato.
        public static TipoCliente BuscarCategoriaNome(string categoria) {
            return contexto.TiposCliente.FirstOrDefault(x => x.Tipo.Equals(categoria));
        }


    }
}