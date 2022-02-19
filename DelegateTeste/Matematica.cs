using System;

namespace DelegateTeste
{
    public class Matematica
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Matematica(double x,double y)
        {
            this.X = x;
            this.Y = y;
            Calculadora.EventoCalculadora += EventHandler;
        }

        public void Somar()
        {
            Calculadora.somar(X,Y);
        }

        public void EventHandler(){
            Console.WriteLine("Evento ativado");
        }
    }
}