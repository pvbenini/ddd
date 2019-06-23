using Conta.Domain.Regras.Interface.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conta.Domain.Regras.Interface
{
    /// <summary>
    /// Armazena os lançamentos entre contas
    /// </summary>
    public interface IRegraLancamento : IRegraBase
    {
        /// <summary>
        /// Registra informações da operação realizada
        /// </summary>
        /// <param name="descricao">Descrição da operação realizada</param>
        /// <param name="valor">Valor da operação realizada</param>
        void Adicionar(string descricao, decimal valor);
    }
}
