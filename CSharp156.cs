using csharp;
using System.Collections.Generic;

int x1,y1, x2,y2;
string aux1, aux2;

PartidaXadrez jogo = new PartidaXadrez(new Tabuleiro(8,8));
Console.WriteLine();

jogo.MontarTabuleiro();
jogo.Tab.MostrarTabuleiro();
jogo.TurnoVez();

while (!jogo.JogoFinalizado)
{
    Console.Write("Origem: ");
    aux1 = Console.ReadLine();
    aux1 = jogo.Tab.Conversor(aux1);
    x1 = int.Parse(aux1.Substring(0,1));
    y1 = int.Parse(aux1.Substring(1,1));
    Posicao origem = new Posicao(x1, y1);

    var x = jogo.Tab.Pecas[x1,y1].MovimentosPossiveis();
    jogo.Tab.MostrarTabuleiro2(x);

    Console.Write("Destino: ");
    aux2 = Console.ReadLine();
    aux2 = jogo.Tab.Conversor(aux2);
    x2 = int.Parse(aux2.Substring(0,1));
    y2 = int.Parse(aux2.Substring(1,1));
    Posicao destino = new Posicao(x2, y2);

    jogo.MoverPeca(origem, destino, x);
    jogo.Tab.MostrarTabuleiro();

    jogo.TurnoVez();
    jogo.JogoAcabou();
}








