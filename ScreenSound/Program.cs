Banda queen = new Banda("Queen");

Album albumQueen = new Album("A night at the opera");
albumQueen.genero.Nome = "Rock End Row";

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
};

albumQueen.AdicionarMusica(musica1);
albumQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

albumQueen.ExibirMusicasAlbum();
queen.ExibirDiscografia();

Playlist playlist1 = new Playlist("ROCK");
playlist1.AdicionarMusica(musica1);
playlist1.ExibirPlaylist();


Episodio episodio1 = new Episodio("Episódio One", 130, 1);

episodio1.AdicionarConvidados("Bruno");
episodio1.AdicionarConvidados("Amanda");
Console.WriteLine($"\nResumo do Episódio {episodio1.Resumo}");

Episodio episodio2 = new Episodio("Episódio Two", 45, 2);

episodio2.AdicionarConvidados("Evelyn");
Console.WriteLine($"\nResumo do Episódio {episodio2.Resumo}");

Podcast podcast1 = new Podcast("Flow Podcast", "Estúdio Flow");
podcast1.AdicionarEpisodio(episodio1);
podcast1.AdicionarEpisodio(episodio2);
podcast1.ExbirDetalhes();

