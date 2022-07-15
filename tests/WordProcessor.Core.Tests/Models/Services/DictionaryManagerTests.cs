using Moq;
using WordProcessor.Core.Models;
using WordProcessor.Core.Models.Services;
using Moq;
using NUnit.Framework;

namespace WordProcessor.Application.Tests.Models.Services;

public class DictionaryManagerTest
{
    private readonly Word[] _words = new[]
    {
        new Word {Symbols = "apple", UsageFrequency = 2},
        new Word {Symbols = "orange", UsageFrequency = 1},
        new Word {Symbols = "persimmon", UsageFrequency = 3},
    };

    [Test, Ignore("Wrong test")]
    public void AddWords_CallAddMethodIDictionaryRepository()
    {
        var mock = new Mock<IDictionaryRepository>();
        var manager = new DictionaryManager(mock.Object);

        manager.AddWords(_words);
        
        mock.Verify(repository => repository.Add(It.IsIn(_words)), Times.Exactly(3));
    }
    
    [Test, Ignore("Wrong test")]
    public void AddWords_WhenEmptyArray_Nothing()
    {
        var mock = new Mock<IDictionaryRepository>();
        var manager = new DictionaryManager(mock.Object);

        manager.AddWords(Array.Empty<Word>());
        
        mock.Verify(repository => repository.Add(It.IsAny<Word>()), Times.Never);
    }
    
}