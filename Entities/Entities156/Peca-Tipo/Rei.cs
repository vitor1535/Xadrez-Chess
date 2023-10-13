class Rei : Peca
{
    public Rei(Cor cor,Tabuleiro tab)
    {
        Cor = cor;
        Tab = tab;
        QtdMovimentos = 0;
    }

    public override string ToString()
    {
        return "R";
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
        
        //acima
        pos = new Posicao(Pos.Linha - 1, Pos.Coluna);
        if (MovimentosDentroDoTabuleiro(pos) == true)
        {
            matriz = MovimentoValido(pos, matriz);
        }

        //abaixo
        pos = new Posicao(Pos.Linha + 1, Pos.Coluna);
        if (MovimentosDentroDoTabuleiro(pos) == true)
        {
            matriz = MovimentoValido(pos, matriz);
        }

        //direita
        pos = new Posicao(Pos.Linha, Pos.Coluna + 1);
        if (MovimentosDentroDoTabuleiro(pos) == true)
        {
            matriz = MovimentoValido(pos, matriz);
        }

        //esquerda
        pos = new Posicao(Pos.Linha, Pos.Coluna - 1);
        if (MovimentosDentroDoTabuleiro(pos) == true)
        {
            matriz = MovimentoValido(pos, matriz);
        }

        //diagonal acima direita
        pos = new Posicao(Pos.Linha - 1, Pos.Coluna + 1);
        if (MovimentosDentroDoTabuleiro(pos) == true)
        {
            matriz = MovimentoValido(pos, matriz);
        }

        //diagonal acima esquerda
        pos = new Posicao(Pos.Linha - 1, Pos.Coluna - 1);
        if (MovimentosDentroDoTabuleiro(pos) == true)
        {
            matriz = MovimentoValido(pos, matriz);
        }

        //diagonal abaixo direita
        pos = new Posicao(Pos.Linha + 1, Pos.Coluna + 1);
        if (MovimentosDentroDoTabuleiro(pos) == true)
        {
            matriz = MovimentoValido(pos, matriz);
        }

        //diagonal abaixo esquerda
        pos = new Posicao(Pos.Linha + 1, Pos.Coluna - 1);
        if (MovimentosDentroDoTabuleiro(pos) == true)
        {
            matriz = MovimentoValido(pos, matriz);
        }

        return matriz;
    }
}
