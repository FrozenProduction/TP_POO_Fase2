/*
*	<copyright file="Alimentacao.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* <author>diogo</author>
* <date>19/12/2025</date>
**/

using System;

namespace ZooBO
{
    /// <summary>
    /// Representa uma tarefa de alimentação de um animal.
    /// </summary>
    [Serializable]
    public class Alimentacao : Tarefa
    {
        private string tipoComida;
        private string idAnimal;

        /// <summary>
        /// Inicializa uma nova tarefa de alimentação.
        /// </summary>
        /// <param name="data">Data do agendamento.</param>
        /// <param name="comida">Tipo de comida.</param>
        /// <param name="animal">ID do animal a alimentar.</param>
        public Alimentacao(DateTime data, string comida, string animal) : base(data)
        {
            tipoComida = comida;
            idAnimal = animal;
        }

        public override string Descricao() => $"Alimentação: {tipoComida} para o animal {idAnimal}.";
    }
}