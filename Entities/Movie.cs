#nullable disable

namespace ApiWithFastEndpoints.Entities;

public class Movie
{
    public long Id { get; set; }
    public string ImdbId { get; set; }
    public string Title { get; set; }
    public string Director { get; set; }
    public int Year { get; set;}
    public string Rating { get; set; }
    public string Genres { get; set; }
    public int Runtime { get; set; }
    public string Country { get; set; }
    public string Language { get; set; }
    public double ImdbScore { get; set; }
    public double ImdbVotes { get; set; }
    public double MetacriticStore { get; set; }
}