class PartidaXadrez 
{
    public Tabuleiro Tab { get; set; }
    public int Turno { get; set; }
    public bool JogoFinalizado { get; set; }

    public PartidaXadrez()
    {
    }

    public PartidaXadrez(Tabuleiro tab)
    {
        Tab = tab;
        Turno = 1;
        JogoFinalizado = false;
    }

    public void ColocarPeca(Peca p, Posicao pos)
    {
        Tab.Pecas[pos.Linha, pos.Coluna] = p;
        p.Pos = pos;
    }

    public void MontarTabuleiro()
    {
        for (int i = 0; i < 8; i++)
    {   
        ColocarPeca(new Peao(Cor.Preta, Tab), new Posicao(1,i)); 
    }
    ColocarPeca(new Torre(Cor.Preta, Tab), new Posicao (0,0));
    ColocarPeca(new Torre(Cor.Preta, Tab), new Posicao (0,7));
    ColocarPeca(new Cavalo(Cor.Preta, Tab), new Posicao (0,1));
    ColocarPeca(new Cavalo(Cor.Preta, Tab), new Posicao (0,6));
    ColocarPeca(new Bispo(Cor.Preta, Tab), new Posicao (0,2));
    ColocarPeca(new Bispo(Cor.Preta, Tab), new Posicao (0,5));
    ColocarPeca(new Rei(Cor.Preta, Tab), new Posicao (0,3));
    ColocarPeca(new Dama(Cor.Preta, Tab), new Posicao (0,4));

    for (int i = 0; i < 8; i++)
    {
        ColocarPeca(new Peao(Cor.Branca, Tab), new Posicao(6,i));
    }
    ColocarPeca(new Torre(Cor.Branca, Tab), new Posicao (7,0));
    ColocarPeca(new Torre(Cor.Branca, Tab), new Posicao (7,7));
    ColocarPeca(new Cavalo(Cor.Branca, Tab), new Posicao (7,1));
    ColocarPeca(new Cavalo(Cor.Branca, Tab), new Posicao (7,6));
    ColocarPeca(new Bispo(Cor.Branca, Tab), new Posicao (7,2));
    ColocarPeca(new Bispo(Cor.Branca, Tab), new Posicao (7,5));
    ColocarPeca(new Rei(Cor.Branca, Tab), new Posicao (7,3));
    ColocarPeca(new Dama(Cor.Branca, Tab), new Posicao (7,4));
    }

    public void MoverPeca(Posicao origem, Posicao destino, bool [,] matriz)
    {

        if ((Turno % 2 == 1 && Tab.Pecas[origem.Linha, origem.Coluna].Cor == Cor.Branca || Turno % 2 == 0 && Tab.Pecas[origem.Linha, origem.Coluna].Cor == Cor.Preta) && matriz[destino.Linha, destino.Coluna] == true)
        {
            Tab.Pecas[origem.Linha, origem.Coluna].QtdMovimentos++;
            Tab.Pecas[origem.Linha, origem.Coluna].Pos.Linha = destino.Linha;
            Tab.Pecas[origem.Linha, origem.Coluna].Pos.Coluna = destino.Coluna;
            Turno++;

            Peca p = Tab.Pecas[origem.Linha, origem.Coluna];
            Tab.Pecas[origem.Linha, origem.Coluna] = null;
            Tab.Pecas[destino.Linha, destino.Coluna] = p;
        }
        else
        {
            Console.WriteLine("Jogada inválida!");
        } 
    }

    public void JogoAcabou()
    {
        int resultado = 0;

        for (int i = 0; i < Tab.Linhas; i++)
        {
            for (int j = 0; j < Tab.Colunas; j++)
            {
                if (Tab.Pecas[i,j] is Rei)
                {
                    resultado++;
                }
            }
        }

        if (resultado != 2)
        {
            JogoFinalizado = true;
            Console.WriteLine("JOGO FINALIZADO!");
        }
    }

    public void TurnoVez()
    {
        string vez;

        if (Turno % 2 == 1)
        {
            Console.WriteLine("Turno " + Turno + " - Brancas");
        }
        else
        {
            Console.WriteLine("Turno " + Turno + " - Pretas");
        }
    }
}