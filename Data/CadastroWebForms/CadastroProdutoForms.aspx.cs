using System;
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
            RepoProduto = new RepositoryProduto();

            if(Session["RepoProduto"] == null)
            {
                Session.Add("RepoProduto", new RepositoryProduto());
            }

            RepoProduto = (RepositoryProduto)Session["RepoProduto"];
            CarregaDados();
        }

        protected void btSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            Categoria categoria = new Categoria();

            produto.Id = RepoProduto.Lista.Count + 1;
            produto.Nome = tbNome.Text;
            produto.Valor = Convert.ToDecimal(tbValor.Text);

            categoria.Nome = tbNomeCategoria.Text;
            categoria.Descricao = tbDescCategoria.Text;

            produto.Categoria = categoria;

            this.RepoProduto.Cadastrar(produto);
            
            CarregaDados();
        }

        protected void btLimpar_Click(object sender, EventArgs e)
        {
            tbNome.Text = String.Empty;
            tbValor.Text = String.Empty;

            tbNomeCategoria.Text = String.Empty;
            tbDescCategoria.Text = String.Empty;

            CarregaDados();
        }
        public void CarregaDados()
        {
            gvCadastros.DataSource = this.RepoProduto.Listar();
            gvCadastros.DataBind();
        }
    }
}