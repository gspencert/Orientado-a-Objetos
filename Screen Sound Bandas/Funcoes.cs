Dictionary<string, List<int>> bandasRegistradas;
Dictionary<string, List<string>> albunsPorBanda;

void RegistrarAlbum()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de �lbuns");
    Console.Write("Digite a banda cujo �lbum deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write("Agora digite o t�tulo do �lbum: ");
        string tituloAlbum = Console.ReadLine()!;

        if (!albunsPorBanda.ContainsKey(nomeDaBanda))
        {
            albunsPorBanda.Add(nomeDaBanda, new List<string>());
        }

        albunsPorBanda[nomeDaBanda].Add(tituloAlbum);

        Console.WriteLine($"O �lbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} n�o foi encontrada. Registre a banda primeiro.");
    }

    Thread.Sleep(4000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das bandas");

    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;

    bandasRegistradas.Add(nomeDaBanda, new List<int>());

    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");

    Thread.Sleep(4000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplica��o");

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');

    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");

        if (int.TryParse(Console.ReadLine(), out int nota))
        {
            bandasRegistradas[nomeDaBanda].Add(nota);
            Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        }
        else
        {
            Console.WriteLine("\nErro: A nota digitada n�o � um n�mero v�lido.");
        }

        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} n�o foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirDetalhes()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir detalhes da banda");
    Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];

        if (notasDaBanda.Any())
        {
            Console.WriteLine($"\nA m�dia da banda {nomeDaBanda} � {notasDaBanda.Average():F1}.");
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} ainda n�o possui avalia��es.");
        }

        if (albunsPorBanda.ContainsKey(nomeDaBanda) && albunsPorBanda[nomeDaBanda].Any())
        {
            Console.WriteLine($"\n�lbuns registrados para {nomeDaBanda}:");
            foreach (var album in albunsPorBanda[nomeDaBanda])
            {
                Console.WriteLine($"- {album}");
            }
        }
        else
        {
            Console.WriteLine($"\nNenhum �lbum registrado para a banda {nomeDaBanda}.");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} n�o foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

ExibirOpcoesDoMenu();