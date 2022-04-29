using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula53Exercicio03
{
    public class Eleitor
    {
        public string Nome { get; set; }    
        public string TituloEleitor { get; set; }
        public bool Votou { get; set; } = false;faz
       // public Candidato voto [];

        public Eleitor(string nome, string tituloEleitor)
        {
            this.Nome = nome;
            this.TituloEleitor = tituloEleitor;
        }

        public override string ToString() => $"Eleitor: {Nome} (Título de Eleitor: {TituloEleitor})";

        public Eleitor FindEleitor(List<Eleitor> eleitor, string tituloEleitor)
        {
            return eleitor.Find(eleitor => eleitor.TituloEleitor == tituloEleitor);     
        }
    }
}
