using System;
using System.Threading;

bool executando = true;

while (executando)
{
    Console.Clear();
    Funcoes.ExibirLogo();

    Console.WriteLine("1- Registrar banda");
    Console.WriteLine("2- Registrar álbum");
    Console.WriteLine("3- Listar bandas");
    Console.WriteLine("4- Avaliar banda");
    Console.WriteLine("5- Exibir detalhes");
    Console.WriteLine("6- Sair");
    Console.Write("\nEscolha uma opção: ");

    if (int.TryParse(Console.ReadLine(), out int opcao))
    {
        switch (opcao)
        {
            case 1: Funcoes.RegistrarBanda(); break;
            case 2: Funcoes.RegistrarAlbum(); break;
            case 3: Funcoes.MostrarBandasRegistradas(); break;
            case 4: Funcoes.AvaliarUmaBanda(); break;
            case 5: Funcoes.ExibirDetalhes(); break;
            case 6:
                Console.WriteLine("Saindo :)");
                Thread.Sleep(1000);
                executando = false;
                break;
            default:
                Console.WriteLine("Opção inválida.");
                Thread.Sleep(1000);
                break;
        }
    }
    else
    {
        Console.WriteLine("Entrada inválida.");
        Thread.Sleep(1000);
    }
}