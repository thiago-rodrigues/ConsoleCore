using System;
using GameTOP.lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFoda(new Jogador1("Thiago"),
                                    new Jogador2(),
                                    new jogador3());
            jogo.IniciarJogo();
        }
    }   

}
