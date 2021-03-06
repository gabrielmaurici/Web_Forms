using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Data.Repository
{
    public delegate void Operacao(BaseModel model);
    public delegate List<BaseModel> OperacaoListar();
    public class ReposCrud
    {
        public List<BaseModel> Lista { get; set; }
        protected Operacao opCadastrar;
        protected OperacaoListar opListar;

        public void Cadastrar(BaseModel model)
        {
            opCadastrar(model);
        }
        public List<BaseModel> Listar()
        {
            return opListar();
        }
    }
}
