class Torre : Peca
{
    public Torre(Cor cor,Tabuleiro tab)
    {
        Tab = tab;
        Cor = cor;
        QtdMovimentos = 0;
    }

    public override string ToString()
    {
        return "T";
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
        int i = 1;
        while (true)
        {
            pos = new Posicao(Pos.Linha - i, Pos.Coluna);
            if (MovimentosDentroDoTabuleiro(pos) == true)
            {
                matriz = MovimentoValido(pos, matriz);
                if (matriz[pos.Linha, pos.Coluna] == false)
                {
                    break;
                }

                if (Tab.Pecas[pos.Linha, pos.Coluna] is Peca)
                {
                    if (Tab.Pecas[pos.Linha, pos.Coluna].Cor != this.Cor)
                    {
                        break;
                    }
                }
                i++;
            }
            else
            {
                break;
            }
        }

        //abaixo
        i = 1;
        while (true)
        {
            pos = new Posicao(Pos.Linha + i, Pos.Coluna);
            if (MovimentosDentroDoTabuleiro(pos) == true)
            {
                matriz = MovimentoValido(pos, matriz);
                if (matriz[pos.Linha, pos.Coluna] == false)
                {
                    break;
                }

                if (Tab.Pecas[pos.Linha, pos.Coluna] is Peca)
                {
                    if (Tab.Pecas[pos.Linha, pos.Coluna].Cor != this.Cor)
                    {
                        break;
                    }
                }
                i++;
            }
            else
            {
                break;
            }
        }

        //direita
        i = 1;
        while (true)
        {
            pos = new Posicao(Pos.Linha, Pos.Coluna + i);
            if (MovimentosDentroDoTabuleiro(pos) == true)
            {
                matriz = MovimentoValido(pos, matriz);
                if (matriz[pos.Linha, pos.Coluna] == false)
                {
                    break;
                }

                if (Tab.Pecas[pos.Linha, pos.Coluna] is Peca)
                {
                    if (Tab.Pecas[pos.Linha, pos.Coluna].Cor != this.Cor)
                    {
                        break;
                    }
                }
                i++;
            }
            else
            {
                break;
            }
        }

        //esquerda
        i = 1;
        while (true)
        {
            pos = new Posicao(Pos.Linha, Pos.Coluna - i);
            if (MovimentosDentroDoTabuleiro(pos) == true)
            {
                matriz = MovimentoValido(pos, matriz);
                if (matriz[pos.Linha, pos.Coluna] == false)
                {
                    break;
                }

                if (Tab.Pecas[pos.Linha, pos.Coluna] is Peca)
                {
                    if (Tab.Pecas[pos.Linha, pos.Coluna].Cor != this.Cor)
                    {
                        break;
                    }
                }
                i++;
            }
            else
            {
                break;
            }
        }

        return matriz;
    }
}