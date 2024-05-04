namespace Typographer
{
    partial class Typographer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            InputText = new RichTextBox();
            OutputText = new RichTextBox();
            menuStrip1 = new MenuStrip();
            выборТипографированияToolStripMenuItem = new ToolStripMenuItem();
            одиночныйПробелToolStripMenuItem = new ToolStripMenuItem();
            кавычкиЁлочкиToolStripMenuItem = new ToolStripMenuItem();
            троеточиеToolStripMenuItem = new ToolStripMenuItem();
            конструкцияToolStripMenuItem = new ToolStripMenuItem();
            вычитаниеToolStripMenuItem = new ToolStripMenuItem();
            предложенияСБольшойБуквыToolStripMenuItem = new ToolStripMenuItem();
            переводВНижнийРегистрToolStripMenuItem = new ToolStripMenuItem();
            переводВВерхнийРегистрToolStripMenuItem = new ToolStripMenuItem();
            точкаВместоToolStripMenuItem = new ToolStripMenuItem();
            InputLabel = new Label();
            OutputLabel = new Label();
            Print = new Button();
            CopyTextButton = new Button();
            ClearTextButton = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // InputText
            // 
            InputText.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            InputText.Location = new Point(0, 67);
            InputText.Name = "InputText";
            InputText.Size = new Size(432, 404);
            InputText.TabIndex = 0;
            InputText.Text = "";
            InputText.TextChanged += InputText_TextChanged;
            // 
            // OutputText
            // 
            OutputText.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OutputText.Location = new Point(456, 67);
            OutputText.Name = "OutputText";
            OutputText.Size = new Size(426, 404);
            OutputText.TabIndex = 1;
            OutputText.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { выборТипографированияToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(262, 31);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // выборТипографированияToolStripMenuItem
            // 
            выборТипографированияToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { одиночныйПробелToolStripMenuItem, кавычкиЁлочкиToolStripMenuItem, троеточиеToolStripMenuItem, конструкцияToolStripMenuItem, вычитаниеToolStripMenuItem, предложенияСБольшойБуквыToolStripMenuItem, переводВНижнийРегистрToolStripMenuItem, переводВВерхнийРегистрToolStripMenuItem, точкаВместоToolStripMenuItem });
            выборТипографированияToolStripMenuItem.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            выборТипографированияToolStripMenuItem.Name = "выборТипографированияToolStripMenuItem";
            выборТипографированияToolStripMenuItem.Size = new Size(254, 27);
            выборТипографированияToolStripMenuItem.Text = "Выбор типографирования";
            // 
            // одиночныйПробелToolStripMenuItem
            // 
            одиночныйПробелToolStripMenuItem.Name = "одиночныйПробелToolStripMenuItem";
            одиночныйПробелToolStripMenuItem.Size = new Size(357, 28);
            одиночныйПробелToolStripMenuItem.Text = "Одиночный пробел";
            одиночныйПробелToolStripMenuItem.Click += одиночныйПробелToolStripMenuItem_Click;
            // 
            // кавычкиЁлочкиToolStripMenuItem
            // 
            кавычкиЁлочкиToolStripMenuItem.Name = "кавычкиЁлочкиToolStripMenuItem";
            кавычкиЁлочкиToolStripMenuItem.Size = new Size(357, 28);
            кавычкиЁлочкиToolStripMenuItem.Text = "Кавычки ёлочки";
            кавычкиЁлочкиToolStripMenuItem.Click += кавычкиЁлочкиToolStripMenuItem_Click;
            // 
            // троеточиеToolStripMenuItem
            // 
            троеточиеToolStripMenuItem.Name = "троеточиеToolStripMenuItem";
            троеточиеToolStripMenuItem.Size = new Size(357, 28);
            троеточиеToolStripMenuItem.Text = "Троеточие";
            троеточиеToolStripMenuItem.Click += троеточиеToolStripMenuItem_Click;
            // 
            // конструкцияToolStripMenuItem
            // 
            конструкцияToolStripMenuItem.Name = "конструкцияToolStripMenuItem";
            конструкцияToolStripMenuItem.Size = new Size(357, 28);
            конструкцияToolStripMenuItem.Text = "Конструкция ±";
            конструкцияToolStripMenuItem.Click += конструкцияToolStripMenuItem_Click;
            // 
            // вычитаниеToolStripMenuItem
            // 
            вычитаниеToolStripMenuItem.Name = "вычитаниеToolStripMenuItem";
            вычитаниеToolStripMenuItem.Size = new Size(357, 28);
            вычитаниеToolStripMenuItem.Text = "Вычитание ";
            вычитаниеToolStripMenuItem.Click += вычитаниеToolStripMenuItem_Click;
            // 
            // предложенияСБольшойБуквыToolStripMenuItem
            // 
            предложенияСБольшойБуквыToolStripMenuItem.Name = "предложенияСБольшойБуквыToolStripMenuItem";
            предложенияСБольшойБуквыToolStripMenuItem.Size = new Size(357, 28);
            предложенияСБольшойБуквыToolStripMenuItem.Text = "Предложения с большой буквы";
            предложенияСБольшойБуквыToolStripMenuItem.Click += предложенияСБольшойБуквыToolStripMenuItem_Click;
            // 
            // переводВНижнийРегистрToolStripMenuItem
            // 
            переводВНижнийРегистрToolStripMenuItem.Name = "переводВНижнийРегистрToolStripMenuItem";
            переводВНижнийРегистрToolStripMenuItem.Size = new Size(357, 28);
            переводВНижнийРегистрToolStripMenuItem.Text = "Перевод в нижний регистр";
            переводВНижнийРегистрToolStripMenuItem.Click += переводВНижнийРегистрToolStripMenuItem_Click;
            // 
            // переводВВерхнийРегистрToolStripMenuItem
            // 
            переводВВерхнийРегистрToolStripMenuItem.Name = "переводВВерхнийРегистрToolStripMenuItem";
            переводВВерхнийРегистрToolStripMenuItem.Size = new Size(357, 28);
            переводВВерхнийРегистрToolStripMenuItem.Text = "Перевод в верхний регистр";
            переводВВерхнийРегистрToolStripMenuItem.Click += переводВВерхнийРегистрToolStripMenuItem_Click;
            // 
            // точкаВместоToolStripMenuItem
            // 
            точкаВместоToolStripMenuItem.Name = "точкаВместоToolStripMenuItem";
            точкаВместоToolStripMenuItem.Size = new Size(357, 28);
            точкаВместоToolStripMenuItem.Text = "(Точка) вместо \".\"";
            точкаВместоToolStripMenuItem.Click += точкаВместоToolStripMenuItem_Click;
            // 
            // InputLabel
            // 
            InputLabel.AutoSize = true;
            InputLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            InputLabel.Location = new Point(179, 33);
            InputLabel.Name = "InputLabel";
            InputLabel.Size = new Size(71, 31);
            InputLabel.TabIndex = 3;
            InputLabel.Text = "Ввод";
            // 
            // OutputLabel
            // 
            OutputLabel.AutoSize = true;
            OutputLabel.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OutputLabel.Location = new Point(637, 33);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(89, 31);
            OutputLabel.TabIndex = 4;
            OutputLabel.Text = "Вывод";
            // 
            // Print
            // 
            Print.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Print.Location = new Point(265, 0);
            Print.Name = "Print";
            Print.Size = new Size(206, 31);
            Print.TabIndex = 5;
            Print.Text = "Типографировать все";
            Print.UseVisualStyleBackColor = true;
            Print.Click += Print_Click;
            // 
            // CopyTextButton
            // 
            CopyTextButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CopyTextButton.Location = new Point(477, 0);
            CopyTextButton.Name = "CopyTextButton";
            CopyTextButton.Size = new Size(122, 31);
            CopyTextButton.TabIndex = 6;
            CopyTextButton.Text = "Копировать";
            CopyTextButton.UseVisualStyleBackColor = true;
            CopyTextButton.Click += CopyTextButton_Click;
            // 
            // ClearTextButton
            // 
            ClearTextButton.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ClearTextButton.Location = new Point(604, 0);
            ClearTextButton.Name = "ClearTextButton";
            ClearTextButton.Size = new Size(104, 31);
            ClearTextButton.TabIndex = 7;
            ClearTextButton.Text = "Очистить";
            ClearTextButton.UseVisualStyleBackColor = true;
            ClearTextButton.Click += ClearTextButton_Click;
            // 
            // Typographer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 474);
            Controls.Add(ClearTextButton);
            Controls.Add(CopyTextButton);
            Controls.Add(Print);
            Controls.Add(OutputLabel);
            Controls.Add(InputLabel);
            Controls.Add(OutputText);
            Controls.Add(InputText);
            Controls.Add(menuStrip1);
            Name = "Typographer";
            Text = "Typographer";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox InputText;
        private RichTextBox OutputText;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem выборТипографированияToolStripMenuItem;
        private Label InputLabel;
        private Label OutputLabel;
        private Button Print;
        private Button CopyTextButton;
        private Button ClearTextButton;
        private ToolStripMenuItem одиночныйПробелToolStripMenuItem;
        private ToolStripMenuItem кавычкиЁлочкиToolStripMenuItem;
        private ToolStripMenuItem троеточиеToolStripMenuItem;
        private ToolStripMenuItem конструкцияToolStripMenuItem;
        private ToolStripMenuItem вычитаниеToolStripMenuItem;
        private ToolStripMenuItem предложенияСБольшойБуквыToolStripMenuItem;
        private ToolStripMenuItem переводВНижнийРегистрToolStripMenuItem;
        private ToolStripMenuItem переводВВерхнийРегистрToolStripMenuItem;
        private ToolStripMenuItem точкаВместоToolStripMenuItem;
    }
}
