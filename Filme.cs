using System;



namespace LPFilme
{


    public class Filme
    {
        // Atributos
        public int idFilme;
        public String titulo;
        public String dataLancamento;
        public String sinopse;
        public Double valorLococao;
        public int estoque;
        public int estAtual;
        public int locado;

        // Construtor
        public Filme(int idFilme, String titulo, String dataLanc, String sinopse, Double valorLoc, int estoque)
        {
            this.idFilme = idFilme;
            this.titulo = titulo;
            Filme filme1 = this;
            filme1.dataLancamento = dataLancamento;
            this.sinopse = sinopse;
            Filme filme = this;
            filme.valorLococao = valorLococao;
            this.estoque = estoque;
            this.locado = 0;
        }
        //Método com a Quantidade de Locações Realizadas
        public void filmeLocado()
        {
            this.locado += 1;
            this.estoque -= 1;
        }
        //Impressão Dados do Filme
        public void mostrarFilme()
        {
            Console.WriteLine("----------------------------FILME----------------------------------------------------------------------");
            Console.WriteLine($"--> Nº ID DO FILME: {idFilme}");
            Console.WriteLine($"-> TÍTULO:  {titulo}");
            Console.WriteLine($"-> DATA DE LANÇAMENTO: {dataLancamento}");
            Console.WriteLine($"-> SINOPSE: {sinopse}");
            Console.WriteLine($"-> VALOR DA LOCAÇÃO: R$  {valorLococao}");
            Console.WriteLine($"-> QTDE EM ESTOQUE: {estoque}");
            Console.WriteLine($"-> QTDE LOCAÇÕES: {locado}");
            Console.WriteLine($"-------------------------------------------------------------------------------------------------------");
        }
    }
}