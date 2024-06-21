using Zoologico.Interfaces;

namespace Zoologico.Classes;

public class Peixe : Animal, INadar
{
    public int ProfundidadeMaxima { get; } = 200;

    public Peixe(string nome, string especie) : base(nome, especie)
    {
    }

    public void Nadar()
    {
        Console.WriteLine($"O peixe {Nome} está nadando...");
    }

    public void Descer()
    {
        Console.WriteLine($"O peixe {Nome} está descendo...");
    }

    public void Subir()
    {   
        Console.WriteLine($"O peixe {Nome} está subindo...");
    }

    public override void DescreverAnimal()
    {
        Console.WriteLine($"Peixe: {Nome} - Espécie: {Especie}");
    }
}
