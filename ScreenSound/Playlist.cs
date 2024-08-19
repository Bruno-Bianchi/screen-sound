class Playlist
{
    List<Musica> playlist = new List<Musica>();

    public Playlist(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; set; }

    public void AdicionarMusica(Musica musica)
    {
        playlist.Add(musica);
    }

    public void ExibirPlaylist()
    {
        Console.WriteLine($"\nLista de músicas da Playlist '{Nome}'");
        foreach (Musica musica in playlist)
        {
            Console.WriteLine($"Musica: {musica.Nome}");
        }
    }
}