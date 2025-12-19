/*
*	<copyright file="AnimalFactory.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* <author>diogo</author>
* <date>19/12/2025</date>
**/

using System;

namespace ZooBO
{
    /// <summary>
    /// Classe estática responsável pela criação de instâncias de animais (Design Pattern: Factory Method).
    /// Centraliza a lógica de instanciação baseada numa string de tipo.
    /// </summary>
    public static class AnimalFactory
    {
        /// <summary>
        /// Cria um objeto animal com base no tipo fornecido.
        /// </summary>
        /// <param name="tipo">Tipo de animal ("mamifero", "ave", "reptil").</param>
        /// <param name="id">ID único.</param>
        /// <param name="nome">Nome.</param>
        /// <param name="dataNasc">Data de Nascimento.</param>
        /// <param name="detalhe">Informação extra (Pelo, Envergadura ou Escamas) em formato string.</param>
        /// <returns>Uma instância de uma classe derivada de <see cref="Animal"/>.</returns>
        /// <exception cref="Exception">Lançada se o tipo de animal for desconhecido.</exception>
        public static Animal CriarAnimal(string tipo, string id, string nome, DateTime dataNasc, string detalhe)
        {
            switch (tipo.ToLower())
            {
                case "mamifero":
                    return new Mamifero(id, nome, dataNasc, detalhe);
                case "ave":
                    // O parse deve ser protegido em ambiente real, simplificado para o exemplo
                    return new Ave(id, nome, dataNasc, double.Parse(detalhe));
                case "reptil":
                    return new Reptil(id, nome, dataNasc, bool.Parse(detalhe));
                default:
                    throw new Exception("A fábrica não conhece este tipo de animal.");
            }
        }
    }
}