namespace Zoologico.Classes;

public class Mamifero : Animal
{
    public Mamifero(string nome, string especie) : base(nome, especie)
    {
    }

    public override void DescreverAnimal()
    {
        Console.WriteLine($"Mamífero: {Nome} - Espécie: {Especie}");
    }
}
