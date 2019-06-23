using Conta.Domain.Entidades.Interface.Base;

namespace Conta.Domain.Entidades.Interface
{
    /// <summary>
    /// Registra as transferências entre contas
    /// </summary>
    public interface ITransferencia : IEntidadeBase
    {
        /// <summary>
        /// Conta corrente de origem da transferencia
        /// </summary>
        IContaCorrente Origem { get; set; }
        /// <summary>
        /// Conta corrente de destino da transferencia
        /// </summary>
        IContaCorrente Destino { get; set; }
        /// <summary>
        /// Valor da transferencia
        /// </summary>
        decimal Valor { get; set; }

    }
}
