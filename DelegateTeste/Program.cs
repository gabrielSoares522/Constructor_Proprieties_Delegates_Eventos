using System;
namespace DelegateTeste;
public delegate void operacao(double a,double b);

class Program{

    static void Main(string[] args){
        /* DELEGATES EXEMPLO
        //operacao op = Calculadora.somar;
        operacao op = new operacao(Calculadora.somar);
        
        //op(2,3);
        op.Invoke(2,3);
        
        Console.WriteLine();
        
        op += Calculadora.subtrair;
        op(10,5);
        */

        /*EVENTOS EXEMPLOS*/

        Matematica mat = new Matematica(2,2);
        mat.Somar();
    }    

}