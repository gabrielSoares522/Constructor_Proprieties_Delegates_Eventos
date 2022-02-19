using System;
namespace DelegateTeste
{
    public class Calculadora
    {
        public delegate void DelegateCalculadora();

        public static event DelegateCalculadora EventoCalculadora;

        public static void somar(double a,double b){
            if(EventoCalculadora != null){
                Console.WriteLine($"{a} + {b} = {a+b}");
                EventoCalculadora();
            }
            else{
                Console.WriteLine("Nenhum inscrito no evento");
            }
        }
        public static void subtrair(double a,double b){
            Console.WriteLine($"{a} - {b} = {a-b}");
        }
    }
}