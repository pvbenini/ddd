using System;
using System.Collections.Generic;
using System.Text;

namespace Conta.Domain.Excecoes
{
    /// <summary>
    /// Representa a base para geração de erros de regra de negócio gerados
    /// </summary>
    public abstract class RegrasBaseException : Exception
    {
        /// <summary>
        /// Inicializa uma nova instância para exceções de negócio
        /// </summary>
        public RegrasBaseException():base("Regra de negócios violada") { }
        /// <summary>
        /// Inicializa uma nova instância para exceções de negócio, informando uma mensagem
        /// </summary>
        /// <param name="mensagem">Mensagem sobre a exceção</param>
        public RegrasBaseException(string mensagem) : base(mensagem) { }
        /// <summary>
        /// Inicializa uma nova instância para exceções de negócio, informando uma mensagem e exceção interna
        /// </summary>
        /// <param name="mensagem">Mensagem sobre a exceção</param>
        /// <param name="innerException">Exceção interna que gerou a exceção de negócio</param>
        public RegrasBaseException(string mensagem, Exception innerException) : base(mensagem, innerException) { }
    }
}
