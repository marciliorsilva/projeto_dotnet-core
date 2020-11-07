using System;

namespace projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            string opcaoEscolhida = ObterOpcaoUsuario();
            var indice = 0;

            while(opcaoEscolhida.ToUpper() != "X"){
                
                switch(opcaoEscolhida){
                    case "1":
                        Console.WriteLine("Informe o nome do aluno:");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                        Console.WriteLine("Informe a nota do aluno:");
                      
                        if(decimal.TryParse(Console.ReadLine(), out decimal nota)){
                              aluno.Nota = nota;
                        }else{
                            throw new ArgumentException("Valor da nota invalido. campo deve ser decimal.");
                        }

                        alunos[indice] = aluno;
                        indice ++;
                       
                        Console.WriteLine("Aluno cadastrado com sucesso");
                        Console.WriteLine();


                        break;
                    case "2":
                        for (int i = 0; i < alunos.Length; i++){
                            if(alunos[i].Nome != null){
                                Console.WriteLine("-------------- Lista de alunos ---------------");
                                Console.WriteLine($"Nome: {alunos[i].Nome} - Nota: {+ alunos[i].Nota}");
                                Console.WriteLine("--------------------------------------");
                                Console.WriteLine();
                            }
                            
                        }
                        break;
                    case "3": 
                        break;
                    default: 
                        throw new ArgumentOutOfRangeException();
                }

                opcaoEscolhida =  ObterOpcaoUsuario();
               
            }
            
           


        }

        private static string ObterOpcaoUsuario(){
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();
            
            string opcao =  Console.ReadLine();
            Console.WriteLine();
            return opcao;
        }
    }

    

  
}
