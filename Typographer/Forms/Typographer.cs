using System.Data;
using System.Windows.Forms;
using Typographer;

namespace Typographer
{
    public partial class Typographer : Form
    {
        public Typographer()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Одиночный пробел
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void одиночныйПробелToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputText.Text = TypographyRules.SingleSpaceLimit(InputText.Text);
        }
        /// <summary>
        /// Кавычки ёлочки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void кавычкиЁлочкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputText.Text = TypographyRules.GetTextWithQuotes(InputText.Text);
        }
        /// <summary>
        /// Троеточие одним символом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void троеточиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputText.Text = TypographyRules.ReturnsTheCorrectEllipsis(InputText.Text);
        }
        /// <summary>
        /// конструкция +-
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void конструкцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputText.Text = TypographyRules.GetCorrectSpellingOfTheConstructionPlusMinus(InputText.Text);
        }
        /// <summary>
        /// Вычитание через дефис 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void вычитаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputText.Text = TypographyRules.GetwritingAMinus(InputText.Text);
        }
        /// <summary>
        /// Все предложения с большой буквы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void предложенияСБольшойБуквыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputText.Text = TypographyRules.GetCapitalizedSentences(InputText.Text);
        }
        /// <summary>
        /// Нижний регистр всего текста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void переводВНижнийРегистрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputText.Text = TypographyRules.GetLowercaseText(InputText.Text);
        }
        /// <summary>
        /// Перевод в верхний регистр всего текста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void переводВВерхнийРегистрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputText.Text = TypographyRules.GetUppercaseText(InputText.Text);
        }
        /// <summary>
        /// Точка вместо "."
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void точкаВместоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputText.Text = TypographyRules.GetDotLetters(InputText.Text);
        }
        /// <summary>
        /// Все правила типографирования, кроме (нижнего регистра, верхнего регистра, и точки вместо ".")
        /// Так как данные правила типографирования по желанию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Print_Click(object sender, EventArgs e)
        {
            string correctText = InputText.Text;
            correctText = TypographyRules.GetTextWithQuotes(correctText);
            correctText = TypographyRules.ReturnsTheCorrectEllipsis(correctText);
            correctText = TypographyRules.GetCorrectSpellingOfTheConstructionPlusMinus(correctText);
            correctText = TypographyRules.GetwritingAMinus(correctText);
            correctText = TypographyRules.GetCapitalizedSentences(correctText);
            correctText = TypographyRules.SingleSpaceLimit(correctText);
            OutputText.Text = correctText;
        }
        /// <summary>
        /// Записывает входный текст в выходное текстовое поле
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputText_TextChanged(object sender, EventArgs e)
        {
            OutputText.Text = InputText.Text;
        }
        /// <summary>
        /// Копирование выходного текста
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CopyTextButton_Click(object sender, EventArgs e)
        {
            if (OutputText.Text != string.Empty)
            {
                Clipboard.SetText(OutputText.Text);
            }
        }
        /// <summary>
        /// Очистка текстовых полей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearTextButton_Click(object sender, EventArgs e)
        {
            OutputText.Text = string.Empty;
            InputText.Text = string.Empty;
        }
    }
}
