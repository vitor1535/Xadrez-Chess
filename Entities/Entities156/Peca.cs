abstract class Peca
{
    public Cor Cor { get; set; }
    public Posicao Pos { get; set; }
    public int QtdMovimentos { get; set; }
    public Tabuleiro Tab { get; set; }

    public Peca()
    {
    }

    public Peca(Cor cor, Tabuleiro tab)
    {
        Cor = cor;
        Tab = tab;
        QtdMovimentos = 0;
    }

    public abstract bool[,] MovimentosPossiveis();

    public abstract bool[,] MovimentoValido(Posicao pos, bool[,] matriz);

    public bool MovimentosDentroDoTabuleiro(Posicao pos)
    {
        if (pos.Linha >= 0 && pos.Linha <= 7 & pos.Coluna >= 0 && pos.Coluna <= 7)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}