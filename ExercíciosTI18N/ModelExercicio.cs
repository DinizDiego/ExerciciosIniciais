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




    }//Fim da classe
}//Fim do Projeto
