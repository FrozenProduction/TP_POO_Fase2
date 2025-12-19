/*
*	<copyright file="Animal.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* <author>diogo</author>
* <date>19/12/2025</date>
**/

using System;

namespace ZooBO
{
    /// <summary>
    /// Classe base abstrata que representa um animal genérico no jardim zoológico.
    /// <br/>
    /// Define os atributos e métodos comuns a todas as espécies.
    /// </summary>
    [Serializable]
    public abstract class Animal
    {
        #region Atributos
        /// <summary> Identificador único do animal. </summary>
        private string id;
        /// <summary> Nome do animal. </summary>
        private string nome;
        /// <summary> Data de nascimento do animal. </summary>
        private DateTime dataNascimento;
        #endregion

        #region Propriedades
        /// <summary>
        /// Obtém ou define o identificador único do animal.
        /// </summary>
        public string Id { get => id; set => id = value; }

        /// <summary>
        /// Obtém ou define o nome do animal.
        /// </summary>
        public string Nome { get => nome; set => nome = value; }

        /// <summary>
        /// Obtém ou define a data de nascimento.
        /// </summary>
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }

        /// <summary>
        /// Calcula a idade do animal com base na data atual.
        /// </summary>
        public int Idade => DateTime.Today.Year - dataNascimento.Year;
        #endregion

        #region Construtores
        /// <summary>
        /// Construtor base para inicializar um animal.
        /// </summary>
        /// <param name="id">Identificador único.</param>
        /// <param name="nome">Nome do animal.</param>
        /// <param name="dataNascimento">Data de nascimento.</param>
        protected Animal(string id, string nome, DateTime dataNascimento)
        {
            this.id = id;
            this.nome = nome;
            this.dataNascimento = dataNascimento;
        }
        #endregion

        #region Métodos Abstratos
        /// <summary>
        /// Obtém a descrição da dieta alimentar do animal.
        /// Deve ser implementado pelas classes derivadas.
        /// </summary>
        /// <returns>String com a dieta.</returns>
        public abstract string GetDieta();

        /// <summary>
        /// Obtém uma string formatada com as informações principais do animal.
        /// </summary>
        /// <returns>String informativa.</returns>
        public abstract string GetInfo();
        #endregion
    }
}