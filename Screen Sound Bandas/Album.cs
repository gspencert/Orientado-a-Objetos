class Album
{

    private List<Musica> musicas = new List<Musica>();

    public string Nome { get; }

    public Album(string nome)
    {
        Nome = nome;
    }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExiberMusiscasAlbum()
    {
        Console.WriteLine($"Lista de musicas do album {Nome}: \n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
            Console.WriteLine($"Duração: {musica.Duracao}s");
        }
        Console.WriteLine(" ");
        Console.WriteLine($"Pra você ouvir o album inteiro, voce precisa de {DuracaoTotal}s livres!");
    }
}