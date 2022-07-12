using WordProcessor.Сore.Models;

namespace WordProcessor.Сore.Common;

public interface IDictionaryManager
{
    void CreateDictionary(IEnumerable<Word> words);
    void UpdateDictionary(IEnumerable<Word> words);
    void DeleteDictionary();
}