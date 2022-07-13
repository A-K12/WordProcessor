namespace WordProcessor.Сore.Models;

public interface IDictionaryRepository:IRepository<Word>
{
    IEnumerable<Word> GetByPatternOrDefault(string pattern);
    Word? GetBySymbolsOrDefault(string word);
}