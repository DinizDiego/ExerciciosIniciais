using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosTI18N
{
    internal class ControlFormulario
    {
        ModelExercicio exercicio;
        private int opcao;

        public ControlFormulario()
        {
            exercicio = new ModelExercicio();//Conecta a classe model e a control
            ConsultarOpcao = -1;
        }//fim do método construtor

        //Métodos modificadores
        public int ConsultarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        }//fim do método

        public void Menu()
        {
            Console.WriteLine("\n\n ---- Menu ---- \n\n" +
                              "0. Sair\n"         +
                              "1. Exercício 01\n" +
                              "2. Exercício 02\n" +
                              "3. Exercício 03\n" +
                              "4. Exercício 04\n" +
                              "5. Exercício 05\n" +
                              "6. Exercício 06\n" +
                              "Escolha uma das opções acima: ");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//Mostrar menu 

        public void operacao()
        {
            do
            {
                Menu();
                Console.Clear();//Limpa tela
                switch (ConsultarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        double nota1;//Validei do lado de fora
                        do
                        {
                            Console.WriteLine("Informe a primeira nota: ");
                            nota1 = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNotas(nota1) == true)
                            {
                                Console.WriteLine("Informe uma nota enre 0 e 10");
                            }//Fim da validação
                        } while (exercicio.ValidarNotas(nota1) == true);

                        double nota2;//Validei do lado de fora
                        do
                        {
                            Console.WriteLine("Informe a segunda nota: ");
                            nota2 = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNotas(nota2) == true)
                            {
                                Console.WriteLine("Informe uma nota ente 0 e 10");
                            }//Fim da validação
                        } while (exercicio.ValidarNotas(nota2) == true);


                        //Chamar o método da média que está na classe model
                        Console.WriteLine("A média das notas digitadas é: " + exercicio.MediaDuasNotas(nota1, nota2));
                        break;
                    case 2:
                        Console.WriteLine("Informe um número: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe outro número: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());

                        //Comparação
                        Console.WriteLine("O maior número é: " + exercicio.Comparar(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine("Informe um número: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        //Mostrar resultado
                        Console.WriteLine("O antecessor é: " + exercicio.Antecessor(num));
                        break;
                    case 4:
                        double numA;//Validei do lado de fora
                        do
                        {
                            Console.WriteLine("Informe o valor da base: ");
                            numA = Convert.ToDouble(Console.ReadLine());

                            if(exercicio.ValidarNegativo(numA) == true)
                            {
                                Console.WriteLine("Informe um número positivo maior ou igual a zero.");
                            }//Fim da validação
                        } while (exercicio.ValidarNegativo (numA) == true);

                        double numB;//Validei do lado de fora
                        do
                        {
                            Console.WriteLine("Informe o valor da base: ");
                            numB = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNegativo(numB) == true)
                            {
                                Console.WriteLine("Informe um número positivo.");
                            }//Fim da validação
                        } while (exercicio.ValidarNegativo(numB) == true);
                            //Mostrando o valor da área
                            Console.WriteLine("O valor da área é: " + exercicio.CalcArea(numA, numB));
                        break;




                    default:
                        Console.WriteLine("Opção escolhida não é válida!");
                        break;
                }//fim do escolha
            }while (ConsultarOpcao != 0);//fim do DoWhile
        }//fim do metodo 


    }//fim da classe
}//fim do projeto
