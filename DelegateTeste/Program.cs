namespace DelegateTeste;
public delegate void operacao(double a,double b);

class Program{

    static void Main(string[] args){
        //operacao op = Calculadora.somar;
        operacao op = new operacao(Calculadora.somar);
        
        //op(2,3);
        op.Invoke(2,3);
        
        Console.WriteLine();
        
        op += Calculadora.subtrair;
        op(10,5);
    }    

}