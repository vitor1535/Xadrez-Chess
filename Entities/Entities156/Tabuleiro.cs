

class Tabuleiro
{
    public char[,] Matriz { get; set; }
    public int Linhas { get; set; }
    public int Colunas { get; set; }
    public Peca[,] Pecas { get; set; }

    public Tabuleiro()
    {
    }

    public Tabuleiro(int linhas, int colunas)
    {
        Linhas = linhas;
        Colunas = colunas;
        Pecas = new Peca [Linhas, Colunas];
    }

    public void MostrarTabuleiro()
    {
        int contador = 8;
        for (int i = 0; i < Linhas; i++, contador--)
        {
            Console.Write(contador + "   ");

            for (int j = 0; j < Colunas; j++)
            {
                if (Pecas[i,j] == null)
                {
                    Console.Write(" - ");
                }
                else
                {
                    if (Pecas[i,j].Cor == Cor.Preta)
                    {
                        ConsoleColor aux = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" " + Pecas[i,j] + " ");
                        Console.ForegroundColor = aux;
                    }
                    else if (Pecas[i,j].Cor == Cor.Branca)
                    {
                        Console.Write(" " + Pecas[i,j] + " ");
                    }
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.Write("     A  B  C  D  E  F  G  H");
        Console.WriteLine();
    }

    public void MostrarTabuleiro2(bool [,] posicoesPossiveis)
    {
        int contador = 8;

        ConsoleColor fundoOriginal = ConsoleColor.Black;
        ConsoleColor fundoVermelho = ConsoleColor.Red;

        for (int i = 0; i < Linhas; i++, contador--)
        {
            Console.Write(contador + "   ");

            for (int j = 0; j < Colunas; j++)
            {
                if (Pecas[i,j] == null)
                {
                    if (posicoesPossiveis[i,j])
                    {
                        Console.BackgroundColor = fundoVermelho;
                        Console.Write(" - ");
                    }
                    else
                    {
                        Console.BackgroundColor = fundoOriginal;
                        Console.Write(" - ");
                    }
                }
                else
                {
                    if (posicoesPossiveis[i,j] && Pecas[i,j].Cor == Cor.Preta)
                    {
                        Console.BackgroundColor = fundoVermelho;
                        ConsoleColor aux = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" " + Pecas[i,j] + " ");
                        Console.ForegroundColor = aux;
                    }
                    else if (Pecas[i,j].Cor == Cor.Preta)
                    {
                        Console.BackgroundColor = fundoOriginal;
                        ConsoleColor aux = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" " + Pecas[i,j] + " ");
                        Console.ForegroundColor = aux;
                    }
                    if (posicoesPossiveis[i,j] && Pecas[i,j].Cor == Cor.Branca)
                    {
                        Console.BackgroundColor = fundoVermelho;
                        Console.Write(" " + Pecas[i,j] + " ");
                    }
                    else if(Pecas[i,j].Cor == Cor.Branca)
                    {
                        Console.BackgroundColor = fundoOriginal;
                        Console.Write(" " + Pecas[i,j] + " ");
                    }
                    Console.BackgroundColor = fundoOriginal;
                }

                Console.BackgroundColor = fundoOriginal;
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.Write("     A  B  C  D  E  F  G  H");
        Console.WriteLine();
    }

    public string Conversor(string str)
    {
        int aux1;
        string aux2;
        string resultado = "";

        aux1 = int.Parse(str.Substring(0,1));
        aux2 = str.Substring(1,1).ToLower();

        aux1 -= 8;
        aux1 = Math.Abs(aux1);

        switch(aux2)
        {
            case "a":
            resultado = aux1 + "" + 0;
            break;

            case "b":
            resultado = aux1 + "" + 1;
            break;

            case "c":
            resultado = aux1 + "" + 2;
            break;

            case "d":
            resultado = aux1 + "" + 3;
            break;

            case "e":
            resultado = aux1 + "" + 4;
            break;

            case "f":
            resultado = aux1 + "" + 5;
            break;

            case "g":
            resultado = aux1 + "" + 6;
            break;

            case "h":
            resultado = aux1 + "" + 7;
            break;
        }

        return resultado;
    }
}
