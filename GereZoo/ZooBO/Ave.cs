/*
*	<copyright file="Ave.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* <author>diogo</author>
* <date>19/12/2025</date>
**/

using System;

namespace ZooBO
{
    /// <summary>
    /// Representa um animal do tipo Ave.
    /// Herda de <see cref="Animal"/>.
    /// </summary>
    [Serializable]
    public class Ave : Animal
    {
        private double envergaduraAsas;

        /// <summary>
        /// Obtém ou define a envergadura das asas em metros.
        /// </summary>
        public double EnvergaduraAsas { get => envergaduraAsas; set => envergaduraAsas = value; }

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="Ave"/>.
        /// </summary>
        /// <param name="id">ID do animal.</param>
        /// <param name="nome">Nome.</param>
        /// <param name="dataNasc">Data de nascimento.</param>
        /// <param name="envergadura">Tamanho das asas (metros).</param>
        public Ave(string id, string nome, DateTime dataNasc, double envergadura)
            : base(id, nome, dataNasc)
        {
            this.envergaduraAsas = envergadura;
        }

        /// <summary>
        /// Define a dieta específica para aves.
        /// </summary>
        public override string GetDieta() => "Sementes, Fruta e Insetos.";

        /// <summary>
        /// Retorna a informação detalhada da ave.
        /// </summary>
        public override string GetInfo() =>
            $"[Ave] ID: {Id} | Nome: {Nome} | Idade: {Idade} | Envergadura: {envergaduraAsas}m";
    }
}