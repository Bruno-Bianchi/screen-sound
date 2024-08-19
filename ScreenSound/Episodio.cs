class Episodio
{
    List<string> convidados = new List<string>();

    public Episodio(string? titulo, int duracao, int ordem)
    {
        Titulo = titulo;
        Duracao = duracao;
        Ordem = ordem;
    }

    public string? Titulo { get; }
    public int Duracao { get; }
    public int Ordem { get; }
    public string? Resumo => $"\nTítulo:{Titulo}\n Ordem: {Ordem}\n Duração: {Duracao} min\n Convidados: {string.Join(",", convidados)}";

    public void AdicionarConvidados(string nomeConvidado)
    {
        convidados.Add(nomeConvidado);
    }
}