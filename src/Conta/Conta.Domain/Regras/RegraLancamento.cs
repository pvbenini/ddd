using Conta.Domain.Entidades;
using Conta.Domain.Entidades.Interface;
using Conta.Domain.Regras.Interface;
using System;

namespace Conta.Domain.Regras
{
    /// <summary>
    /// Armazena os lançamentos entre contas
    /// </summary>
    public class RegraLancamento : IRegraLancamento
    {
        private Lancamento _lancamento;
        /// <summary>
        /// Inicializa uma instancia de validação dos dados de Conta orrente
        /// </summary>
        /// <param name="lancamento">Instancia da entidade lancamento a ser validada</param>
        public RegraLancamento(ILancamento lancamento)
        {
            _lancamento = (Lancamento)lancamento;
        }

        /// <summary>
        /// Registra informações da operação realizada
        /// </summary>
        /// <param name="descricao">Descrição da operação realizada</param>
        /// <param name="valor">Valor da operação realizada</param>
        public void Adicionar(string descricao, decimal valor)
        {
            _lancamento.Descricao = descricao;
            _lancamento.Valor = valor;
            _lancamento.DataEventoUTC = DateTime.UtcNow;
        }
        /// <summary>
        /// Valida os dados para registrar os lançamentos
        /// </summary>
        /// <returns></returns>
        public bool Validar()
        {
            return String.IsNullOrEmpty(_lancamento.Descricao) && _lancamento.Valor != 0M;
        }
    }
}
