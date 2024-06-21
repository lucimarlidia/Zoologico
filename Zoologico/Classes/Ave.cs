namespace Zoologico.Classes;

public class Ave : Animal
{
    public Ave(string nome, string especie) : base(nome, especie    )
    {
    }

    public override void DescreverAnimal()
    {
        Console.WriteLine($"Ave: {Nome} - Espécie: {Especie}");
    }
}
