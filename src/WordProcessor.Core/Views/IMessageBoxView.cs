using WordProcessor.Core.Common;

namespace WordProcessor.Core.Views;

public interface IMessageBoxView:IView
{
    void ShowMessage(string message);
}