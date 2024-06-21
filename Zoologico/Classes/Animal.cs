namespace Zoologico.Classes;

public abstract class Animal
{
    public Animal(string nome, string especie)
    {
        Nome = nome;
        Especie = especie;
    }

    public string Nome { get; set; }
    public string Especie { get; set; }

    public abstract void DescreverAnimal();
}
