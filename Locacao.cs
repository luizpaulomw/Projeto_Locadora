using System;
using LPFilme;
using System.Collections.Generic;


namespace Prova
{
    public class Locacao
    {
        // Atributos
        public int idLoc = 0;
        public Cliente cliente;
        public String dataLoc;
        public String dataDevolucao;
        public Double valorTotal;
        public int filmesLocados;

        // Lista de Filmes
        public List<Filme> filmes = new List<Filme>();

        // Inicio
        public Locacao(int idLoc, Cliente cliente)
        {

            this.idLoc = idLoc;
            this.cliente = cliente;

            this.cliente.adicionarLocacao(this);
        }

        // Cadastro de Filmes
        public void AdicFilme(Filme filme)
        {
            this.filmes.Add(filme);
            //Contador locaçã de filme

        }

        // Valor Total das Locações
        public double PrecoTotal()
        {
            double total = 0;
            foreach (Filme filme in filmes)
            {
                total += filme.valorLocacao;
            }
            return total;
        }

        // Quantidade de Filmes Locados
        public int QtdeFilmesLoc()
        {
            return this.filmes.Count;
        }

        // Data de Devolução 
        public String calculoData()
        {
            DateTime dataAtual = DateTime.Now;
			return dataAtual.AddDays(cliente.diaDev).ToString("MM/dd/yyyy h:mm tt");
        }
    }
}