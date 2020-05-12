using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFoda
    {
        private readonly iJogador _jogadorA;
        public readonly iJogador _jogadorB;
        public readonly iJogador _jogadorC;

        public JogoFoda(iJogador jogadorA, iJogador jogadorB, iJogador jogadorC)
        {
            _jogadorA = jogadorA;
            _jogadorB = jogadorB;
            _jogadorC = jogadorC;
        }
        public void IniciarJogo()
        {
           System.Console.Write(_jogadorA.Corre());
           System.Console.Write(_jogadorA.Chuta());
           System.Console.Write(_jogadorA.Passe());

           System.Console.Write(_jogadorB.Corre());
           System.Console.Write(_jogadorB.Chuta());
           System.Console.Write(_jogadorB.Passe());

           System.Console.Write(_jogadorC.Corre());
           System.Console.Write(_jogadorC.Chuta());
           System.Console.Write(_jogadorC.Passe());
        }

    }
}