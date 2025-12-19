/*
*	<copyright file="Mamifero.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* <author>diogo</author>
* <date>19/12/2025</date>
**/

using System;

namespace ZooBO
{
    /// <summary>
    /// Representa um animal do tipo Mamífero.
    /// Herda de <see cref="Animal"/>.
    /// </summary>
    [Serializable]
    public class Mamifero : Animal
    {
        private string tipoPelo;

        /// <summary>
        /// Obtém ou define o tipo de pelo do mamífero.
        /// </summary>
        public string TipoPelo { get => tipoPelo; set => tipoPelo = value; }

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="Mamifero"/>.
        /// </summary>
        /// <param name="id">ID do animal.</param>
        /// <param name="nome">Nome.</param>
        /// <param name="dataNasc">Data de nascimento.</param>
        /// <param name="pelo">Descrição do tipo de pelo.</param>
        public Mamifero(string id, string nome, DateTime dataNasc, string pelo)
            : base(id, nome, dataNasc)
        {
            this.tipoPelo = pelo;
        }

        /// <summary>
        /// Define a dieta específica para mamíferos.
        /// </summary>
        public override string GetDieta() => "Ração para Mamíferos e Carne.";

        /// <summary>
        /// Retorna a informação detalhada do mamífero.
        /// </summary>
        public override string GetInfo() =>
            $"[Mamífero] ID: {Id} | Nome: {Nome} | Idade: {Idade} | Pelo: {TipoPelo}";
    }
}