using Conta.Domain.Entidades.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conta.Domain.Entidades
{
    /// <summary>
    /// Armazena os lançamentos entre contas
    /// </summary>
    public class Lancamento : ILancamento
    {
        /// <summary>
        /// Descrição da operação realizada
        /// </summary>
        public string Descricao { get; internal set; }
        /// <summary>
        /// Valor da operação realizada
        /// </summary>
        public decimal Valor { get; internal set; }
        /// <summary>
        /// Data da operação realizada
        /// </summary>
        public DateTime DataEventoUTC { get; internal set; }
    }
}
