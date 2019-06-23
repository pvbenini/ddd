using System;
using System.Collections.Generic;
using System.Text;

namespace Conta.Domain.Excecoes
{
    /// <summary>
    /// Representa os erros gerados na validação da conta corrente
    /// </summary>
    public class ContaCorrenteException : RegrasBaseException
    {
        /// <summary>
        /// Inicializa uma nova instância da <see cref="ContaCorrenteException"/> 
        /// </summary>
        public ContaCorrenteException() : this("Conta corrente não atende aos prérequisitos.") { }
        /// <summary>
        /// Inicializa uma nova instância da <see cref="ContaCorrenteException"/>, com uma mensagem de erro específica
        /// </summary>
        public ContaCorrenteException(string mensagem) : base(mensagem) { }
    }
}
