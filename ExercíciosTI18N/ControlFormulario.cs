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
                              "7. Exercício 07\n" +
                              "8. Exercício 08\n" +
                              "9. Exercício 09\n" +
                              "10. Exercício 10\n" +
                              "11. Exercício 11\n" +
                              "12. Exercício 12\n" +
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
                    case 5:
                        //Validação do lado de fora                    
                        double totalE;
                        double valido;
                        double branco;
                        double nulo;
                        do
                        {   
                            //Coletando e validando o Total de Eleitores
                            do
                            {
                                Console.WriteLine("Informe o total de eleitores: ");
                                totalE = Convert.ToDouble(Console.ReadLine());

                                if (exercicio.ValidarNegativo(totalE) == true)
                                {
                                    Console.WriteLine("O total de eleitores deve ser maior do que zero!");
                                }//Fim da Validação
                            } while (exercicio.ValidarNegativo(totalE) == true);

                            //Coletando e validando os Votos Válidos
                            do
                            {
                                Console.WriteLine("Informe o valor de votos válidos: ");
                                valido = Convert.ToDouble(Console.ReadLine());

                                if (exercicio.ValidarNegativo(valido) == true)
                                {
                                    Console.WriteLine("Informe um valor maior do que zero!");
                                }//Fim da validação
                            } while (exercicio.ValidarNegativo(valido) == true);

                            //Coletando e validando os Votos Brancos
                            do
                            {
                                Console.WriteLine("Informe o valor de votos brancos: ");
                                branco = Convert.ToDouble(Console.ReadLine());

                                if (exercicio.ValidarNegativo(branco) == true)
                                {
                                    Console.WriteLine("Informe um valor maior do que zero");
                                }//Fim da validação
                            } while (exercicio.ValidarNegativo(branco) == true);

                            //Coletando e validando os Votos Nulos
                            do
                            {
                                Console.WriteLine("Informe o valor de votos nulo: ");
                                nulo = Convert.ToDouble(Console.ReadLine());

                                if (exercicio.ValidarNegativo(nulo) == true)
                                {
                                    Console.WriteLine("Informe um valor maior do que zero");
                                }//Fim da validação
                            } while (exercicio.ValidarNegativo(nulo) == true);

                            Console.Clear();//Limpa tela
                            //Validação do total de eleitores e de votos
                            if (exercicio.validarTotalE(totalE, branco, nulo, valido) == true)
                            {
                                Console.WriteLine("A quantidade de votos é diferente do total de eleitores");
                            }//Fim da validação
                        } while (exercicio.validarTotalE(totalE, branco, nulo, valido) == true);                                           
                            //Mostrando os percentuais em tela      
                            Console.WriteLine("O percentual de votos Válidos é: " + exercicio.PValido(totalE, valido) + "%");
                            Console.WriteLine("O percentual de votos Brancos é: " + exercicio.PBranco(totalE, branco) + "%");
                            Console.WriteLine("O percentual de votos Nulos é: "+ exercicio.PNulo(totalE, nulo) + "%");
                        break;
                    case 6:
                        double salario6;
                        double reajuste6;

                        //Coletando e validando o valor do salário
                        do
                        {
                            Console.WriteLine("Informe o valor do salário do funcionário: ");
                            salario6 = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNegativo(salario6) == true)
                            {
                                Console.WriteLine("Informe um valor positivo maior do que zero!");
                            }//Fim da validação
                        } while (exercicio.ValidarNegativo(salario6) == true);

                        //Coletando e validando o valor do reajuste
                        do
                        {
                            Console.WriteLine("Informe o valor do reajuste: ");
                            reajuste6 = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNegativo(reajuste6) == true)
                            {
                                Console.WriteLine("Informe um valor positivo maior do que zero!");
                            }//Fim da validação
                        } while (exercicio.ValidarNegativo(reajuste6) == true);
                            //Mostrando em tela o resultado
                            Console.WriteLine("O novo salário do funcionário é R$" + exercicio.ReajusteFuncionario(salario6, reajuste6));
                        break;
                    case 7:
                        double percentualImpostos;
                        double percentualDistribuidor;
                        double custoFabrica;

                        //Percentual de impostos
                        do
                        {
                            Console.WriteLine("Informe o percentual de impostos: ");
                            percentualImpostos = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNegativo(percentualImpostos) == true)
                            {
                                Console.WriteLine("Informe um valor maior do que zero!");
                            }//Fim validação
                        } while (exercicio.ValidarNegativo(percentualImpostos) == true);
                        //Percentual do distribuidor
                        do
                        {
                            Console.WriteLine("Informe o percentual do distribuidor: ");
                            percentualDistribuidor = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNegativo(percentualDistribuidor) == true)
                            {
                                Console.WriteLine("Informe um valor maior do que zero!");
                            }//Fim validação
                        } while (exercicio.ValidarNegativo(percentualDistribuidor) == true);
                        //Custo de fábrica
                        do
                        {
                            Console.WriteLine("Informe o custo de fábrica: ");
                            custoFabrica = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNegativo(custoFabrica) == true)
                            {
                                Console.WriteLine("Informe um valor maior do que zero!");
                            }//Fim validação
                        } while (exercicio.ValidarNegativo(custoFabrica) == true);
                            //Mostrando em tela o custo final
                            Console.WriteLine("O custo final é R$" + exercicio.CustoFinalCarro(percentualImpostos, percentualDistribuidor, custoFabrica));
                        break;
                    case 8:
                        double salario;
                        double valorPorCarro;
                        double qntCarros;
                        double comissao;
                        double totalDeVendas;

                        //Salário
                        do
                        {
                            Console.WriteLine("Informe o valor do salário fixo do funcionário: ");
                            salario = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNegativo(salario) == true)
                            {
                                Console.WriteLine("Informe um valor maior do que zero!");
                            }//Fim da validação
                        } while (exercicio.ValidarNegativo(salario) == true);
                        //Valor Por Carro
                        do
                        {
                            Console.WriteLine("Informe o valor por carro vendido pelo funcionário: ");
                            valorPorCarro = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNegativo(valorPorCarro) == true)
                            {
                                Console.WriteLine("Informe um valor maior do que zero!");
                            }//Fim da validação
                        } while (exercicio.ValidarNegativo(valorPorCarro) == true);
                        //Quantidade de Carros Vendidos
                        do
                        {
                            Console.WriteLine("Informe a quantidade de carros vendidos pelo funcionário: ");
                            qntCarros = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNegativo(qntCarros) == true)
                            {
                                Console.WriteLine("Informe um valor maior do que zero!");
                            }//Fim da validação
                        } while (exercicio.ValidarNegativo(qntCarros) == true);
                        //Valor da comissão
                        do
                        {
                            Console.WriteLine("Informe o valor da comissão do funcionário: ");
                            comissao = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNegativo(comissao) == true)
                            {
                                Console.WriteLine("Informe um valor maior do que zero!");
                            }//Fim da validação
                        } while (exercicio.ValidarNegativo(comissao) == true);
                        //Total de Vendas
                        do
                        {
                            Console.WriteLine("Informe o valor do total de vendas do funcionário: ");
                            totalDeVendas = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNegativo(totalDeVendas) == true)
                            {
                                Console.WriteLine("Informe um valor maior do que zero!");
                            }//Fim da validação
                        } while (exercicio.ValidarNegativo(totalDeVendas) == true);
                            //Mostrar resultado em tela
                            Console.WriteLine("O salário final do funcionário é: R$" + exercicio.salarioFinal(salario, valorPorCarro, qntCarros, comissao, totalDeVendas));
                        break;
                    case 9:
                        double not1;
                        double not2;
                        double not3;

                        //Nota 1
                        do
                        {
                            Console.WriteLine("Informe a primeira nota:");
                            not1 = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarEntreZeroDez(not1) == true)
                            {
                                Console.WriteLine("Informe um valor entre zero e dez!");
                            }//Fim da validação
                        } while (exercicio.ValidarEntreZeroDez(not1) == true);
                        //Nota 2
                        do
                        {
                            Console.WriteLine("Informe a segunda nota:");
                            not2 = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarEntreZeroDez(not2) == true)
                            {
                                Console.WriteLine("Informe um valor entre zero e dez!");
                            }//Fim da validação
                        } while (exercicio.ValidarEntreZeroDez(not2) == true);
                        //Nota 3
                        do
                        {
                            Console.WriteLine("Informe a primeira nota:");
                            not3 = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarEntreZeroDez(not3) == true)
                            {
                                Console.WriteLine("Informe um valor entre zero e dez!");
                            }//Fim da validação
                        } while (exercicio.ValidarEntreZeroDez(not3) == true);
                            //Retorno da situação do aluno
                            if(exercicio.MediaTresNotas(not1, not2, not3) < 5)
                            {
                                Console.WriteLine("Você está de recuperação, e precisa de: " + (10 - exercicio.MediaTresNotas(not1, not2, not3) + 2) + " para passar");
                            }
                            else
                            {
                                if(exercicio.MediaTresNotas(not1, not2, not3) < 7)
                                {
                                    Console.WriteLine("Você está de recuperação, e precisa de: " + (10 - exercicio.MediaTresNotas(not1, not2, not3)) + " para passar");
                                }
                                else
                                {
                                    Console.WriteLine("Você está aprovado!");
                                }//Fim If
                            }//Fim If
                        break;
                    case 10:
                        double resposta;

                        //Coletando a resposta
                        do
                        {   
                            //Mostrando o menu
                            Console.WriteLine("\n\n ---- Informe a cor correspondente ao CD desejado ---- \n\n" +
                                                                      "1. Verde\n" +
                                                                      "2. Azul\n" +
                                                                      "3. Amarelo\n" +
                                                                      "4. Vermelho\n" +
                                                                      "Escolha uma das opções acima: ");
                            resposta = Convert.ToDouble(Console.ReadLine());

                            if(exercicio.ValidarEntreUmQuatro(resposta) == true)
                            {
                                Console.WriteLine("Informe um valor entre um e quatro!");
                            }//Fim da validação
                        } while(exercicio.ValidarEntreUmQuatro(resposta) == true);
                            //Mostrando so valores em tela
                            if(resposta == 1)
                            {
                                Console.WriteLine("R$ 10,00");
                            }
                            else
                            {
                                if(resposta == 2)
                                {
                                    Console.WriteLine("R$ 20,00");
                                }
                                else
                                {
                                    if(resposta == 3)
                                    {
                                        Console.WriteLine("R$ 30,00");
                                    }
                                    else
                                    {
                                        Console.WriteLine("R$ 40,00");
                                    }
                                }
                            }
                        break;
                    case 11:
                        int numero;

                        do
                        {
                            Console.WriteLine("Informe um número: ");
                            numero = Convert.ToInt32(Console.ReadLine());

                            if (exercicio.ValidarNegativo(numero) == true)
                            {
                                Console.WriteLine("Informe um número positivo");
                            }//Fim da validação
                        } while (exercicio.ValidarNegativo(numero) == true);
                            //Mostrando resultado em tela
                            if(exercicio.ValidarParImpar(numero) == true)
                            {
                                Console.WriteLine("Par!");
                            }
                            else
                            {
                                Console.WriteLine("Ímpar!");
                            }
                        break;
                    case 12:
                        int idade;

                        do
                        {
                            Console.WriteLine("Informe a idade: ");
                            idade = Convert.ToInt32(Console.ReadLine());

                            if (exercicio.ValidarNegativo(idade) == true)
                            {
                                Console.WriteLine("Informe um número positivo!");
                            }//Fim da validação
                        } while (exercicio.ValidarNegativo(idade) == true);
                            //Mostrando se é menor ou maior de idade
                            if(exercicio.MaiorMenorIdade(idade) == true)
                            {
                                Console.WriteLine("Menor de idade");
                            }
                            else
                            {
                                Console.WriteLine("Maior de idade");
                            }
                        break;
                    case 13:
                        double nume1;
                        double nume2;
                        double nume3;

                        //Coletando o primeiro valor
                        Console.WriteLine("Informe o primeiro número");
                        nume1 = Convert.ToDouble(Console.ReadLine());
                        //Coletando o segundo valor
                        Console.WriteLine("Informe o primeiro número");
                        nume2 = Convert.ToDouble(Console.ReadLine());
                        //Coletando o terceiro valor
                        Console.WriteLine("Informe o primeiro número");
                        nume3 = Convert.ToDouble(Console.ReadLine());
                            //Mostrando o maior em tela
                            if(exercicio.MaiorEntreTres(nume1, nume2, nume3) == nume1)
                            {
                                Console.WriteLine("O maior número é: " + nume1);
                            }
                            else
                            {
                                if(exercicio.MaiorEntreTres(nume1, nume2, nume3) == nume1)
                                {
                                    Console.WriteLine("O maior número é: " + nume2);
                                }
                                else
                                {
                                    Console.WriteLine("O maior número é: " + nume3);
                                }
                            }
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é válida!");
                        break;
                }//fim do escolha
            }while (ConsultarOpcao != 0);//fim do DoWhile
        }//fim do metodo 
    }//fim da classe
}//fim do projeto
