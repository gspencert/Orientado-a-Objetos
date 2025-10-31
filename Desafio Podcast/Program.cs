Episodio ep1 = new(1, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("Guilherme");
ep1.AdicionarConvidados("Fernanda");

Episodio ep2 = new(2, "Técnicas de aprendizado", 89);
ep2.AdicionarConvidados("Fernando");
ep2.AdicionarConvidados("Andrei");

Podcast podcast = new("Especial", "Daniel");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2); 
podcast.ExibirDetalhes();