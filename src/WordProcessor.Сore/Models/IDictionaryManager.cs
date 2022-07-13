using WordProcessor.Сore.Models;

namespace WordProcessor.Сore.Common;

public interface IDictionaryManager
{
    void AddWords(IEnumerable<Word> words);
    void UpdateWords(IEnumerable<Word> words);
    void ClearDictionary();
}