/*
*	<copyright file="ZooBL.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* <author>diogo</author>
* <date>19/12/2025</date>
**/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZooBO;
using ZooBL;
using Excepcoes;

namespace ZooTests
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        public void TestarInsercaoAnimalValido()
        {
            // Arrange (Preparar)
            Animal a = AnimalFactory.CriarAnimal("mamifero", "T01", "Teste", DateTime.Now, "Pelo Curto");

            // Act (Agir)
            bool resultado = ZooBL.ZooBL.InserirAnimal(a);

            // Assert (Verificar)
            Assert.IsTrue(resultado, "O animal devia ter sido inserido com sucesso.");
        }

        [TestMethod]
        [ExpectedException(typeof(AnimalException))]
        public void TestarInsercaoIDDuplicado()
        {
            // O T01 já foi inserido no teste anterior ou na persistência? 
            // Para testes unitários isolados, idealmente limpamos a DB, 
            // mas aqui vamos tentar inserir dois iguais seguidos para forçar o erro.

            Animal a1 = AnimalFactory.CriarAnimal("ave", "DUP01", "Pato", DateTime.Now, "10");
            Animal a2 = AnimalFactory.CriarAnimal("ave", "DUP01", "Pato Gemeo", DateTime.Now, "10");

            ZooBL.ZooBL.InserirAnimal(a1);
            ZooBL.ZooBL.InserirAnimal(a2); // Isto deve lançar AnimalException
        }
    }
}