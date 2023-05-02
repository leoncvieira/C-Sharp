namespace Variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Show");
            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());


            if (idade >= 18)
            {
                Console.WriteLine("Sua idade permite entrar no show, seja bem vindo " + nome + "!");
            }
            else
            {
                Console.WriteLine("Você esta acompanhado por um adulto?");
                string acompanhado = Console.ReadLine();

                if (acompanhado == "sim")
                {
                    Console.WriteLine("Como voce esta acompanhado, pode entrar!");
                }
                else
                {
                    Console.WriteLine("Que pena " + nome + ", infelizmente não será possivel entrar no show.");
                }
            }

        }
    }
}