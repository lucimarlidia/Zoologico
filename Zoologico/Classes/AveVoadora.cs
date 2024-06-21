using Zoologico.Interfaces;

namespace Zoologico.Classes;

public class AveVoadora : Mamifero, IVoar
{
    public AveVoadora(string nome, string especie) : base(nome, especie)
    {
    }

    public void LevantarVoo()
    {
        Console.WriteLine($"A ave {Nome} está levantando voo...");
    }

    public void Pousar()
    {
        Console.WriteLine($"A ave {Nome} está pousando...");
    }

    public override void DescreverAnimal()
    {
        Console.WriteLine($"Ave voadora: {Nome} - Espécie: {Especie}");
    }
}
