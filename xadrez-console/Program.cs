using System;
using xadrez_console.tabuleiro;
using xadrez_console.tabuleiro.enums;
using xadrez_console.tabuleiro.exceptions;
using xadrez_console.xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tabuleiro = new Tabuleiro(8, 8);
                tabuleiro.ColocarPeca(new Torre(new Posicao(0, 0), Cor.Preta, tabuleiro));
                tabuleiro.ColocarPeca(new Torre(new Posicao(1, 9), Cor.Preta, tabuleiro));
                tabuleiro.ColocarPeca(new Rei(new Posicao(0, 0), Cor.Preta, tabuleiro));

                Tela.ImprimirTabuleiro(tabuleiro);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}
