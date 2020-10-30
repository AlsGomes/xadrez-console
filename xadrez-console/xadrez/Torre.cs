using xadrez_console.tabuleiro;
using xadrez_console.tabuleiro.enums;

namespace xadrez_console.xadrez
{
    class Torre : Peca
    {
        public Torre(Posicao posicao, Cor cor, Tabuleiro tabuleiro)
        : base(posicao, cor, tabuleiro)
        {
        }

        public override string ToString()
        {
            return "T ";
        }
    }
}
