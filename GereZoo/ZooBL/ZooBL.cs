/*
*	<copyright file="ZooBL.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* <author>diogo</author>
* <date>19/12/2025</date>
**/

using System;
using System.Collections.Generic;
using System.Linq;
using ZooBO;
using ZooDB;
using Excepcoes;

namespace ZooBL
{
    /// <summary>
    /// Camada de Regras de Negócio (Business Logic Layer).
    /// Responsável por validar dados antes de interagir com a base de dados.
    /// Aplica o padrão Singleton através da chamada à ZooDB.
    /// </summary>
    public class ZooBL
    {
        /// <summary>
        /// Tenta inserir um novo animal no sistema.
        /// Verifica se o objeto é nulo e se o ID já existe (regra de unicidade).
        /// </summary>
        /// <param name="a">Objeto animal a inserir.</param>
        /// <returns>Verdadeiro se inserido com sucesso.</returns>
        /// <exception cref="AnimalException">Lançada caso o ID já exista.</exception>
        public static bool InserirAnimal(Animal a)
        {
            if (a == null) throw new AnimalException("O animal não pode ser nulo.");

            // Validação com LINQ: Verifica se algum animal na lista tem o mesmo ID
            if (ZooDB.ZooDB.Instance.ObterAnimais().Any(x => x.Id == a.Id))
            {
                throw new AnimalException($"Erro de Negócio: O ID '{a.Id}' já está a ser utilizado.");
            }

            return ZooDB.ZooDB.Instance.InserirAnimal(a);
        }

        /// <summary>
        /// Obtém a lista completa de animais registados.
        /// </summary>
        public static List<Animal> ListarTodosAnimais()
        {
            return ZooDB.ZooDB.Instance.ObterAnimais();
        }

        /// <summary>
        /// Persistência: Grava os dados em ficheiro binário.
        /// </summary>
        public static bool GravarAnimais(string ficheiro)
        {
            return ZooDB.ZooDB.Instance.GuardarDados(ficheiro);
        }

        /// <summary>
        /// Persistência: Carrega os dados do ficheiro binário.
        /// </summary>
        public static bool LerAnimais(string ficheiro)
        {
            return ZooDB.ZooDB.Instance.CarregarDados(ficheiro);
        }
    }
}