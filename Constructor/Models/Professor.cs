namespace Constructor.Models
{
    public class Professor:Pessoa
    {
        public Professor(string nome,string sobreNome): base(nome,sobreNome){
            
            Console.WriteLine("Utilizando classe Professor");
        }
    }
}