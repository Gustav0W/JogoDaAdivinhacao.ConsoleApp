namespace JogoDaAdivinhacao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string opcaoDificuldade = MenuInicial();
                byte totalTentativas = DefinirTentativas(opcaoDificuldade);

                Jogar(totalTentativas);

                if (!DesejaContinuar())
                {
                    break;
                }
            }
        }

        //Estruturado

        static void Cabecalho()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("     Jogo da Adivinhação     ");
            Console.WriteLine("=============================");
        }
        static string MenuInicial()
        {
            Console.Clear();
            Cabecalho();

            //Dificuldade
            Console.WriteLine("Escolha um nivel de dificuldade  ");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1 - Fácil (10 tentativas)");
            Console.WriteLine("2 - Médio (5 tentativas)");
            Console.WriteLine("3 - Difícil (3 tentativas)");
            Console.Write("Digite sua escolha: ");
            string opcaoDificuldade = Console.ReadLine();

            return opcaoDificuldade;
        }

        static byte DefinirTentativas(string opcaoDificulade)
        {
            return opcaoDificulade switch
            {
                "1" => 10,
                "2" => 5,
                _ => 3
            };
        }

        static int ObterNumeroUsuario()
        {
            while (true)
            {
                Console.Write("Digite um número: ");
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    return numero;
                }
                Console.WriteLine("Entrada inválida, digite um número válido");
            }
        }
        static void Jogar(byte totalTentativas)
        {
            Random geradorNumeros = new Random();
            int numeroSecreto = geradorNumeros.Next(1, 21);

            for (int tentativa = 1; tentativa <= totalTentativas; tentativa++)
            {
                Console.Clear();
                Cabecalho();
                Console.WriteLine($"Tentativa {tentativa} de {totalTentativas}");
                int numeroDigitado = ObterNumeroUsuario();

                if (numeroDigitado == numeroSecreto)
                {

                    Console.WriteLine("==================================================");
                    Console.WriteLine("VAMBORAAAAAAA Você acertou o número secreto");
                    Console.WriteLine("==================================================");
                    return;
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

        }
        static bool DesejaContinuar()
        {
            Console.Write("Deseja continuar ? (S/N): ");
            return Console.ReadLine().ToUpper() == "S";
        }
    }
}
