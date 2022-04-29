using System;
using System.Collections.Generic;

namespace Aula53Exercicio03
{
    internal class Program
    {



        static void Main(string[] args)
        {
            /*
             VOTAÇÃO
            Cadastrado em collection (array / list) os eleitor  (10)


            vai existir uma classe candidatos (3) ok

            voto - cada um só pode votar 1 vez
            inicializado com false

            ao votar deve forncer o numero do titulo, pesquisar se existe este numero
            no array e se aind anão votou, se tudo estiver ok libera o voto

            o voto deve ser apenas 1 candidato e o final (vai ser quando o ultimo eleitor votar 
            
            o sistema deve informar o percentual e o total de votos, deve permitir voto nulo e em branco
             
             */

            //listagem dos eleitores



            Console.WriteLine("------------LISTAGEM ELEITORES------------");

            List<Eleitor> todosEleitores = EleitorRepository.IinitializeEleitores();
            foreach(Eleitor eleitor in todosEleitores)
            {
                Console.WriteLine(eleitor);
            }

            Console.WriteLine("------------LISTAGEM CANDIDATOS------------");
            List<Candidato> todosCandidatos = CandidatosRepository.InitializeCandidatos();
            


            Console.WriteLine("Informe o título de eleitor");
            string titulo = Console.ReadLine();
            Eleitor e = FindEleitor(todosEleitores, titulo);
            Console.WriteLine("------------VOTAÇÃO------------");
            Console.WriteLine("1 - SELECIONAR UM CANDIDATO \n2 -  VOTAR EM BRANCO \n3 - VOTAR NULO \n***INSIRA A OPÇÃO DESEJADA***");
            int opcaoSelecionadaVotacao = int.Parse(Console.ReadLine());
            if (opcaoSelecionadaVotacao == 1)
            {
                foreach (Candidato candidato in todosCandidatos)
                {
                    //candidato = new Candidato();
                    Console.WriteLine(candidato);
                }
                
                Console.WriteLine("***INSIRA O RESGISTRO DO CANDIDATO EM QUE DESEJA VOTAR***");
                string registroCandidato = Console.ReadLine();
                Candidato c = FindCandidato(todosCandidatos, registroCandidato);
                ConfirmarVoto(e, c);


            } else if (opcaoSelecionadaVotacao == 2)
            {
                //fluxo voto branco
            } else if (opcaoSelecionadaVotacao == 3)
            {
                //fluxo voto nulo
            }
            else
            {
                Console.WriteLine("Opção Inválida");
            }


           

            //    Eleitor eleitor = FindEleitor(todosEleitores, titulo);



            //    if (eleitor != null)
            //    {
            //        Console.WriteLine($"Eleitor: {eleitor}");
            //        //colocar esse eleitor para realizar o voto

            //    }
            //    else
            //    {
            //        Console.WriteLine("Eleitor não encontrado no sistema");
            //    }



            //    Console.WriteLine("------------LISTAGEM CANDIDATOS------------");
            //    Candidato []  todosCandidatos = CandidatosRepository.InitializeCandidatos();
            //    /*foreach(Candidato candidato in todosCandidatos)
            //    {
            //        Candidato c1 = new Candidato();
            //        Console.WriteLine("Informar voto");
            //        c1.voto = Console.ReadLine;


            //    }*/
            //}

            

        }
        public static Eleitor FindEleitor(List<Eleitor> eleitores, string titulo)
        {
            foreach (Eleitor eleitor in eleitores)
            {
                if (eleitor.TituloEleitor == titulo)
                {
                    Console.WriteLine(eleitor);
                    return eleitor;

                }
            }
            return null;
        }

        public static Candidato FindCandidato(List<Candidato> candidatos, string registro)
        {
            foreach(Candidato candidato in candidatos)
            {
                Console.WriteLine(candidato);
                return candidato;
            }

            return null;
        }

        public static void ConfirmarVoto(Eleitor eleitor, Candidato candidado)
        {
            eleitor.Votou = true;
            candidado.VotosRecebidos += 1;
            
        }
    }
}
