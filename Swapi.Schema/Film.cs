namespace Entities;

public class Film
{
    public string Title { get; set; }

    public string EpisodeId { get; set; }

    public string OpeningCrawl { get; set; }

    public string Director { get; set; }

    public string Producer { get; set; }

    public string ReleaseDate { get; set; }

    public ICollection<string> Species { get; set; }

    public ICollection<string> Starships { get; set; }

    public ICollection<string> Vehicles { get; set; }

    public ICollection<string> Characters { get; set; }

    public ICollection<string> Planets { get; set; }
}
