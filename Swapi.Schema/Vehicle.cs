namespace Swapi.Schema;

public class Vehicle
{
    public string Name { get; set; }

    public string Model { get; set; }

    public string VehicleClass { get; set; }

    public string Manufacturer { get; set; }

    public string Length { get; set; }

    public string CostInCredits { get; set; }

    public string Crew { get; set; }
    
    public string Passengers { get; set; }

    public string MaxAtmospheringSpeed { get; set; }

    public string CargoCapacity { get; set; }

    public string Consumables { get; set; }

    public ICollection<string> Films { get; set; }

    public ICollection<string> Pilots { get; set; }

}