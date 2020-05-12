using GameTOP.Interface;

namespace GameTOP.lib
{
    public class jogador3 : iJogador
    {
        public string Chuta()
        {
            return "Teste chuta!\n";
        }

        public string Corre()
        {
            return "Teste Corre!\n";
        }

        public string Passe()
        {
            return "Teste Passa!\n";
        }
    }
}