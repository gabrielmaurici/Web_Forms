﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data.Models;
using Data.Repository;

namespace CadastroWebForms
{
    public partial class CadastroProdutoForms : System.Web.UI.Page
    {

        public RepositoryProduto RepoProduto { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //Criar lista Session
        }

        protected void btSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            //fazer cadastro

        }
    }
}