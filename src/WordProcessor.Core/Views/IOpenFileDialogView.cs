using WordProcessor.Core.Common;

namespace WordProcessor.Core.Views;

public interface IOpenFileDialogView:IView
{
    string Filter { get; set; }
    bool Multiselect { get; set; }
    event Action<string> FileSelected;
}