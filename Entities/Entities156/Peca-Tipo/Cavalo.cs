class Cavalo : Peca
{
    public Cavalo(Cor cor,Tabuleiro tab)
    {
        Cor = cor;
        Tab = tab;
        QtdMovimentos = 0;
    }

    public override string ToString()
    {
        return "C";
    }

    public override bool[,] MovimentoValido(Posicao pos, bool[,] matriz)
    {
        if ((Tab.Pecas[pos.Linha,pos.Coluna] == null || Tab.Pecas[pos.Linha, pos.Coluna].Cor != this.Cor))
        {
        matriz[pos.Linha, pos.Coluna] = true;
        }

        return matriz;
    }

    public override bool[,] MovimentosPossiveis()
    {
        bool[,] matriz = new bool[8,8];
        Posicao pos = new Posicao(Pos.Linha,Pos.Coluna);
        
        //acima direita
        pos = new Posicao(Pos.Linha - 2, Pos.Coluna + 1);
        if (MovimentosDentroDoTabuleiro(pos) == true)
        {
            matriz = MovimentoValido(pos, matriz);
        }

        //acima esquerda
        pos = new Posicao(Pos.Linha - 2, Pos.Coluna - 1);
        if (MovimentosDentroDoTabuleiro(pos) == true)
        {
            matriz = MovimentoValido(pos, matriz);
        }

        //direita cima
        pos = new Posicao(Pos.Linha - 1, Pos.Coluna + 2);
        if (MovimentosDentroDoTabuleiro(pos) == true)
        {
            matriz = MovimentoValido(pos, matriz);
        }

        //direita baixo
        pos = new Posicao(Pos.Linha + 1, Pos.Coluna + 2);
        if (MovimentosDentroDoTabuleiro(pos) == true)
        {
            matriz = MovimentoValido(pos, matriz);
        }

        //abaixo direita
        pos = new Posicao(Pos.Linha + 2, Pos.Coluna + 1);
        if (MovimentosDentroDoTabuleiro(pos) == true)
        {
            matriz = MovimentoValido(pos, matriz);
        }

        //abaixo esquerda
        pos = new Posicao(Pos.Linha + 2, Pos.Coluna - 1);
        if (MovimentosDentroDoTabuleiro(pos) == true)
        {
            matriz = MovimentoValido(pos, matriz);
        }

        //esquerda baixo
        pos = new Posicao(Pos.Linha + 1, Pos.Coluna - 2);
        if (MovimentosDentroDoTabuleiro(pos) == true)
        {
            matriz = MovimentoValido(pos, matriz);
        }

        //diagonal abaixo esquerda
        pos = new Posicao(Pos.Linha - 1, Pos.Coluna - 2);
        if (MovimentosDentroDoTabuleiro(pos) == true)
        {
            matriz = MovimentoValido(pos, matriz);
        }

        return matriz;
    }
}
