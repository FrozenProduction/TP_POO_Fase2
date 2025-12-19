/*
*	<copyright file="Tarefa.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* <author>diogo</author>
* <date>19/12/2025</date>
**/

using System;

namespace ZooBO
{
    /// <summary>
    /// Classe base abstrata para tarefas agendadas no Zoo.
    /// </summary>
    [Serializable]
    public abstract class Tarefa
    {
        private DateTime dataAgendada;
        private bool concluida;

        /// <summary> Data e hora para a qual a tarefa está marcada. </summary>
        public DateTime DataAgendada { get => dataAgendada; set => dataAgendada = value; }

        /// <summary> Estado da tarefa (se já foi realizada). </summary>
        public bool Concluida { get => concluida; set => concluida = value; }

        /// <summary>
        /// Construtor base para tarefas.
        /// </summary>
        /// <param name="data">Data do agendamento.</param>
        protected Tarefa(DateTime data)
        {
            dataAgendada = data;
            concluida = false;
        }

        /// <summary>
        /// Retorna a descrição da tarefa.
        /// </summary>
        public abstract string Descricao();
    }
}