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
        /// ��������� ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ���������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputText.Text = TypographyRules.SingleSpaceLimit(InputText.Text);
        }
        /// <summary>
        /// ������� ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputText.Text = TypographyRules.GetTextWithQuotes(InputText.Text);
        }
        /// <summary>
        /// ��������� ����� ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputText.Text = TypographyRules.ReturnsTheCorrectEllipsis(InputText.Text);
        }
        /// <summary>
        /// ����������� +-
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputText.Text = TypographyRules.GetCorrectSpellingOfTheConstructionPlusMinus(InputText.Text);
        }
        /// <summary>
        /// ��������� ����� ����� 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputText.Text = TypographyRules.GetwritingAMinus(InputText.Text);
        }
        /// <summary>
        /// ��� ����������� � ������� �����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ������������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputText.Text = TypographyRules.GetCapitalizedSentences(InputText.Text);
        }
        /// <summary>
        /// ������ ������� ����� ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ���������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputText.Text = TypographyRules.GetLowercaseText(InputText.Text);
        }
        /// <summary>
        /// ������� � ������� ������� ����� ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ����������������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputText.Text = TypographyRules.GetUppercaseText(InputText.Text);
        }
        /// <summary>
        /// ����� ������ "."
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputText.Text = TypographyRules.GetDotLetters(InputText.Text);
        }
        /// <summary>
        /// ��� ������� ����������������, ����� (������� ��������, �������� ��������, � ����� ������ ".")
        /// ��� ��� ������ ������� ���������������� �� �������
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
        /// ���������� ������� ����� � �������� ��������� ����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputText_TextChanged(object sender, EventArgs e)
        {
            OutputText.Text = InputText.Text;
        }
        /// <summary>
        /// ����������� ��������� ������
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
        /// ������� ��������� �����
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
