using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Futebol
{
    class Program
    {
        static void Main(string[] args)
        {
            Time time1 = new Time("Palmeiras");
            time1.contratarJogador( new Jogador("Bruno",20)
            time1.contratarJogador(new Jogador("Pedro", 20, 99, 2));
            time1.contratarJogador(new Jogador("Leandro", 20, 99, 3));
            time1.contratarJogador(new Jogador("Bruno", 20, 99, 4));
            time1.contratarJogador(new Jogador("Jorge", 20, 99, 5));
            time1.contratarJogador(new Jogador("Eleno", 20, 99, 6));
            time1.contratarJogador(new Jogador("Rodrigro", 20, 99, 7));
            time1.contratarJogador(new Jogador("Antonio", 20, 99, 8));
            time1.contratarJogador(new Jogador("Migel", 20, 99, 9));
            time1.contratarJogador(new Jogador("Luciano", 20, 99, 10));
            time1.contratarJogador(new Jogador("ROGER", 20, 99, 11));
            time1.contratarJogador(new Jogador("Lucas", 20, 99, 12));
            time1.contratarJogador(new Jogador("Natsita", 20, 99, 13));
            time1.contratarJogador(new Jogador("Batista", 20, 99, 14));
            time1.contratarJogador(new Jogador("Jose", 20, 99, 15));
            time1.contratarJogador(new Jogador("Alencar", 20, 99, 16));

            Time time2 = new Time("Santos");
            time2.contratarJogador(new Jogador("Alex", 20, 99, 1));
            time2.contratarJogador(new Jogador("Pedro", 20, 99, 1));
            time2.contratarJogador(new Jogador("Leandro", 20, 99, 1));
            time2.contratarJogador(new Jogador("Bruno", 20, 99, 1));
            time2.contratarJogador(new Jogador("Jorge", 20, 99, 1));
            time2.contratarJogador(new Jogador("Eleno", 20, 99, 1));
            time2.contratarJogador(new Jogador("Rodrigro", 20, 99, 1));
            time2.contratarJogador(new Jogador("Antonio", 20, 99, 1));
            time2.contratarJogador(new Jogador("Migel", 20, 99, 1));
            time2.contratarJogador(new Jogador("Luciano", 20, 99, 1));
            time2.contratarJogador(new Jogador("ROGER", 20, 99, 1));
            time2.contratarJogador(new Jogador("Lucas", 20, 99, 1));
            time2.contratarJogador(new Jogador("Natsita", 20, 99, 1));
            time2.contratarJogador(new Jogador("Batista", 20, 99, 1));
            time2.contratarJogador(new Jogador("Jose", 20, 99, 1));
            time2.contratarJogador(new Jogador("Alencar", 20, 99, 1));

            Partida p1 = new Partida(DateTime.Now, time1, time2);
            p1,jogar();
            Console.WriteLine(p1.getPlacar());

            Console.WriteLine(time1.getStatus());
            time1.getDescricaoJogadores());

        







        }
    }
}
