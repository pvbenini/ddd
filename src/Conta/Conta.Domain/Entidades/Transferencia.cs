using Conta.Domain.Entidades.Interface;

namespace Conta.Domain.Entidades
{
    /// <summary>
    /// Registra as transferências entre contas
    /// </summary>
    public class Transferencia : ITransferencia
    {

        /// <summary>
        /// Conta corrente de origem da transferencia
        /// </summary>
        public IContaCorrente Origem { get; set; }
        /// <summary>
        /// Conta corrente de destino da transferencia
        /// </summary>
        public IContaCorrente Destino { get; set; }
        /// <summary>
        /// Valor da transferencia
        /// </summary>
        public decimal Valor { get; set; }
    }
}

