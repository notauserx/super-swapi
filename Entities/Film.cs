namespace Entities;

public class Film
{
    public Guid Id { get; set; } 

    public string Title { get; set; }

    public string EpisodeId { get; set; }

    public string OpeningCrawl { get; set; }

    public string Director { get; set; }

    public string Producer { get; set; }

    public string ReleaseDate { get; set; }

    public ICollection<Species> Species { get; set; }

    public ICollection<Starship> Starships { get; set; }

    public ICollection<Vehicle> Vehicles { get; set; }

    public ICollection<People> Characters { get; set; }

    public ICollection<Planet> Planets { get; set; }
}
