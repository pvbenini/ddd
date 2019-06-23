using Conta.Domain.Entidades;
using Conta.Domain.Entidades.Interface;
using Conta.Domain.Excecoes;
using Conta.Domain.Regras.Interface;

namespace Conta.Domain.Regras
{
    /// <summary>
    /// Registra as transferências entre contas
    /// </summary>
    public class RegraTransferencia : IRegraTransferencia
    {
        private readonly ITransferencia _transferencia;
        /// <summary>
        /// Inicializa uma instancia de validação dos dados de Transferencia
        /// </summary>
        /// <param name="transferencia">Instancia da entidade transferencia a ser validada</param>
        public RegraTransferencia(ITransferencia transferencia) {
            _transferencia = transferencia;
        }

        /// <summary>
        /// Efetiva a transferencia
        /// </summary>
        public void Preparar()
        {
            if (!Validar())
                throw new TransferenciaException("Não foi possível validar a transferência.");
            new RegraContaCorrente(_transferencia.Destino).AtualizarSaldo(_transferencia.Valor, $"Transferência recebida de {_transferencia.Origem.Numero:####-0} no valor {_transferencia.Valor:C}");
            new RegraContaCorrente(_transferencia.Origem).AtualizarSaldo(-_transferencia.Valor, $"Transferência enviada para {_transferencia.Destino.Numero:####-0} no valor {_transferencia.Valor:C}");
        }
        /// <summary>
        /// Valida a possibilidade de executar a transferencia utilizando o valor informado
        /// </summary>
        /// <returns>Verdadeiro se a transferencia for válida, se não falso</returns>
        public bool Validar()
        {
            return ValidarOrigem() && ValidarDestino() && ValidarValor();
        }

        private bool ValidarValor()
        {
            var sucesso = _transferencia.Valor > 0;
            if (!sucesso) return false;

            new RegraContaCorrente(_transferencia.Origem).AtualizarSaldo();
            sucesso = _transferencia.Origem.Saldo > _transferencia.Valor;
            return sucesso;
        }
        private bool ValidarDestino()
        {
            return ValidarConta(_transferencia.Destino);
        }
        private bool ValidarOrigem()
        {
            return ValidarConta(_transferencia.Origem);
        }
        private bool ValidarConta(IContaCorrente conta)
        {
            return new RegraContaCorrente(conta).Validar();
        }
    }
}

