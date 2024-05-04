using NUnit.Framework;
using System.Security.Policy;
using Typographer;
using static System.Net.Mime.MediaTypeNames;
namespace TypographerTests
{
    public class Tests
    {
        [Test]
        public void LeaveOnlyOneSpaceInTheText()
        {
            string inputText = "������       ����";
            string correctText = "������ ����";
            Assert.AreEqual(TypographyRules.SingleSpaceLimit(inputText), correctText);
        }
        [Test]
        public void ChecksChristmasTreeQuotes()
        {
            string inputText = "������������: \"�����\"";
            string correctText = "������������: ������";
            Assert.AreEqual(TypographyRules.GetTextWithQuotes(inputText), correctText);
        }
        [Test]
        public void WriteTheEllipsisWithOneCharacter()
        {
            string inputText = "����...";
            string correctText = "�����";
            Assert.AreEqual(TypographyRules.ReturnsTheCorrectEllipsis(inputText), correctText);
        }
        [Test]
        public void ReplaceTheDesignPlusMinus()
        {
            string inputText = "+- 5000";
            string correctText = "� 5000";
            Assert.AreEqual(TypographyRules.GetCorrectSpellingOfTheConstructionPlusMinus(inputText), correctText);
        }
        [Test]
        public void ChangeTheHyphenToAMinusInArithmeticOperations()
        {
            string inputText = "10 - 5";
            string correctText = "10 - 5";
            Assert.AreEqual(TypographyRules.GetwritingAMinus(inputText), correctText);
        }
        [Test]
        public void MethodThatCapitalizesSentences()
        {
            string inputText = "������. ��� ����";
            string correctText = "������. ��� ����";
            Assert.AreEqual(TypographyRules.GetCapitalizedSentences(inputText), correctText);
        }
        [Test]
        public void MethodThatCapitalizesSentencesTogether()
        {
            string inputText = "������.��� ����";
            string correctText = "������. ��� ����";
            Assert.AreEqual(TypographyRules.GetCapitalizedSentences(inputText), correctText);
        }
        [Test]
        public void MethodThatConvertsTextToLowercase()
        {
            string inputText = "������";
            string correctText = "������";
            Assert.AreEqual(TypographyRules.GetLowercaseText(inputText), correctText);
        }
        [Test]
        public void MethodThatConvertsTextToUppercase()
        {
            string inputText = "������";
            string correctText = "������";
            Assert.AreEqual(TypographyRules.GetUppercaseText(inputText), correctText);
        }
        [Test]
        public void MethodThatWritesADotWithLetters()
        {
            string inputText = "������.";
            string correctText = "������(�����)";
            Assert.AreEqual(TypographyRules.GetDotLetters(inputText), correctText);
        }
    }
}