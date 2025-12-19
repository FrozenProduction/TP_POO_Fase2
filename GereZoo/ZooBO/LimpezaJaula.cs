/*
*	<copyright file="LimpezaJaula.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* <author>diogo</author>
* <date>19/12/2025</date>
**/

using System;

namespace ZooBO
{
    /// <summary>
    /// Representa uma tarefa de limpeza de um setor ou jaula.
    /// </summary>
    [Serializable]
    public class LimpezaJaula : Tarefa
    {
        private string setor;

        /// <summary>
        /// Inicializa uma nova tarefa de limpeza.
        /// </summary>
        /// <param name="data">Data do agendamento.</param>
        /// <param name="setor">Nome do setor a limpar.</param>
        public LimpezaJaula(DateTime data, string setor) : base(data)
        {
            this.setor = setor;
        }

        public override string Descricao() => $"Limpeza da Jaula no Setor: {setor}";
    }
}