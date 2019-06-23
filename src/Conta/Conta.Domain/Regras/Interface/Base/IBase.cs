using System;
using System.Collections.Generic;
using System.Text;

namespace Conta.Domain.Regras.Interface.Base
{
    /// <summary>
    /// Interface base para validação das operações
    /// </summary>
    public interface IRegraBase
    {
        /// <summary>
        /// Executa a validação da operação
        /// </summary>
        /// <returns></returns>
        bool Validar();
    }
}
