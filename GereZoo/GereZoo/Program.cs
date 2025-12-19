/*
*	<copyright file="Program.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* <author>diogo</author>
* <date>19/12/2025</date>
**/

using System;
using System.Collections.Generic;
using ZooBO;
using ZooBL;
using Excepcoes;

namespace GereZoo
{
    /// <summary>
    /// Classe principal da aplicação (Frontend/UI).
    /// Interage com o utilizador e chama a camada de regras (ZooBL).
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string ficheiro = "dadosZoo.bin";
            Console.WriteLine("=== GESTÃO DO ZOOLÓGICO (Fase 2 - N-Tier) ===\n");

            try
            {
                // 1. Carregar dados existentes
                if (ZooBL.ZooBL.LerAnimais(ficheiro))
                    Console.WriteLine("-> Dados carregados do ficheiro.");
                else
                    Console.WriteLine("-> Base de dados iniciada vazia.");

                // 2. Se vazio, criar dados de teste com FACTORY
                if (ZooBL.ZooBL.ListarTodosAnimais().Count == 0)
                {
                    Console.WriteLine("-> A criar animais de teste...");
                    Animal m = AnimalFactory.CriarAnimal("mamifero", "M01", "Simba", DateTime.Now, "Dourado");
                    Animal a = AnimalFactory.CriarAnimal("ave", "A01", "Zazu", DateTime.Now, "0,5");
                    Animal r = AnimalFactory.CriarAnimal("reptil", "R01", "Kaa", DateTime.Now, "true"); // true = tem escamas

                    ZooBL.ZooBL.InserirAnimal(m);
                    ZooBL.ZooBL.InserirAnimal(a);
                    ZooBL.ZooBL.InserirAnimal(r);
                }

                // 3. Simular Venda de Bilhetes (Membros Estáticos)
                Bilhete b1 = new Bilhete(15.0);
                Bilhete b2 = new Bilhete(10.0);
                Console.WriteLine($"\n[Bilheteira] Total Vendido: {Bilhete.TotalVendidos} | Receita: {Bilhete.TotalValorArrecadado}€");

                // 4. Listar Animais
                Console.WriteLine("\n--- LISTA DE ANIMAIS ---");
                List<Animal> lista = ZooBL.ZooBL.ListarTodosAnimais();
                foreach (Animal ani in lista)
                {
                    Console.WriteLine(ani.GetInfo());
                }

                // 5. Guardar ao sair
                ZooBL.ZooBL.GravarAnimais(ficheiro);
                Console.WriteLine("\n-> Dados guardados com sucesso.");

            }
            catch (AnimalException ex)
            {
                Console.WriteLine($"\n[ERRO DE NEGÓCIO]: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n[ERRO CRÍTICO]: {ex.Message}");
            }

            Console.WriteLine("\nPrime qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}