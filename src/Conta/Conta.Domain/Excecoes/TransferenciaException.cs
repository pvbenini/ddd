using System;
using System.Collections.Generic;
using System.Text;

namespace Conta.Domain.Excecoes
{
    /// <summary>
    /// Representa os erros gerados durante uma transferência
    /// </summary>
    public class TransferenciaException:RegrasBaseException
    {
        /// <summary>
        /// Inicializa uma nova instância da <see cref="TransferenciaException"/> 
        /// </summary>
        public TransferenciaException():this("Transferencia não atende aos prérequisitos.") { }
        /// <summary>
        /// Inicializa uma nova instância da <see cref="TransferenciaException"/>, com uma mensagem de erro específica
        /// </summary>
        public TransferenciaException(string mensagem) : base(mensagem) { }
    }
}
