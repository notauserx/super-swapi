namespace Entities;

public class People
{
    public string Name { get; set; }

    public string BirthYear { get; set; }

    public string EyeColor { get; set; }

    public string Gender { get; set; }

    public string HairColor { get; set; }

    public string Height { get; set; }

    public string Mass { get; set; }

    public string SkinColor { get; set; }

    public string Homeworld { get; set; }

    public ICollection<Film> Films { get; set; }

    public ICollection<Species> Species { get; set; }

    public ICollection<Starship> Starships { get; set; }

    public ICollection<Vehicle> Vehicles { get; set; }

}
