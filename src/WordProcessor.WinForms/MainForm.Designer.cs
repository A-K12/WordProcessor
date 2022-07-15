namespace WordProcessor.WinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.DictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.autocompleteListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DictionaryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(577, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // DictionaryToolStripMenuItem
            // 
            this.DictionaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateDictionaryToolStripMenuItem,
            this.UpdateDictionaryToolStripMenuItem,
            this.DeleteDictionaryToolStripMenuItem});
            this.DictionaryToolStripMenuItem.Name = "DictionaryToolStripMenuItem";
            this.DictionaryToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.DictionaryToolStripMenuItem.Text = "Словарь";
            // 
            // CreateDictionaryToolStripMenuItem
            // 
            this.CreateDictionaryToolStripMenuItem.Name = "CreateDictionaryToolStripMenuItem";
            this.CreateDictionaryToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.CreateDictionaryToolStripMenuItem.Text = "Создание словаря";
            this.CreateDictionaryToolStripMenuItem.Click += new System.EventHandler(this.DictionaryButtonClick);
            // 
            // UpdateDictionaryToolStripMenuItem
            // 
            this.UpdateDictionaryToolStripMenuItem.Name = "UpdateDictionaryToolStripMenuItem";
            this.UpdateDictionaryToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.UpdateDictionaryToolStripMenuItem.Text = "Обновление словаря";
            this.UpdateDictionaryToolStripMenuItem.Click += new System.EventHandler(this.DictionaryButtonClick);
            // 
            // DeleteDictionaryToolStripMenuItem
            // 
            this.DeleteDictionaryToolStripMenuItem.Name = "DeleteDictionaryToolStripMenuItem";
            this.DeleteDictionaryToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.DeleteDictionaryToolStripMenuItem.Text = "Очистить словарь";
            this.DeleteDictionaryToolStripMenuItem.Click += new System.EventHandler(this.DictionaryButtonClick);
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Location = new System.Drawing.Point(12, 27);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(553, 224);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            this.richTextBox.SelectionChanged += new System.EventHandler(this.SelectionCaretChanged);
            this.richTextBox.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // autocompleteListBox
            // 
            this.autocompleteListBox.ItemHeight = 15;
            this.autocompleteListBox.Location = new System.Drawing.Point(0, 0);
            this.autocompleteListBox.Name = "autocompleteListBox";
            this.autocompleteListBox.Size = new System.Drawing.Size(100, 94);
            this.autocompleteListBox.TabIndex = 3;
            this.autocompleteListBox.Visible = false;
            this.autocompleteListBox.Click += new System.EventHandler(this.AutcompleteListBoxItemSelected);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 263);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.autocompleteListBox);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Word Processor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem DictionaryToolStripMenuItem;
        private ToolStripMenuItem CreateDictionaryToolStripMenuItem;
        private ToolStripMenuItem UpdateDictionaryToolStripMenuItem;
        private ToolStripMenuItem DeleteDictionaryToolStripMenuItem;
        private RichTextBox richTextBox;
        private ListBox autocompleteListBox;
    }
}