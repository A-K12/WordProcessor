using WordProcessor.Core.Models;

namespace WordProcessor.Core.Common;

public interface IDictionaryManager
{
    void AddWords(IEnumerable<Word> words);
    void UpdateWords(IEnumerable<Word> words);
    void ClearDictionary();
}