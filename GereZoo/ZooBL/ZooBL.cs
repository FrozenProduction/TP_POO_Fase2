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
    /// Camada de Lógica de Negócio (Business Logic Layer).
    /// Faz a ponte entre a UI e a BD, aplicando validações e regras.
    /// </summary>
    public class ZooBL
    {
        /// <summary>
        /// Valida e insere um novo animal.
        /// Verifica se o animal é nulo e se o ID já existe (usando LINQ).
        /// </summary>
        /// <param name="a">O animal a inserir.</param>
        /// <returns>True se inserido com sucesso.</returns>
        /// <exception cref="AnimalException">Lançada se os dados forem inválidos.</exception>
        public static bool InserirAnimal(Animal a)
        {
            if (a == null)
                throw new AnimalException("O objeto animal não pode ser nulo.");

            // Acesso ao Singleton da DB
            var animaisExistentes = ZooDB.ZooDB.Instance.ObterAnimais();

            // Validação LINQ para duplicados
            if (animaisExistentes.Any(x => x.Id == a.Id))
            {
                throw new AnimalException($"Já existe um animal com o ID {a.Id}.");
            }

            return ZooDB.ZooDB.Instance.InserirAnimal(a);
        }

        /// <summary>
        /// Obtém a lista completa de animais.
        /// </summary>
        public static List<Animal> ListarTodosAnimais()
        {
            return ZooDB.ZooDB.Instance.ObterAnimais();
        }

        /// <summary>
        /// Solicita a gravação dos dados em disco.
        /// </summary>
        public static bool GravarAnimais(string ficheiro)
        {
            return ZooDB.ZooDB.Instance.GuardarDados(ficheiro);
        }

        /// <summary>
        /// Solicita o carregamento dos dados do disco.
        /// </summary>
        public static bool LerAnimais(string ficheiro)
        {
            return ZooDB.ZooDB.Instance.CarregarDados(ficheiro);
        }
    }
}