using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula53Exercicio03
{
    public class Candidato
    {
        public string Nome { get; set; }   
        
        public string Partido { get; set; } 
        public int Registro { get; set; }

        public int VotosRecebidos { get; set; } = 0;

        //QTD VOTOS;

        public Candidato(string nome, string partido, int registro)
        {
            this.Nome = nome;
            this.Partido = partido; 
            this.Registro = registro;   
        }

        public override string ToString() => $"{Nome} - {Partido} - {Registro}";
    }
}
