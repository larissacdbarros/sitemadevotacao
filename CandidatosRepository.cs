using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula53Exercicio03
{
    public class CandidatosRepository
    {
       public static List<Candidato> InitializeCandidatos()
        {
            //LISTA
            List<Candidato> candidatos = new List<Candidato>();
            candidatos.Add(new Candidato("João da Silva", "PSDB", 15963));
            candidatos.Add(new Candidato("Pedro Moreira", "PP", 35741));
            candidatos.Add(new Candidato("Maria da Silveira", "MDB", 25897));
            return candidatos;
        }

    }
}
