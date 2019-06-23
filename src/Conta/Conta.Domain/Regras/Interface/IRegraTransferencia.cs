using Conta.Domain.Regras.Interface.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conta.Domain.Regras.Interface
{
    /// <summary>
    /// Registra as transferências entre contas
    /// </summary>
    public interface IRegraTransferencia : IRegraBase
    {
        /// <summary>
        /// Efetiva a transferencia
        /// </summary>
        void Preparar();
    }
}
