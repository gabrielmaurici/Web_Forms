using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Data.Repository
{
    class RepositoryProduto : ReposCrud
    {
        public RepositoryProduto()
        {
            this.Lista = new List<BaseModel>();
            this.opCadastrar = CadProduto;
            this.opListar = ListarProdutos;
        }
        private void CadProduto(BaseModel produto)
        {
            Lista.Add(produto);
        }
        private List<BaseModel> ListarProdutos()
        {
            return Lista;
        }
    }
}
