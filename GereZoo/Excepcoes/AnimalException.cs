/*
*	<copyright file="AnimalException.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* <author>diogo</author>
* <date>19/12/2025</date>
**/

using System;

namespace Excepcoes
{
    /// <summary>
    /// Exceção personalizada para erros relacionados com a gestão de animais.
    /// </summary>
    [Serializable]
    public class AnimalException : Exception
    {
        /// <summary>
        /// Inicializa uma nova instância da exceção.
        /// </summary>
        public AnimalException() : base("Ocorreu um erro com o animal.") { }

        /// <summary>
        /// Inicializa a exceção com uma mensagem específica.
        /// </summary>
        /// <param name="message">A mensagem de erro.</param>
        public AnimalException(string message) : base(message) { }

        /// <summary>
        /// Inicializa a exceção com uma mensagem e a causa original (inner exception).
        /// </summary>
        public AnimalException(string message, Exception inner) : base(message, inner) { }
    }
}