namespace WordProcessor.Сore.Models;

public record Word
{
    public int Id { get; set; }
    public string Symbols { get; set; }
    public int UsageFrequency { get; set; }
}