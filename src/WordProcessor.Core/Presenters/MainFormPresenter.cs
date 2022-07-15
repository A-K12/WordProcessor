using WordProcessor.Core.Common;
using WordProcessor.Core.Models;
using WordProcessor.Core.Views;

namespace WordProcessor.Core.Presenters;

public class MainFormPresenter:IPresenter
{
    private readonly ITextInputView _mainView;
    private readonly IDictionaryManagerView _dictionaryManagerView;
    private readonly IWordSuggestionView _wordSuggestionView;

    public MainFormPresenter(ITextInputView mainView, 
        IDictionaryManagerView dictionaryManagerView, 
        IWordSuggestionView wordSuggestionView)
    {
        _mainView = mainView;
        _dictionaryManagerView = dictionaryManagerView;
        _wordSuggestionView = wordSuggestionView;
        
        _mainView.UserTextChanged += HandleChangedText;
        _mainView.TextSelectionChanged += HandleChangedSelection;
        _dictionaryManagerView.DictionaryButtonsClicked += HandleClickedDictionaryButtons;
        _wordSuggestionView.WordSuggestionClicked += HandleClickedWord;
    }

    private void HandleClickedWord()
    {
        throw new NotImplementedException();
    }

    private void HandleChangedSelection()
    {
        _wordSuggestionView.Close();
    }

    private void HandleClickedDictionaryButtons(string buttonName)
    {
        throw new NotImplementedException();
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
        if (_mainView.CaretPosition == 0) return;
        if (Char.IsLetter(_mainView.UserText, _mainView.CaretPosition - 1))
        {
            _wordSuggestionView.SuggestionWords = _words;
            _wordSuggestionView.Show();
        }
        else
            _wordSuggestionView.Close();
    }

    public void Run()
    {
        _mainView.Show();
    }
}