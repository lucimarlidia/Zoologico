using Zoologico.Interfaces;

namespace Zoologico.Classes;

public class InsetoVoador : Mamifero, IVoar
{
    public InsetoVoador(string nome, string especie) : base(nome, especie)
    {
    }

    public void LevantarVoo()
    {
        Console.WriteLine($"O inseto {Nome} está levantando voo...");
    }

    public void Pousar()
    {
        Console.WriteLine($"O inseto {Nome} está pousando...");
    }

    public override void DescreverAnimal()
    {
        Console.WriteLine($"Inseto voador: {Nome} - Espécie: {Especie}");
    }
}

