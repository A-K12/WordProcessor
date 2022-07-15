using WordProcessor.Core.Common;
using WordProcessor.Core.Models;

namespace WordProcessor.Core.Views;

public interface ITextInputView:IView
{
    void InsertTextIntoPosition(string text, int position);
    event Action UserTextChanged;
    event Action TextSelectionChanged;
    string UserText { get; set; }
    int CaretPosition { get; set; }
}