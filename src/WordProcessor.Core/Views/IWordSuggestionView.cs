using WordProcessor.Core.Common;
using WordProcessor.Core.Models;

namespace WordProcessor.Core.Views;

public interface IWordSuggestionView:IView
{
    Word[] SuggestionWords { get; set; }
    event Action WordSuggestionClicked;
}