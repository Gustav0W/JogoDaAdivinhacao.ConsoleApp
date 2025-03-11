namespace JogoDaAdivinhacao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=============================");
                Console.WriteLine("     Jogo da Adivinhação     ");
                Console.WriteLine("=============================");

                //Dificuldade
                Console.WriteLine("Escolha um nivel de dificuldade  ");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1 - Fácil (10 tentativas)");
                Console.WriteLine("2 - Médio (5 tentativas)");
                Console.WriteLine("3 - Difícil (3 tentativas)");
                Console.Write("Digite sua escolha: ");
                string opcaoDificuldade = Console.ReadLine();
                byte totalTentativas = 0;

                if (opcaoDificuldade == "1")
                    totalTentativas = 10;
                else if (opcaoDificuldade == "2")
                    totalTentativas = 5;
                else
                    totalTentativas = 3;

                    //Gerar o número aleatório
                    Random geradorNumeros = new Random();

                int numeroSecreto = geradorNumeros.Next(1, 21);

                for (int tentativa = 1; tentativa <= totalTentativas; tentativa++)
                {
                    Console.WriteLine("=============================");
                    Console.WriteLine("     Jogo da Adivinhação     ");
                    Console.WriteLine("=============================");
                    Console.WriteLine("===========================================");
                    Console.WriteLine($"Tentativa {tentativa} de {totalTentativas}");
                    Console.WriteLine("===========================================");

                    //Digitar o número
                    Console.Write("Digite um número: ");
                    int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"Você digitou o número {numeroDigitado}");

                    //Verificação de acerto
                    if (numeroDigitado == numeroSecreto)
                    {
                        
                        Console.WriteLine("==================================================");
                        Console.WriteLine("VAMBORAAAAAAA Você acertou o número secreto");
                        Console.WriteLine("==================================================");
                        break;
                    }
                    if (tentativa >= totalTentativas)
                    {
                        Console.WriteLine("==================================================");
                        Console.WriteLine($"Você perdeu, que tristeza! O número era {numeroSecreto}");
                        break;
                    }
                    else if (numeroDigitado > numeroSecreto)
                    {
                        Console.WriteLine("==================================================");
                        Console.WriteLine("O número que você digitou é MAIOR que o secreto...");
                        Console.WriteLine("==================================================");
                    }
                    else if (numeroDigitado < numeroSecreto)
                    {
                        Console.WriteLine("==================================================");
                        Console.WriteLine("O número que você digitou é MENOR que o secreto...");
                        Console.WriteLine("==================================================");
                    }
                    Console.WriteLine("Aperte enter para continuar ");
                    Console.ReadLine();
                    Console.Clear();


                }
                    Console.Write("Deseja continuar ? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                {
                    break;
                }
            }
        }
    }
}
