# 🦁 Gestão de Jardim Zoológico - Fase 2 (N-Tier)

Este repositório contém o trabalho prático (Fase 2) desenvolvido para a Unidade Curricular de **Programação Orientada a Objetos (POO)**.

**Instituição:** Instituto Politécnico do Cávado e do Ave (IPCA)
**Curso:** Licenciatura em Engenharia de Sistemas Informáticos
**Autor:** Diogo (utilizador: frozenproduction)

---

## 🎯 Objetivo da Fase 2

Enquanto a Fase 1 focou na modelação de classes, esta **Fase 2** tem como objetivo a reestruturação completa do projeto para uma **Arquitetura Profissional em Camadas (N-Tier)**, garantindo a separação de responsabilidades, a persistência de dados e a aplicação de Padrões de Desenho avançados.

## 🚀 Funcionalidades e Conceitos Implementados

* **Arquitetura N-Tier:** Separação rigorosa entre Apresentação, Lógica de Negócio, Acesso a Dados e Objetos.
* **Persistência de Dados:** Implementação de leitura e escrita de ficheiros binários (`.bin`) para que os dados não se percam.
* **Design Patterns:**
    * **Singleton:** Utilizado na camada de dados (`ZooDB`) para garantir uma instância única da base de dados em memória.
    * **Factory Method:** Utilizado (`AnimalFactory`) para instanciar animais dinamicamente sem acoplamento.
* **LINQ e Lambdas:** Utilizados para pesquisas e validações eficientes de listas.
* **Tratamento de Exceções:** Criação de exceções personalizadas (`AnimalException`).
* **Polimorfismo:** Gestão de diferentes tipos de animais (`Mamifero`, `Ave`, `Reptil`) e tarefas.
* **Membros Estáticos:** Gestão de contadores globais na venda de Bilhetes.

## 📂 Estrutura da Solução (N-Tier)

A solução `GereZoo` está dividida em 5 projetos distintos para garantir o desacoplamento:

| Projeto / Camada | Tipo | Descrição |
| :--- | :--- | :--- |
| **`ZooBO`** (Business Objects) | Lib | Contém as classes base (`Animal`, `Tarefa`, `Bilhete`). São objetos anémicos (apenas dados). |
| **`ZooDB`** (Data Layer) | Lib | Implementa o **Singleton**. Gere as listas em memória e a gravação/leitura do ficheiro binário. |
| **`ZooBL`** (Business Logic) | Lib | Contém as regras de negócio e validações (ex: verifica se ID duplicado via **LINQ**) antes de chamar a BD. |
| **`Excepcoes`** | Lib | Biblioteca dedicada a erros personalizados do projeto. |
| **`GereZoo`** (Presentation) | Exe | Aplicação de Consola. Interage com o utilizador e chama apenas a camada de Regras (`ZooBL`). |

Também inclui a pasta:
* **`Relatorio_POO_Fase2`**: Contém o relatório técnico desenvolvido em **LaTeX**, documentando a arquitetura e as decisões tomadas.

## 🛠️ Tecnologias

* C# (.NET Framework)
* Visual Studio 2022
* Serialização Binária
* LaTeX (Documentação)

## 📦 Como Executar

1.  Clone este repositório.
2.  Abra o ficheiro `GereZoo.sln` no Visual Studio.
3.  Defina o projeto **`GereZoo`** como **"Set as StartUp Project"**.
4.  Compile e execute (F5).
    * *Nota: Na primeira execução, o programa criará automaticamente um ficheiro de dados e animais de teste.*

---
**Nota Final:** Trabalho avaliado no âmbito da disciplina de POO (2º Ano).
