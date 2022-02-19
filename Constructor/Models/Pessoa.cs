namespace Constructor.Models
{
    public class Pessoa
    {
        private string Nome {get;set;}
        private string SobreNome{get;set;}

        private int mes;

        public int Mes {
            get{
                return this.mes;
            }
            set{
                if(value >0 && value <= 12){
                    this.mes = value;
                }
            }
        }

        /*public Pessoa(){
            this.Nome = "";
            this.SobreNome = "";
        }*/

        public Pessoa(string nome,string sobreNome){
            this.Nome = nome;
            this.SobreNome = sobreNome;
            Console.WriteLine("Utilizando classe Pessoa");
        }

        public void Apresentar(){
            Console.WriteLine($"Ola meu nome {this.Nome} {this.SobreNome}");
        }
    }
}