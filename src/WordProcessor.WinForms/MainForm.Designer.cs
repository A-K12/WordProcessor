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
            this.словарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.созданиеСловаряToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновлениеСловаряToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьСловарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.словарьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(762, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // словарьToolStripMenuItem
            // 
            this.словарьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.созданиеСловаряToolStripMenuItem,
            this.обновлениеСловаряToolStripMenuItem,
            this.очиститьСловарьToolStripMenuItem});
            this.словарьToolStripMenuItem.Name = "словарьToolStripMenuItem";
            this.словарьToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.словарьToolStripMenuItem.Text = "Словарь";
            // 
            // созданиеСловаряToolStripMenuItem
            // 
            this.созданиеСловаряToolStripMenuItem.Name = "созданиеСловаряToolStripMenuItem";
            this.созданиеСловаряToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.созданиеСловаряToolStripMenuItem.Text = "Создание словаря";
            this.созданиеСловаряToolStripMenuItem.Click += new System.EventHandler(this.CreateDictionaryButtonClick);
            // 
            // обновлениеСловаряToolStripMenuItem
            // 
            this.обновлениеСловаряToolStripMenuItem.Name = "обновлениеСловаряToolStripMenuItem";
            this.обновлениеСловаряToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.обновлениеСловаряToolStripMenuItem.Text = "Обновление словаря";
            this.обновлениеСловаряToolStripMenuItem.Click += new System.EventHandler(this.UpdateDictionaryButtonClick);
            // 
            // очиститьСловарьToolStripMenuItem
            // 
            this.очиститьСловарьToolStripMenuItem.Name = "очиститьСловарьToolStripMenuItem";
            this.очиститьСловарьToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.очиститьСловарьToolStripMenuItem.Text = "Очистить словарь";
            this.очиститьСловарьToolStripMenuItem.Click += new System.EventHandler(this.ClearDictionaryButtonClick);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(738, 286);
            this.textBox1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 325);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
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
        private ToolStripMenuItem словарьToolStripMenuItem;
        private ToolStripMenuItem созданиеСловаряToolStripMenuItem;
        private ToolStripMenuItem обновлениеСловаряToolStripMenuItem;
        private ToolStripMenuItem очиститьСловарьToolStripMenuItem;
        private TextBox textBox1;
    }
}