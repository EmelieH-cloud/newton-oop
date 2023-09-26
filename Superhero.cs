namespace Superheroes
{
    internal class Superhero
    {
        string superheroName;
        string superheroPower;

        public Superhero(string superheroName, string superheroPower)
        {
            this.superheroName = superheroName;
            this.superheroPower = superheroPower;
        }

        public string GetSuperheroInfo()
        {
            return $"Name: {this.superheroName} - Power: {this.superheroPower}";
        }
    }
}