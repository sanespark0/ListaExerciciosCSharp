using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int opcao;
        do
        {
            Console.Clear();
            Console.WriteLine("===== LISTA DE EXERCÍCIOS — FUNDAMENTOS DE C# =====");
            Console.WriteLine("1  - Apresentação pessoal");
            Console.WriteLine("2  - Calculando uma compra");
            Console.WriteLine("3  - Classificação de notas");
            Console.WriteLine("4  - Tabuada");
            Console.WriteLine("5  - Adivinhe o número");
            Console.WriteLine("6  - Calculadora com métodos");
            Console.WriteLine("7  - Cadastro de notas em um array");
            Console.WriteLine("8  - Análise de números");
            Console.WriteLine("9  - Lista de produtos");
            Console.WriteLine("10 - Busca de produtos");
            Console.WriteLine("0  - Sair");
            Console.Write("\nEscolha uma opção: ");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Opção inválida! Pressione ENTER para continuar...");
                Console.ReadLine();
                continue;
            }

            Console.Clear();

            switch (opcao)
            {
                case 1:  Exercicio1(); break;
                case 2:  Exercicio2(); break;
                case 3:  Exercicio3(); break;
                case 4:  Exercicio4(); break;
                case 5:  Exercicio5(); break;
                case 6:  Exercicio6(); break;
                case 7:  Exercicio7(); break;
                case 8:  Exercicio8(); break;
                case 9:  Exercicio9(); break;
                case 10: Exercicio10(); break;
                case 0:  Console.WriteLine("Encerrando... Até logo!"); break;
                default:
                    Console.WriteLine("Opção inexistente!");
                    break;
            }

            if (opcao != 0)
            {
                Console.WriteLine("\nPressione ENTER para voltar ao menu...");
                Console.ReadLine();
            }

        } while (opcao != 0);
    }

    // ===================== Exercício 1 =====================
    static void Exercicio1()
    {
        Console.WriteLine("--- Exercício 1: Apresentação pessoal ---");
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Digite sua cidade: ");
        string cidade = Console.ReadLine();

        Console.WriteLine($"\nOlá, {nome}! Você tem {idade} anos e mora em {cidade}.");
    }

    // ===================== Exercício 2 =====================
    static void Exercicio2()
    {
        Console.WriteLine("--- Exercício 2: Calculando uma compra ---");
        Console.Write("Nome do produto: ");
        string produto = Console.ReadLine();

        Console.Write("Quantidade comprada: ");
        int quantidade = int.Parse(Console.ReadLine());

        Console.Write("Preço unitário: ");
        decimal preco = decimal.Parse(Console.ReadLine());

        decimal total = quantidade * preco;

        Console.WriteLine($"\nProduto: {produto}");
        Console.WriteLine($"Quantidade: {quantidade}");
        Console.WriteLine($"Preço unitário: {preco:C2}");
        Console.WriteLine($"Valor total: {total:C2}");
    }

    // ===================== Exercício 3 =====================
    static void Exercicio3()
    {
        Console.WriteLine("--- Exercício 3: Classificação de notas ---");
        Console.Write("Nome do aluno: ");
        string aluno = Console.ReadLine();

        Console.Write("Nota (0 a 10): ");
        double nota = double.Parse(Console.ReadLine());

        if (nota < 0 || nota > 10)
            Console.WriteLine("Nota inválida! Informe um valor entre 0 e 10.");
        else if (nota >= 7)
            Console.WriteLine($"{aluno}: Aprovado");
        else if (nota >= 5)
            Console.WriteLine($"{aluno}: Recuperação");
        else
            Console.WriteLine($"{aluno}: Reprovado");
    }

    // ===================== Exercício 4 =====================
    static void Exercicio4()
    {
        Console.WriteLine("--- Exercício 4: Tabuada ---");
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine();
        for (int i = 1; i <= 10; i++)
            Console.WriteLine($"{numero} x {i} = {numero * i}");
    }

    // ===================== Exercício 5 =====================
    static void Exercicio5()
    {
        Console.WriteLine("--- Exercício 5: Adivinhe o número ---");
        int secreto = 42;
        int tentativa;
        int contador = 0;

        Console.WriteLine("Adivinhe o número secreto (entre 0 e 100)!");

        do
        {
            Console.Write("Sua tentativa: ");
            tentativa = int.Parse(Console.ReadLine());
            contador++;

            if (tentativa < secreto)
                Console.WriteLine("O número secreto é MAIOR.");
            else if (tentativa > secreto)
                Console.WriteLine("O número secreto é MENOR.");
            else
                Console.WriteLine($"Parabéns! Você acertou em {contador} tentativa(s).");
        }
        while (tentativa != secreto);
    }

    // ===================== Exercício 6 =====================
    static void Exercicio6()
    {
        Console.WriteLine("--- Exercício 6: Calculadora com métodos ---");
        Console.Write("Primeiro número: ");
        double n1 = double.Parse(Console.ReadLine());

        Console.Write("Segundo número: ");
        double n2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"\nSoma: {Somar(n1, n2)}");
        Console.WriteLine($"Multiplicação: {Multiplicar(n1, n2)}");
    }

    static double Somar(double a, double b) => a + b;
    static double Multiplicar(double a, double b) => a * b;

    // ===================== Exercício 7 =====================
    static void Exercicio7()
    {
        Console.WriteLine("--- Exercício 7: Cadastro de notas em um array ---");
        double[] notas = new double[3];

        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write($"Digite a {i + 1}ª nota: ");
            notas[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nNotas digitadas (for):");
        for (int i = 0; i < notas.Length; i++)
            Console.WriteLine($"- {notas[i]}");

        double soma = 0;
        foreach (double nota in notas)
            soma += nota;

        double media = soma / notas.Length;
        Console.WriteLine($"\nMédia (foreach): {media:F2}");
    }

    // ===================== Exercício 8 =====================
    static void Exercicio8()
    {
        Console.WriteLine("--- Exercício 8: Análise de números ---");
        int[] numeros = new int[5];

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Digite o {i + 1}º número inteiro: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nValores armazenados:");
        foreach (int n in numeros)
            Console.WriteLine($"- {n}");

        int pares = 0;
        int maior = numeros[0];

        foreach (int n in numeros)
        {
            if (n % 2 == 0) pares++;
            if (n > maior) maior = n;
        }

        Console.WriteLine($"\nQuantidade de pares: {pares}");
        Console.WriteLine($"Maior número: {maior}");
    }

    // ===================== Exercício 9 =====================
    static void Exercicio9()
    {
        Console.WriteLine("--- Exercício 9: Lista de produtos ---");
        List<string> produtos = new List<string>();

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Digite o {i + 1}º produto: ");
            produtos.Add(Console.ReadLine());
        }

        Console.WriteLine("\nProdutos cadastrados:");
        foreach (string p in produtos)
            Console.WriteLine($"- {p}");

        Console.Write("\nDigite um produto para verificar se está na lista: ");
        string busca = Console.ReadLine();
        if (produtos.Contains(busca))
            Console.WriteLine($"\"{busca}\" está na lista.");
        else
            Console.WriteLine($"\"{busca}\" NÃO está na lista.");

        Console.Write("\nDigite um produto para remover: ");
        string remover = Console.ReadLine();
        if (produtos.Remove(remover))
            Console.WriteLine($"Produto \"{remover}\" removido.");
        else
            Console.WriteLine($"Produto \"{remover}\" não encontrado.");

        Console.WriteLine("\nLista atualizada:");
        foreach (string p in produtos)
            Console.WriteLine($"- {p}");
    }

    // ===================== Exercício 10 =====================
    static void Exercicio10()
    {
        Console.WriteLine("--- Exercício 10: Busca de produtos ---");
        List<string> produtos = new List<string>
        {
            "Notebook",
            "Mouse",
            "Teclado",
            "Monitor",
            "Webcam"
        };

        Console.WriteLine("Produtos disponíveis:");
        foreach (string p in produtos)
            Console.WriteLine($"- {p}");

        Console.Write("\nDigite o nome (ou parte do nome) do produto: ");
        string busca = Console.ReadLine();

        string encontrado = produtos.Find(p =>
            p.Contains(busca, StringComparison.OrdinalIgnoreCase));

        if (encontrado != null)
            Console.WriteLine($"Produto encontrado: {encontrado}");
        else
            Console.WriteLine("Nenhum produto foi localizado.");
    }
}
