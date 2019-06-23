using Conta.Domain.Entidades.Interface;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Conta.Domain.Entidades
{
    /// <summary>
    /// Responsável pelos dados de Conta Corrente
    /// </summary>
    public class ContaCorrente : IContaCorrente
    {
        private string _numero;
        
        /// <summary>
        /// Número da conta
        /// </summary>
        public string Numero { get { return _numero; } set { _numero = Regex.Replace(value, "[^.0-9]", string.Empty); } }
        /// <summary>
        /// Saldo remanecente
        /// </summary>
        public decimal Saldo { get; set; }
        /// <summary>
        /// Histórico de lancamentos da conta corrente
        /// </summary>
        public IList<Lancamento> Lancamentos { get; set; }
    }
}
