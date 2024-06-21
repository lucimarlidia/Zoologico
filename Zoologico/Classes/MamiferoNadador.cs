using Zoologico.Interfaces;

namespace Zoologico.Classes;

public class MamiferoNadador : Animal, INadar
{
    public int ProfundidadeMaxima { get; } = 50;

    public MamiferoNadador(string nome, string especie) : base(nome, especie)
    {
    }

    public void Nadar()
    {
        Console.WriteLine($"O mamífero {Nome} está nadando...");
    }

    public void Descer()
    {
        Console.WriteLine($"O mamífero {Nome} está descendo...");
    }

    public void Subir()
    {
        Console.WriteLine($"O mamífero {Nome} está subindo...");
    }

    public override void DescreverAnimal()
    {
        Console.WriteLine($"Mamífero nadador: {Nome} - Espécie: {Especie}");
    }
}
