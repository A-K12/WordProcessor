namespace WordProcessor.Core.Models;

public class Word
{
    public int Id { get; set; }
    public string? Symbols { get; set; }
    public int UsageFrequency { get; set; }
}