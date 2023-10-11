using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercíciosTI18N
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conectar a Control com a Program
            ControlFormulario control = new ControlFormulario();//Instanciando
            control.operacao();

            //Manter aberto
            Console.ReadLine();
        }//Fim do método Main
    }//Fim da classe Progam
}//fim do Projeto
