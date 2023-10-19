using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosTI18N
{
    internal class ModelExercicio
    {
        public ModelExercicio()
        {

        }//Fim do construtor


        //Exercício 1 - Média de duas notas
        public double MediaDuasNotas(double nota1, double nota2)
        {
            return (nota1 + nota2) / 2;
        }//fim do método média

        //Método de validação
        public Boolean ValidarNotas(double nota) 
        { 
            if((nota < 0) || (nota > 10))
            {
                return true;
            }
            else
            {
                return false;
            }
        }//Fim do método 

        //Método de validação de negativos
        public Boolean ValidarNegativo(double num)
        {
            if(num <= 0)
            {
                return true;    
            }
            else
            {
                return false;
            }
        }//Fim do método

        //Exercício 2
        public int Comparar(int num1, int num2)
        {
            if(num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }//fim do comparar

        //Exercício 3
        public int Antecessor(int num)
        {
            return num - 1;
        }//fim do Antecessor

        //Exercício 4
        public double CalcArea(double numA, double numB)
        {
            return numA * numB;
        }//Fim do CalcArea

        //Exercício 5
        public Boolean validarTotalE(double totalE, double branco, double nulo, double valido)
        {
            if((branco + nulo + valido) < totalE || (branco + nulo + valido) > totalE)
            {
                return true;
            }
            else
            {
                return false;
            }
        }//Fim do totalE

        //Método para cálculo de Percentual de Votos Brancos
        public double PBranco(double totalE, double branco)
        {
            return (branco / totalE) * 100;
        }//Fim do PBranco

        //Método para cálculo de Percentual de Votos Validos
        public double PValido(double totalE, double valido)
        {
            return (valido / totalE) * 100;
        }//Fim do PBranco

        //Método para cálculo de Percentual de Votos Nulos
        public double PNulo(double totalE, double nulo)
        {
            return (nulo / totalE) * 100;
        }//Fim do PBranco

        //Exercício 6
        public double ReajusteFuncionario(double salario, double reajuste)
        {
            return salario * (reajuste/100) + salario;
        }//Fim do método

        //Exercício 7
        public double CustoFinalCarro(double PImpostos, double PDistribuidor, double custoDeFabrica)
        {
            return custoDeFabrica + (custoDeFabrica * (PDistribuidor / 100) + (custoDeFabrica * (PImpostos / 100)));
        }//Fim do método

        //Exercício 8
        public double salarioFinal(double salario, double valorPorCarro, double qntCarros, double comissao, double totalDeVendas)
        {
            return salario + (valorPorCarro * qntCarros) + (comissao * totalDeVendas);
        }//Fim do método

        //Exercício 9
        public double MediaTresNotas(double nota1, double nota2, double nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }//Fim do método

        //Validar entre 0 e 10 
        public Boolean ValidarEntreZeroDez(double num)
        {
            if((num < 0) || (num > 10))
            {
                return true;
            }
            else
            {
                return false;
            }
        }//Fim do método

        //Exercício 10
        //Validar entre 1 e 4 
        public Boolean ValidarEntreUmQuatro(double num)
        {
            if ((num < 1) || (num > 4))
            {
                return true;
            }
            else
            {
                return false;
            }
        }//Fim do método

        //Exercício 11
        public Boolean ValidarParImpar(int num)
        {
            if(num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }//Fim da validação
        }//Fim do método 

        //Exercício 12
        public Boolean MaiorMenorIdade(int num)
        {
            if(num < 18)
            {
                return true;
            }
            else
            {
                return false;
            }//Fim da validação
        }//Fim do método

        //Exercício 13
        public double MaiorEntreTres(double num1, double num2, double num3)
        {
            if((num1 > num2) || (num1 > num3))
            {
                return num1;
            }
            else
            {
                if((num2 > num1) || (num2 > num3))
                {
                    return num2;
                }
                else
                {
                    return num3;
                }
            }
        }//Fim do método

    }//Fim da classe
}//Fim do Projeto
