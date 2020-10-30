using xadrez_console.tabuleiro;
using xadrez_console.tabuleiro.enums;

namespace xadrez_console.xadrez
{
    class Rei : Peca
    {
        public Rei(Posicao posicao, Cor cor, Tabuleiro tabuleiro)
        : base(posicao, cor, tabuleiro)
        {
        }

        public override string ToString()
        {
            return "R ";
        }
    }
}
