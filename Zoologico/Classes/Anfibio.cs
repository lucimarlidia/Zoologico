namespace Zoologico.Classes;

public class Anfibio : Animal
{
    public Anfibio(string nome, string especie) : base(nome, especie)
    {
    }

    public override void DescreverAnimal()
    {
        Console.WriteLine($"Anfíbio: {Nome} - Espécie: {Especie}");
    }
}
