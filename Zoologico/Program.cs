using Zoologico.Classes;
using Zoologico.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        List<Animal> animais = new List<Animal>();

        // Adicionando alguns animais ao zoológico
        animais.Add(new Mamifero("Bidu", "Cachorro"));
        animais.Add(new MamiferoNadador("Maria", "Baleia"));
        animais.Add(new MamiferoVoador("Joca", "Morcego"));

        animais.Add(new Anfibio("Caco", "Sapo"));
        animais.Add(new AnfibioNadador("Joana", "Salamandra"));

        animais.Add(new Ave("Juju", "Avestruz"));
        animais.Add(new AveVoadora("Pepe", ""));

        animais.Add(new Inseto("Duda", "Formiga"));
        animais.Add(new InsetoVoador("Bia", "Borboleta"));
        
        animais.Add(new Peixe("Nemo", "Peixe"));

        animais.Add(new Reptil("Tom", "Lagarto terrestre"));
        animais.Add(new ReptilNadador("Ana", "Tartaruga marinha"));

        foreach (var animal in animais)
        {
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine($"ANIMAL: {animal.Nome}");

            Console.WriteLine();
            animal.DescreverAnimal();
            Console.WriteLine();
            if (animal is IVoar)
            {
                IVoar voador = (IVoar)animal;
                voador.LevantarVoo();
                voador.Pousar();
                Console.WriteLine();
            }
            if (animal is INadar)
            {
                INadar nadador = (INadar)animal;
                nadador.Nadar();
                nadador.Subir();
                nadador.Descer();
                Console.WriteLine($"Profundidade máxima de nadador: {nadador.ProfundidadeMaxima} metros");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

