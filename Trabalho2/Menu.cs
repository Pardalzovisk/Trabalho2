using Trabalho2;
class Menu
{
    static void Main(string[] args)
    {
        Exercicios exercicios = new Exercicios();
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
                        Console.Write("Digite o primeiro número: ");
                        int num1 = int.Parse(Console.ReadLine());
                        Console.Write("Digite o segundo número: ");
                        int num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultado da soma: {exercicios.Somar(num1, num2)}");
                        break;
                    case 2:
                        Console.Write("Digite o valor em metros: ");
                        int metros = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Valor em milímetros: {exercicios.ConverterMetrosParaMilimetros(metros)}");
                        break;
                    case 3:
                        Console.Write("Digite a idade: ");
                        int idade = int.Parse(Console.ReadLine());
                        Console.Write("Digite os anos de contribuição: ");
                        int anosContribuicao = int.Parse(Console.ReadLine());
                        if (exercicios.PodeSeAposentar(idade, anosContribuicao))
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