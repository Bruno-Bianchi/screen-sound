class Podcast
{
    List<Episodio> episodios = new List<Episodio>();
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Host { get; set; }
    public string Nome { get; set; }
    public int TotalEpisodios { get; set; }

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
        TotalEpisodios++;
    }

    public void ExbirDetalhes()
    {
        Console.WriteLine($"\nNome do Podcast: {Nome} | Apresentado por: {Host}");

        Console.WriteLine("Episódios listados");
        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine($"Episódio {episodio.Ordem}: {episodio.Titulo}");
        }
        Console.WriteLine($"Total de episódios: {TotalEpisodios}");
    }
}