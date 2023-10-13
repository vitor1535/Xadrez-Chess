class Peao : Peca
{
    public Peao(Cor cor,Tabuleiro tab)
    {
        Cor = cor;
        Tab = tab;
        QtdMovimentos = 0;
    }

    public override string ToString()
    {
        return "P";
    }

    public override bool[,] MovimentoValido(Posicao pos, bool[,] matriz)
    {
        if (Tab.Pecas[pos.Linha,pos.Coluna] == null)
        {
            matriz[pos.Linha, pos.Coluna] = true;
        }
        
            if (Tab.Pecas[pos.Linha, pos.Coluna] is Peca && Tab.Pecas[pos.Linha, pos.Coluna].Cor != this.Cor)
            {
                matriz[pos.Linha, pos.Coluna] = false;
            }


            Posicao pos1 = new Posicao (pos.Linha, pos.Coluna + 1);
            if (MovimentosDentroDoTabuleiro(pos1))
            {
                if (Tab.Pecas[pos.Linha, pos.Coluna + 1] is Peca && Tab.Pecas[pos.Linha, pos.Coluna + 1].Cor != this.Cor && this.Cor == Cor.Branca && this.QtdMovimentos == 0)
                {
                    matriz[pos.Linha, pos.Coluna + 1] = true;
                }
            }

            pos1 = new Posicao (pos.Linha, pos.Coluna - 1);
            if (MovimentosDentroDoTabuleiro(pos1))
            {
                if (Tab.Pecas[pos.Linha, pos.Coluna - 1] is Peca && Tab.Pecas[pos.Linha, pos.Coluna - 1].Cor != this.Cor && this.Cor == Cor.Branca && this.QtdMovimentos == 0)
                {
                    matriz[pos.Linha, pos.Coluna - 1] = true;
                }
            }

            pos1 = new Posicao (pos.Linha, pos.Coluna - 1);
            if (MovimentosDentroDoTabuleiro(pos1))
            {
                if (Tab.Pecas[pos.Linha, pos.Coluna - 1] is Peca && Tab.Pecas[pos.Linha, pos.Coluna - 1].Cor != this.Cor && this.Cor == Cor.Preta && this.QtdMovimentos == 0)
                {
                    matriz[pos.Linha, pos.Coluna - 1] = true;
                }
            }

            pos1 = new Posicao (pos.Linha, pos.Coluna + 1);
            if (MovimentosDentroDoTabuleiro(pos1))
            {
                if (Tab.Pecas[pos.Linha, pos.Coluna + 1] is Peca && Tab.Pecas[pos.Linha, pos.Coluna + 1].Cor != this.Cor && this.Cor == Cor.Preta && this.QtdMovimentos == 0)
                {
                    matriz[pos.Linha, pos.Coluna + 1] = true;
                }
            }
        

        return matriz;
    }

    public override bool[,] MovimentosPossiveis()
    {
        bool[,] matriz = new bool[8,8];
        Posicao pos = new Posicao(Pos.Linha,Pos.Coluna);
        
        //acima (2) - Branca
        if (this.Cor == Cor.Branca && this.QtdMovimentos == 0)
        {
            int i = 1;
            while (i <= 2)
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
        }

        //abaixo(2) - Preta
        if (this.Cor == Cor.Preta && this.QtdMovimentos == 0)
        {
            int i = 1;
            while (i <= 2)
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
        }

        //acima(1) - Branca
        if (this.Cor == Cor.Branca)
        {
            pos = new Posicao(Pos.Linha - 1, Pos.Coluna);
            if (MovimentosDentroDoTabuleiro(pos) == true)
            {
                matriz = MovimentoValido(pos, matriz);
            }
        }

        //abaixo(1) - Preta
        if (this.Cor == Cor.Preta)
        {
            pos = new Posicao(Pos.Linha + 1, Pos.Coluna);
            if (MovimentosDentroDoTabuleiro(pos) == true)
            {
                matriz = MovimentoValido(pos, matriz);
            }
        }

        return matriz;
    }
}
