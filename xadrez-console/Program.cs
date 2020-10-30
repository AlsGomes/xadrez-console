using System;
using xadrez_console.tabuleiro;
using xadrez_console.tabuleiro.enums;
using xadrez_console.xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro(8, 8);
            tabuleiro.ColocarPeca(new Torre(new Posicao(0, 0), Cor.Preta, tabuleiro));
            tabuleiro.ColocarPeca(new Torre(new Posicao(1, 3), Cor.Preta, tabuleiro));
            tabuleiro.ColocarPeca(new Rei(new Posicao(2, 4), Cor.Preta, tabuleiro));

            Tela.ImprimirTabuleiro(tabuleiro);
        }
    }
}
