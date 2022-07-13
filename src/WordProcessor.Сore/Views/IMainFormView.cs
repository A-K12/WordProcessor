using WordProcessor.Сore.Common;
using WordProcessor.Сore.Models;

namespace WordProcessor.Сore.Views;

public interface IMainFromView:IView
{
    void ShowOpenFileDialog();
    
    void ShowWordSuggestionWindow(IEnumerable<Word> words);
    
    void ShowMessage(string message);
}