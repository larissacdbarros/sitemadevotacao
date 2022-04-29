using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula53Exercicio03
{
    public class EleitorRepository
    {

        public static List<Eleitor> IinitializeEleitores()
        {
            List<Eleitor> eleitores = new List<Eleitor>();  
            {
                eleitores.Add(new Eleitor("Larissa", "75896412"));
                eleitores.Add(new Eleitor("Marisa", "59874158"));
                eleitores.Add(new Eleitor("Karina", "1258745"));
                eleitores.Add(new Eleitor("Lucas", "25418963"));
                eleitores.Add(new Eleitor("Marcio", "58963254"));
                eleitores.Add(new Eleitor("Joao", "485695"));
                eleitores.Add(new Eleitor("Pedro","0555512"));
                eleitores.Add(new Eleitor("Ana" , "745896254"));
                eleitores.Add(new Eleitor("Augusto", "584596"));
                eleitores.Add(new Eleitor("Giovana", "2458963"));           
            }
            return eleitores;
        }
    }
}
