class Album
{
    public Album(string nome)
    {
        Nome = nome;
    }

    private List<Musica> musicas = new List<Musica>();

    public Genero genero = new Genero();
    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum '{Nome}' | Gênero: {genero.Nome}\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome}");
        }
        Console.WriteLine($"Para ouvir esse albúm inteiro você precisa de: {DuracaoTotal}");
    }
}