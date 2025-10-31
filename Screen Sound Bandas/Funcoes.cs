using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

public static class Funcoes
{
    public static Dictionary<string, List<int>> BandasRegistradas = new()
    {
        { "Linkin Park", new List<int> { 10, 8, 6 } },
        { "The Beatles", new List<int>() }
    };

    public static Dictionary<string, List<string>> AlbunsPorBanda = new();

    public static void RegistrarAlbum()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Registro de álbuns");
        Console.Write("Digite a banda cujo álbum deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (BandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;

            if (!AlbunsPorBanda.ContainsKey(nomeDaBanda))
                AlbunsPorBanda.Add(nomeDaBanda, new List<string>());

            AlbunsPorBanda[nomeDaBanda].Add(tituloAlbum);

            Console.WriteLine($"\nO álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada. Registre a banda primeiro.");
        }

        Thread.Sleep(3000);
    }

    public static void RegistrarBanda()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Registro das bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        BandasRegistradas.Add(nomeDaBanda, new List<int>());

        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(3000);
    }

    public static void MostrarBandasRegistradas()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Bandas registradas:");
        foreach (var banda in BandasRegistradas.Keys)
            Console.WriteLine($"- {banda}");

        Console.WriteLine("\nPressione uma tecla para voltar ao menu...");
        Console.ReadKey();
    }

    public static void AvaliarUmaBanda()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Avaliar banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (BandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
            if (int.TryParse(Console.ReadLine(), out int nota))
            {
                BandasRegistradas[nomeDaBanda].Add(nota);
                Console.WriteLine($"\nA nota {nota} foi registrada com sucesso!");
            }
            else
            {
                Console.WriteLine("\nErro: valor inválido.");
            }
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        }

        Thread.Sleep(2000);
    }

    public static void ExibirDetalhes()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Exibir detalhes da banda");
        Console.Write("Digite o nome da banda: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (BandasRegistradas.ContainsKey(nomeDaBanda))
        {
            var notas = BandasRegistradas[nomeDaBanda];
            if (notas.Any())
                Console.WriteLine($"Média da banda {nomeDaBanda}: {notas.Average():F1}");
            else
                Console.WriteLine($"A banda {nomeDaBanda} ainda não possui avaliações.");

            if (AlbunsPorBanda.ContainsKey(nomeDaBanda) && AlbunsPorBanda[nomeDaBanda].Any())
            {
                Console.WriteLine("\nÁlbuns:");
                foreach (var album in AlbunsPorBanda[nomeDaBanda])
                    Console.WriteLine($"- {album}");
            }
            else
            {
                Console.WriteLine("\nNenhum álbum registrado.");
            }
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        }

        Console.WriteLine("\nPressione qualquer tecla para voltar...");
        Console.ReadKey();
    }

    public static void ExibirTituloDaOpcao(string titulo)
    {
        string asteriscos = new string('*', titulo.Length);
        Console.WriteLine($"{asteriscos}\n{titulo}\n{asteriscos}\n");
    }

    public static void ExibirLogo()
    {
        Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
        Console.WriteLine("Boas vindas ao Screen Sound 2.0!\n");
    }
}
