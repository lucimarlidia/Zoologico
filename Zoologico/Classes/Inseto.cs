namespace Zoologico.Classes;

public class Inseto : Animal
{
    public Inseto(string nome, string especie) : base(nome, especie)
    {
    }

    public override void DescreverAnimal()
    {
        Console.WriteLine($"Inseto: {Nome} - Espécie: {Especie}");
    }
}
