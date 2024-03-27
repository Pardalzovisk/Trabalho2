using Trabalho2;
class Menu
{
    static void Main(string[] args)
    { 
        int opcao;

        do
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("0) Sair");
            Console.WriteLine("1) Somar números");
            Console.WriteLine("2) Converter de metros para milímetros");
            Console.WriteLine("3) Verificar aposentadoria");
            Console.Write("Opção: ");

            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    case 1:
                        SomaInt somar = new SomaInt();
                        Console.Write("Digite o primeiro número: ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        int num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultado da soma: {somar.Somar(num1, num2)}");
                        break;
                    case 2:
                        MetroMM metro = new MetroMM();
                        Console.Write("Digite o valor em metros: ");
                        int metros = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Valor em milímetros: {metro.ConverterMetrosParaMilimetros(metros)}");
                        break;
                    case 3:
                        Aposenta aposenta = new Aposenta();
                        Console.Write("Digite a idade: ");
                        int idade = int.Parse(Console.ReadLine());
                        Console.Write("Digite os anos de contribuição: ");
                        int anosContribuicao = int.Parse(Console.ReadLine());
                        if (aposenta.PodeSeAposentar(idade, anosContribuicao))
                        {
                            Console.WriteLine("Pode se aposentar!");
                        }
                        else
                        {
                            Console.WriteLine("Não pode se aposentar.");
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }

            Console.WriteLine();
        } while (opcao != 0);
    }
}