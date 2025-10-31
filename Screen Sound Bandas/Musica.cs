class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida =>
        $"A música {Nome} pertence a banda {Artista}.";
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duracao: {Duracao}s");
        if (Disponivel)
        {
            Console.WriteLine("Musica disponível no plano.");
        } else
        {
            Console.WriteLine("Adquira o plano Plus+ para ouvir essa música.");
            Console.WriteLine("");
        }
    }
}
