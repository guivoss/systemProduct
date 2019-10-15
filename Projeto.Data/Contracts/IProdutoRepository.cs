using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Data.Entities; //importando as entidades

namespace Projeto.Data.Contracts
{
    public interface IProdutoRepository : IBaseRepository<Produto>
    {
        List<Produto> ObterPorNome(string nome);

    }
}
