using Superheroes;

List<Superhero> superheroList = new();
bool isRunning = true;

while (isRunning)
{
    Console.Clear();
    WelcomeUser();
    string response = AskForInput();

    if (response == "a" || response == "A")
    {
        // Lägg till superhjälte
        string superheroName = AskForSuperheroName();
        string superheroPower = AskForSuperheroPower();

        Superhero newSuperhero = new(superheroName, superheroPower);

        // Lägg till den nya superhjälten till en lista med superhjältar
        superheroList.Add(newSuperhero);

        Console.WriteLine("Superhero added!");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
    else if (response == "s" || response == "S")
    {
        // Visa alla superhjältar
        DisplayAllHeroes();
    }
    else
    {
        // Användaren skrev något annat...
    }
}

void DisplayAllHeroes()
{
    foreach (Superhero superhero in superheroList)
    {
        // Displaya lite info om varje hjälte

        string superheroInfo = superhero.GetSuperheroInfo();
        Console.WriteLine(superheroInfo);
    }

    Console.WriteLine("That's all of them!");
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}

string AskForSuperheroPower()
{
    Console.WriteLine("What is the superhero power?");
    Console.Write("Superhero power: ");
    string superheroPower = Console.ReadLine();

    return superheroPower;
}

string AskForSuperheroName()
{
    Console.WriteLine("What is the superhero name?");
    Console.Write("Superhero name: ");
    string superheroName = Console.ReadLine();

    return superheroName;
}

void WelcomeUser()
{
    Console.WriteLine("*************************");
    Console.WriteLine("      SUPERHERO APP      ");
    Console.WriteLine("*************************");
    Console.WriteLine();
}

string AskForInput()
{
    Console.WriteLine("Do you want to (s)how all superheroes, or (a)dd a new one?");
    Console.Write("Response: ");
    string response = Console.ReadLine();

    return response;
}