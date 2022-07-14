using WordProcessor.Core.Common;
using WordProcessor.Core.Models;
using WordProcessor.Core.Views;

namespace WordProcessor.Core.Presenters;

public class MainFormPresenter:IPresenter
{
    private readonly IMainFormView _view;

    public MainFormPresenter(IMainFormView view)
    {
        _view = view;
        
        _view.UserTextChanged += HandleChangedText;
        _view.DictionaryButtonsClicked += HandleClickedDictionaryButtons;
        _view.TextSelectionChanged += HandleChangedSelection;
        _view.WordSuggestionClicked += HandleClickedWord;
    }

    private void HandleClickedWord()
    {
        //throw new NotImplementedException();
    }

    private void HandleChangedSelection()
    {
        _view.CloseWordSuggestionWindow();
    }

    private void HandleClickedDictionaryButtons(string buttonName)
    {
        _view.ShowMessage(buttonName+"is clicked");
    }

    private void HandleChangedText()
    {
        Word[] _words = new[]
        {
            new Word {Symbols = "apple", UsageFrequency = 2},
            new Word {Symbols = "orange", UsageFrequency = 1},
            new Word {Symbols = "persimmon", UsageFrequency = 3},
            new Word {Symbols = "persimmon", UsageFrequency = 3},
            new Word {Symbols = "persimmon", UsageFrequency = 3},
        };
        if (_view.CaretPosition == 0) return;
        if (Char.IsLetter(_view.UserText, _view.CaretPosition-1))
            _view.ShowWordSuggestionWindow(_words);
        else
            _view.CloseWordSuggestionWindow();
    }

    public void Run()
    {
        _view.Show();
    }
}