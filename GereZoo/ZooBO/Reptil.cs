/*
*	<copyright file="Reptil.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* <author>diogo</author>
* <date>19/12/2025</date>
**/

using System;

namespace ZooBO
{
    /// <summary>
    /// Representa um animal do tipo Réptil.
    /// Herda de <see cref="Animal"/>.
    /// </summary>
    [Serializable]
    public class Reptil : Animal
    {
        private bool temEscamas;

        /// <summary>
        /// Indica se o réptil possui escamas visíveis.
        /// </summary>
        public bool TemEscamas { get => temEscamas; set => temEscamas = value; }

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="Reptil"/>.
        /// </summary>
        /// <param name="id">ID do animal.</param>
        /// <param name="nome">Nome.</param>
        /// <param name="dataNasc">Data de nascimento.</param>
        /// <param name="escamas">True se tem escamas, False caso contrário.</param>
        public Reptil(string id, string nome, DateTime dataNasc, bool escamas)
            : base(id, nome, dataNasc)
        {
            this.temEscamas = escamas;
        }

        /// <summary>
        /// Define a dieta específica para répteis.
        /// </summary>
        public override string GetDieta() => "Insetos, Pequenos Roedores ou Vegetais.";

        /// <summary>
        /// Retorna a informação detalhada do réptil.
        /// </summary>
        public override string GetInfo() =>
            $"[Réptil] ID: {Id} | Nome: {Nome} | Escamas: {(temEscamas ? "Sim" : "Não")}";
    }
}