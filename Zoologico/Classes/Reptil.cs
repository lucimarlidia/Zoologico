namespace Zoologico.Classes;

public class Reptil : Animal
{
    public Reptil(string nome, string especie) : base(nome, especie)
    {
    }

    public override void DescreverAnimal()
    {
        Console.WriteLine($"Réptil: {Nome} - Espécie: {Especie}");
    }
}
