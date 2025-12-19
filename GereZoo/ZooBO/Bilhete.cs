/*
*	<copyright file="Bilhete.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* <author>diogo</author>
* <date>19/12/2025</date>
**/

using System;

namespace ZooBO
{
    /// <summary>
    /// Representa um bilhete de entrada.
    /// Demonstra o uso de membros estáticos (static) para contabilidade global.
    /// </summary>
    [Serializable]
    public class Bilhete
    {
        #region Membros Estáticos
        private static int totalVendidos = 0;
        private static double totalValorArrecadado = 0;

        /// <summary> Devolve o total de bilhetes vendidos desde o início da execução. </summary>
        public static int TotalVendidos => totalVendidos;
        /// <summary> Devolve o valor total arrecadado em euros. </summary>
        public static double TotalValorArrecadado => totalValorArrecadado;
        #endregion

        #region Atributos de Instância
        private int id;
        private double preco;
        #endregion

        /// <summary>
        /// Emite um novo bilhete e atualiza os contadores globais.
        /// </summary>
        /// <param name="valor">Custo do bilhete.</param>
        public Bilhete(double valor)
        {
            totalVendidos++;
            totalValorArrecadado += valor;

            this.id = totalVendidos;
            this.preco = valor;
        }

        /// <summary> Informação do bilhete. </summary>
        public string Info() => $"Bilhete #{id} | Custo: {preco}€";
    }
}