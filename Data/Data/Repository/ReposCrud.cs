using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Data.Repository
{
    public delegate void Operacao();
    class ReposCrud
    {
        protected List<BaseModel> lista = new List<BaseModel>();
        protected Operacao opCadastrar;
        protected Operacao opListar;

        public void Cadastrar()
        {
            opCadastrar();
        }
        puvlic void Listar()
        {
            opListar();
        }
    }
}
