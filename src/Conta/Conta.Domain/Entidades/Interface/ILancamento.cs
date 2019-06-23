using Conta.Domain.Entidades.Interface.Base;
using System;

namespace Conta.Domain.Entidades.Interface
{
    /// <summary>
    /// Armazena os lançamentos entre contas
    /// </summary>
    public interface ILancamento : IEntidadeBase
    {
        /// <summary>
        /// Descrição da operação realizada
        /// </summary>
        string Descricao { get; }
        /// <summary>
        /// Valor da operação realizada
        /// </summary>
        decimal Valor { get; }
        /// <summary>
        /// Data da operação realizada
        /// </summary>
        DateTime DataEventoUTC { get; }
    }
}
