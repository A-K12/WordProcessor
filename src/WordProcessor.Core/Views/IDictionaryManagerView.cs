using WordProcessor.Core.Common;

namespace WordProcessor.Core.Views;

public interface IDictionaryManagerView:IView
{
    event Action<String> DictionaryButtonsClicked;
}