using Zoologico.Interfaces;

namespace Zoologico.Classes;

public class ReptilNadador : Reptil, INadar
{
    public int ProfundidadeMaxima { get; } = 10;

    public ReptilNadador(string nome, string especie) : base(nome, especie)
    {
    }

    public void Nadar()
    {
        Console.WriteLine($"O réptil {Nome} está nadando...");
    }

    public void Subir()
    {
        Console.WriteLine($"O réptil {Nome} está subindo...");
    }

    public void Descer()
    {
        Console.WriteLine($"O réptil {Nome} está descendo...");
    }

    public override void DescreverAnimal()
    {
        Console.WriteLine($"Réptil nadador: {Nome} - Espécie: {Especie}");
    }
}
