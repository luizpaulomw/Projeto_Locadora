using System;
using System.Collections.Generic;


namespace Prova
{
    public class Cliente
    {
        
        public int idCliente;
        public String nome;
        public String dataNasc;
        public String cpf;
        public int diaDev;
        public int filmesLocados;
        public List<Locacao> locacoes = new List<Locacao>();

        // Inicio de tudo 
        public Cliente(int idCliente, String nome, String dataNasc, String cpf, int diaDev)
        {

            this.idCliente = idCliente;
            this.nome = nome;
            this.dataNasc = dataNasc;
            this.cpf = cpf;
            this.diaDev = diaDev;
            this.filmesLocados = 0;
        }

        //  Quantidade de Filmes Locados
        public int qtdeFilmeLocados(int filmesLocados)
        {
            return this.filmesLocados = filmesLocados;
        }
        // Dados dos Clientes
        public void mostrarCliente()
        {
            Console.WriteLine("----------------CLIENTE----------------");
            Console.WriteLine("--> Nº ID DO CLIENTE: " + idCliente);
            Console.WriteLine("-> NOME COMPLETO: " + nome);
            Console.WriteLine("-> DATA DE NASCIMENTO: " + dataNasc);
            Console.WriteLine("-> CPF: " + cpf);
            Console.WriteLine("-> DIAS P/ DEVOLUÇÃO: " + diaDev);
            Console.WriteLine("-> QTDE TOTAL DE LOCAÇÕES: " + filmesLocados);
            Console.WriteLine("----------------------------------------");
        }
        // Locações 
        public void adicionarLocacao(Locacao locacao)
        {
            this.locacoes.Add(locacao);
        }

        //Lista de locações
        public int getlocacoes()
        {
            int qtd = 0;

            foreach (Locacao locacao in this.locacoes)
            {
                foreach (LPFilme.Filme filme in locacao.filmes)
                {
                    qtd++;
                }
            }
            return qtd;
        }
    }
}