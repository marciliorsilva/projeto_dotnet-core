using System;

namespace projeto
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string opcaoEscolhida = ObterOpcaoUsuario();

            while(opcaoEscolhida.ToUpper() != "X"){
                switch(opcaoEscolhida){
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3": 
                        break;
                    default: 
                        throw new ArgumentOutOfRangeException();
                }


            }
            
            opcaoEscolhida =  ObterOpcaoUsuario();


        }

        private static string ObterOpcaoUsuario(){
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();
            
            string opcao =  Console.ReadLine();
            return opcao;
        }
    }

    

  
}
