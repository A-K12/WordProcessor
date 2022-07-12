using WordProcessor.Сore.Common;

namespace WordProcessor.Сore.Models.Services;

public class DictionaryManager:IDictionaryManager
{
    private readonly IDictionaryRepository _repository;


    public DictionaryManager(IDictionaryRepository repository)
    {
        _repository = repository;
    }

    public void CreateDictionary(IEnumerable<Word> words)
    {
        _repository.DeleteAll();
        foreach (var word in words)
        {
            _repository.Add(word);
        }
    }

    public void UpdateDictionary(IEnumerable<Word> words)
    {
        foreach (var word in words)
        {
            UpdateDictionary(word);
        }
    }

    private void UpdateDictionary(Word word)
    {
        var savedWord = _repository.FindBySymbolsOrDefault(word.Symbols);
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

    public void DeleteDictionary()
    {
        _repository.DeleteAll();
    }
}