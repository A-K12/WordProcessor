using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordProcessor.Core.Common;
using WordProcessor.Core.Models;
using WordProcessor.Core.Presenters;
using WordProcessor.Core.Views;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WordProcessor.WinForms
{
    public partial class MainForm : Form, IMainFormView
    {
        
        public event Action? UserTextChanged;
        public event Action<string>? DictionaryButtonsClicked;
        public event Action TextSelectionChanged;
        public event Action? WordSuggestionClicked;

        public string UserText
        {
            get => richTextBox.Text;
            set => richTextBox.Text = value;
        }
        public int CaretPosition
        {
            get => richTextBox.SelectionStart;
            set => richTextBox.SelectionStart = value;
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void AutcompleteListBoxItemSelected(object sender, EventArgs e)
        {
            WordSuggestionClicked?.Invoke();
        }

        private void DictionaryButtonClick(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem item)
            {
                DictionaryButtonsClicked?.Invoke(item.Name);
            }
            //todo: exception
        }

        public IOpenFileDialogView ShowOpenFileDialog(Action<IOpenFileDialogView> option)
        {
            throw new NotImplementedException();
        }

        public void ShowWordSuggestionWindow(IEnumerable<Word> words)
        {
            Point listBoxLocation = richTextBox.GetPositionFromCharIndex(richTextBox.SelectionStart);
            listBoxLocation.X += richTextBox.Location.X;
            listBoxLocation.Y += richTextBox.Location.Y + 20;
            autocompleteListBox.Location = listBoxLocation;
     
            autocompleteListBox.Items.AddRange(words.Select(word => word.Symbols).ToArray());

            if(!autocompleteListBox.Visible)
                autocompleteListBox.Show();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

 
        private void TextBoxChanged(object? sender, EventArgs e)
        {
            UserTextChanged?.Invoke();
        }

        public void CloseWordSuggestionWindow()
        {
            if (autocompleteListBox.Visible)
                autocompleteListBox.Hide();
            autocompleteListBox.Items.Clear();
        }

        public void InsertTextIntoPosition(string text, int position)
        {
            if (UserText.Length < position)
                throw new IndexOutOfRangeException($"{nameof(position)} out of range {nameof(UserText)}");
            int oldPosition = richTextBox.SelectionStart;
            richTextBox.SelectionStart = position;
            richTextBox.SelectionLength = 0;
            richTextBox.SelectedText = text;
        }

        private void SelectionCaretChanged(object sender, EventArgs e)
        {
              TextSelectionChanged?.Invoke();
        }
    }
}
