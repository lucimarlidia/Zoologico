using Zoologico.Interfaces;

namespace Zoologico.Classes;

public class MamiferoVoador : Mamifero, IVoar
{
    public MamiferoVoador(string nome, string especie) : base(nome, especie)
    {
    }

    public void LevantarVoo()
    {
        Console.WriteLine($"O mamífero {Nome} está levantando voo...");
    }

    public void Pousar()
    {
        Console.WriteLine($"O mamífero {Nome} está pousando...");
    }

    public override void DescreverAnimal()
    {
        Console.WriteLine($"Mamífero voador: {Nome} - Espécie: {Especie}");
    }
}

