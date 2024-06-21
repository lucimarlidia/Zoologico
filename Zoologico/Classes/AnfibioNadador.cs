using Zoologico.Interfaces;

namespace Zoologico.Classes;

public class AnfibioNadador: Anfibio, INadar
{
    public int ProfundidadeMaxima { get; } = 20;

    public AnfibioNadador(string nome, string especie) : base(nome, especie)
    {
    }

    public void Nadar()
    {
        Console.WriteLine($"O anfíbio {Nome} está nadando...");
    }

    public void Subir()
    {
        Console.WriteLine($"O anfíbio {Nome} está subindo...");
    }

    public void Descer()
    {
        Console.WriteLine($"O anfíbio {Nome} está descendo...");
    }

    public override void DescreverAnimal()
    {
        Console.WriteLine($"Anfíbio nadador: {Nome} - Espécie: {Especie}");
    }
}
