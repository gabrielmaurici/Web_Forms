using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Data.Repository
{
    class RepositoryCategoria : ReposCrud
    {
        public RepositoryCategoria()
        {
            this.opCadastrar = CadCategoria;
            this.opListar = ListarCategorias;
        }
        private void CadCategoria(BaseModel categoria)
        {
            Lista.Add(categoria);
        }
        private List<BaseModel> ListarCategorias()
        {
            return Lista;
        }
    }
}
