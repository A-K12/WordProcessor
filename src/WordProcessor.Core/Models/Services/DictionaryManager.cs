using WordProcessor.Core.Common;

namespace WordProcessor.Core.Models.Services;

public class DictionaryManager:IDictionaryManager
{
    private readonly IDictionaryRepository _repository;


    public DictionaryManager(IDictionaryRepository repository)
    {
        _repository = repository;
    }

    public void AddWords(IEnumerable<Word> words)
    {
        foreach (var word in words)
        {
            _repository.Add(word);
        }
    }

    public void UpdateWords(IEnumerable<Word> words)
    {
        foreach (var word in words)
        {
            UpdateDictionary(word);
        }
    }

    private void UpdateDictionary(Word word)
    {
        var savedWord = _repository.GetBySymbolsOrDefault(word.Symbols);
        if (savedWord is null)
        {
            _repository.Add(word);
        }
        else
        {
            savedWord.UsageFrequency += word.UsageFrequency;
            _repository.Update(savedWord);
        }
    }

    public void ClearDictionary()
    {
        _repository.DeleteAll();    
    }
}