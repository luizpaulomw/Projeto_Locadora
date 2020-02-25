using System;
using LPFilme;




namespace Prova
{



    public class Principal
    {

        static void Main(String[] args)
        {


            Console.WriteLine("LuizPaulo\n   ");

            // Lista de Clientes
            Cliente cliente1 = new Cliente(1, "Pamela wormsbecker", "5/3/1994", "198.554.568.99", 3);
            Cliente cliente2 = new Cliente(2, "Amanda Wormsbecker", "13/08/1985", "558.899.745.55", 2);
            Cliente cliente3 = new Cliente(3, "Emanuelle Wormsbecker", "02/01/1998", "998.235.100.88", 3);
            Cliente cliente4 = new Cliente(4, "Paraides Cabral", "11/09/1947", "789.221.124.22", 2);
            Cliente cliente5 = new Cliente(5, "Carlos Wormsbecker", "04/02/1958", "548.666.254.01", 3);

            // Lista de Filmes
            Filme filme1 = new Filme(1, "A Identidade Bourne", "2002",
                    "A história do desmemoriado agente Bourne mereceu uma sequência de filmes, mas nenhum se compara ao primeiro. Jason Bourne, interpretado por Matt Damon, é um homem que perdeu a memória depois de levar um tiro. ",
                    4.5, 5);
            Filme filme2 = new Filme(2, "Os Mercenários", "2010",
                    "O encontro das grandes estrelas dos filmes de ação dos anos 1980 e 1990 pode ser considerado um encontro de titãs de primeira categoria. Sylvester Stallone, Jason Statham, Jet Li, Dolph Lundgren, Randy Couture, Terry Crews, Mickey Rourke, Bruce Willis e Arnold Schwarzenegger, todos juntos em um só filme, é de transbordar testosterona da tela.",
                    3.5, 3);
            Filme filme3 = new Filme(3, "Atômica ", "2017",
                    "Mais uma história em quadrinhos que ganhou as telas. Atômica traz Charlize Theron como uma agente secreta que precisa usar todos os seus recursos para impedir que uma lista de agentes duplos seja revelada, causando o fim de diversas operações. ",
                    2.5, 2);
            Filme filme4 = new Filme(4, "007 – Operação Skyfall ", "2012",
                    "O terceiro filme a ter Daniel Craig como intérprete do mais famoso espião de todos os tempos, é também o qual celebra 50 anos da trajetória de James Bond nos cinemas. Além disso, também resgata as histórias mais antigas e as combina com a franquia recente.",
                    2.5, 1);
            Filme filme5 = new Filme(5, "Indiana Jones e Os Caçadores da Arca Perdida", "1981",
                    "Vencedor de 4 Oscars, o primeiro filme da saga Indiana Jones é sem dúvida o mais memorável.",
                    3.5, 2);
            Filme filme6 = new Filme(6, "Duro de Matar", "1988",
                    "O filme que transformou Bruce Willis no cara em que você confiaria a sua vida sem pestanejar. O policial John McClane vai visitar a esposa durante a festa de natal da empresa onde ela trabalha.",
                    2.5, 2);
            Filme filme7 = new Filme(7, "Tropa de Elite ", "2007",
                    "O nosso representante brasileiro foi o primeiro filme de ficção dirigido por José Padilha e trouxe muitas críticas à sociedade brasileira para as telas, o que gerou uma grande repercussão na mídia e no debate do dia a dia das pessoas.",
                    3.5, 3);
            Filme filme8 = new Filme(8, "Missão Impossível – Nação Secreta ", "2015",
                    "Se tem uma coisa que Tom Cruise sabe fazer bem nessa vida é ficar pendurado nos filmes do Missão Impossível. ",
                    3.5, 1);
            Filme filme9 = new Filme(9, "Velozes e Furiosos 7", "2015",
                    "Parece que nada pode parar a família de Dom, que desde 2001 vem aparecendo nas telas com seus carros coloridos e, bem, cheios de fúria. É claro que o principal elemento são as corridas de carro, mas a franquia também apresenta grandes embates. ",
                    2.5, 3);
            Filme filme10 = new Filme(10, "Máquina Mortífera", "1987",
                    "A divertidíssima relação da dupla de policiais de Los Angeles vivida por Mel Gibson e Danny Glover parece que não perde a graça, tanto que foi feita uma série de TV baseada nos filmes.",
                    4.5, 8);

            //  Menu
            int idCliente = 0;
            Locacao locacao;
            do
            {
                Console.WriteLine("\n Informe o ID : ");
                String entrada = Console.ReadLine();
                idCliente = Convert.ToInt32(entrada);
                switch (idCliente)
                {
                    case 1:
                     

                        cliente1.mostrarCliente(); 
                        locacao = new Locacao(01, cliente1); 
                        locacao.AdicFilme(filme1); 
                        locacao.AdicFilme(filme6); 
                        locacao.AdicFilme(filme10);
                        filme1.mostrarFilme(); 
                        filme6.mostrarFilme(); 
                        filme10.mostrarFilme();
                        Console.WriteLine("-> Preço de locação : R$ " + locacao.PrecoTotal());
                        Console.WriteLine("-> Data de Devolução: " + locacao.calculoData());
                        Console.WriteLine("-> Quantidade de filme locados: " + locacao.QtdeFilmesLoc());
                        break;
                    case 2:
                        cliente2.mostrarCliente();
                        locacao = new Locacao(02, cliente2);
                        locacao.AdicFilme(filme2);
                        locacao.AdicFilme(filme7);
                        filme2.mostrarFilme();
                        filme7.mostrarFilme();
                        Console.WriteLine("-> Preço da locação: R$ " + locacao.PrecoTotal());
                        Console.WriteLine("-> Data de locação: " + locacao.calculoData());
                        Console.WriteLine("-> Quantidade de filme locados: " + locacao.QtdeFilmesLoc());
                        break;
                    case 3:
                        cliente3.mostrarCliente();
                        locacao = new Locacao(03, cliente3);
                        locacao.AdicFilme(filme3);
                        locacao.AdicFilme(filme6);
                        locacao.AdicFilme(filme7);
                        locacao.AdicFilme(filme8);
                        filme3.mostrarFilme();
                        filme6.mostrarFilme();
                        filme7.mostrarFilme();
                        filme8.mostrarFilme();
                        Console.WriteLine("-> Preço da locação: R$ " + locacao.PrecoTotal());
                        Console.WriteLine("-> Data de locação: " + locacao.calculoData());
                        Console.WriteLine("-> Quantidade de filme locados: " + locacao.QtdeFilmesLoc());

                        break;
                    case 4:
                        cliente4.mostrarCliente();
                        locacao = new Locacao(04, cliente1);
                        locacao.AdicFilme(filme4);
                        locacao.AdicFilme(filme9);
                        filme4.mostrarFilme();
                        filme9.mostrarFilme();
                        Console.WriteLine("-> Preço da locação: R$ " + locacao.PrecoTotal());
                        Console.WriteLine("-> Data de locação: " + locacao.calculoData());
                        Console.WriteLine("-> Quantidade de filme locados: " + locacao.QtdeFilmesLoc());
                        break;
                    case 5:
                        cliente5.mostrarCliente();
                        locacao = new Locacao(05, cliente1);
                        locacao.AdicFilme(filme1);
                        locacao.AdicFilme(filme5);
                        locacao.AdicFilme(filme10);
                        filme1.mostrarFilme();
                        filme5.mostrarFilme();
                        filme10.mostrarFilme();
                        Console.WriteLine("-> Preço da locação: R$ " + locacao.PrecoTotal());
                        Console.WriteLine("-> Data da locação: " + locacao.calculoData());
                        Console.WriteLine("-> Quantidade de locados: " + locacao.QtdeFilmesLoc());
                        break;
                }
            } while (idCliente <= 5);

        }
    }
}