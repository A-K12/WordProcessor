using WordProcessor.Core.Common;
using WordProcessor.Core.Models;

namespace WordProcessor.Core.Views;

public interface IMainFormView:IView
{
    void ShowWordSuggestionWindow(IEnumerable<Word> words);
    void CloseWordSuggestionWindow();
    void ShowMessage(string message);
    void InsertTextIntoPosition(string text, int position);
    IOpenFileDialogView ShowOpenFileDialog(Action<IOpenFileDialogView> option);

    event Action UserTextChanged;
    event Action<String> DictionaryButtonsClicked;
    event Action TextSelectionChanged;
    event Action WordSuggestionClicked;
    string UserText { get; set; }
    int CaretPosition { get; set; }
}