using Aula230517.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula230517.View.Base {
    public class BasePage : System.Web.UI.Page{
        //protected serve para a classe pai e as filhas.

        protected LojaDbEntities contexto = new LojaDbEntities();



    }
}