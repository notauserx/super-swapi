namespace Entities;

public class Species
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Classification { get; set; }

    public string Designation { get; set; }

    public string AverageHeight { get; set; }

    public string AverageLifespan { get; set; }

    public string EyeColors { get; set; }

    public string HairColors { get; set; }

    public string SkinColors { get; set; }

    public string Language { get; set; }

    public string Homeworld { get; set; }
    
    public ICollection<People> People { get; set; }

    public ICollection<Film> Films { get; set; }

}
