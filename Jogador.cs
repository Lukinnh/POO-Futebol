using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Futebol
{
    class Jogador
    {
        private string nome;
        private int idade;
        private int habilidade;
        private int camisa;
        private int gols;
        private string descricao;

        public Jogador(string pNome, int pIdade, int pHab, int pCamisa,int pGols, string pDescricao)
        {
            this.nome = pNome;
            this.idade = pIdade;
            this.habilidade = pHab;
            this.camisa = pCamisa;
            this.gols = pGols;
            this.descricao = pDescricao;
        }

        public string getNome()
        {
            return nome;
        }
    
        public int getIdade()
        {
            return idade;
        }

        public int getCamisa()
        {
            return camisa;
        }

        
        public int Gols
        {
            get { return gols; }
            set { gols += value; }
        }

        public string getDescricao()
        {
            return "Nome: " + this.getNome() +
                   "\tIdade: " + this.idade +
                   "\tHabil.: " + this.habilidade +
                   "\t Camisa: " + this.camisa +
                   "\t Gols: " + this.gols;
        }    
    }
}
