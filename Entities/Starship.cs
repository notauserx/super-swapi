namespace Entities;

public class Starship
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Model { get; set; }

    public string StarshipClass { get; set; }

    public string Manufacturer { get; set; }

    public string CostInCredits { get; set; }

    public string Length { get; set; }

    public string Crew { get; set; }

    public string Passengers { get; set; }

    public string MaxAtmospheringSpeed { get; set; }

    public string HyperdriveRating { get; set; }

    public string MegaLights { get; set; }

    public string CargoCapacity { get; set; }

    public string Consumables { get; set; }

    public ICollection<Film> Films { get; set; }

    public ICollection<People> Pilots { get; set; }

}