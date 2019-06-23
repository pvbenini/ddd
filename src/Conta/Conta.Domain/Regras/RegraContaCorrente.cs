using System;
using System.Collections.Generic;
using System.Linq;
using Conta.Domain.Entidades;
using Conta.Domain.Entidades.Interface;
using Conta.Domain.Excecoes;
using Conta.Domain.Regras.Interface;

namespace Conta.Domain.Regras
{
    /// <summary>
    /// Responsável pelos dados de Conta Corrente
    /// </summary>
    public class RegraContaCorrente : IRegraContaCorrente
    {
        private readonly IContaCorrente _contaCorrente;
        /// <summary>
        /// Inicializa uma instancia de validação dos dados de Conta Corrente
        /// </summary>
        /// <param name="contaCorrente">Instancia da entidade de conta corrente a ser validada</param>
        public RegraContaCorrente(IContaCorrente contaCorrente)
        {
            _contaCorrente = contaCorrente;
        }

        /// <summary>
        /// Simples validação para número verificador de conta
        /// </summary>
        /// <returns>Verdadeiro, quando o número verificador é válido, se não falso</returns>
        public bool Validar()
        {
            if (string.IsNullOrEmpty(_contaCorrente.Numero))
                throw new ArgumentOutOfRangeException("numero", "numero inválido");
            int verificador = int.Parse(_contaCorrente.Numero.Substring(_contaCorrente.Numero.Length - 1));
            int soma = 0;
            Array.ForEach(_contaCorrente.Numero.ToCharArray(), c => soma = int.Parse(c.ToString()));
            if (int.Equals(soma, verificador))
                return true;
            return false;
        }
        /// <summary>
        /// Atualizar saldo na conta corrente
        /// </summary>
        public void AtualizarSaldo()
        {
            AtualizarSaldo(decimal.Zero);
        }
        /// <summary>
        /// Atualizar saldo de conta corrente
        /// </summary>
        /// <param name="valor">Valor a ser adicionado à conta corrente</param>
        public void AtualizarSaldo(decimal valor)
        {
            if (!Validar()) throw new ContaCorrenteException("Não foi possível atualizar o saldo da Conta Corrente.");
            _contaCorrente.Saldo += valor;
            //TODO: Salvar saldo em memória
        }
        /// <summary>
        /// Atualiza saldo de conta corrente
        /// </summary>
        /// <param name="valor">Valor a ser adicionado à conta corrente</param>
        /// <param name="descricao">Descrição adicionada ao evento de atualização de conta</param>
        public void AtualizarSaldo(decimal valor, string descrição)
        {
            Lancamento lancamento;

            var regraLancamento = new RegraLancamento(lancamento = new Lancamento());
            regraLancamento.Adicionar(string.IsNullOrEmpty(descrição) ? "Transferência entre contas" : descrição, valor);

            if (_contaCorrente.Lancamentos == null)
                _contaCorrente.Lancamentos = new List<Lancamento>();
            else
                _contaCorrente.Lancamentos.Add(lancamento);

            AtualizarSaldo(valor);
        }
    }
}
