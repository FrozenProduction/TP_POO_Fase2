/*
*	<copyright file="ZooDB.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* <author>diogo</author>
* <date>19/12/2025</date>
**/

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using ZooBO;

namespace ZooDB
{
    /// <summary>
    /// Camada de Acesso a Dados (DAO).
    /// Implementa o padrão Singleton para garantir uma única instância dos dados em memória.
    /// Responsável pela persistência em ficheiro binário.
    /// </summary>
    public class ZooDB
    {
        #region Singleton
        private static ZooDB instance;
        private List<Animal> listaAnimais;
        // Poderias adicionar List<Tarefa> aqui também

        /// <summary>
        /// Construtor privado para impedir instâncias externas.
        /// </summary>
        private ZooDB()
        {
            listaAnimais = new List<Animal>();
        }

        /// <summary>
        /// Propriedade estática que devolve a única instância da base de dados (Lazy Load).
        /// </summary>
        public static ZooDB Instance
        {
            get
            {
                if (instance == null) instance = new ZooDB();
                return instance;
            }
        }
        #endregion

        #region Gestão de Listas
        /// <summary>
        /// Adiciona um animal à lista em memória.
        /// </summary>
        /// <param name="a">Objeto animal.</param>
        /// <returns>True se inserido.</returns>
        public bool InserirAnimal(Animal a)
        {
            listaAnimais.Add(a);
            return true;
        }

        /// <summary>
        /// Retorna uma cópia rasa da lista de animais.
        /// </summary>
        public List<Animal> ObterAnimais()
        {
            return new List<Animal>(listaAnimais);
        }
        #endregion

        #region Persistência
        /// <summary>
        /// Serializa a lista de animais para um ficheiro binário.
        /// </summary>
        /// <param name="caminho">Caminho do ficheiro.</param>
        public bool GuardarDados(string caminho)
        {
            try
            {
                using (FileStream fs = new FileStream(caminho, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, listaAnimais);
                    return true;
                }
            }
            catch (Exception)
            {
                // Em ambiente real, fazer log do erro
                return false;
            }
        }

        /// <summary>
        /// Desserializa a lista de animais de um ficheiro binário.
        /// </summary>
        /// <param name="caminho">Caminho do ficheiro.</param>
        public bool CarregarDados(string caminho)
        {
            if (!File.Exists(caminho)) return false;

            try
            {
                using (FileStream fs = new FileStream(caminho, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    listaAnimais = (List<Animal>)bf.Deserialize(fs);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
    }
}