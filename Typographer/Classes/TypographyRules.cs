using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Typographer
{
    public static class TypographyRules
    {
        /// <summary>
        /// Данный метод возвращает исходный текст с одиночными пробелами
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string SingleSpaceLimit(string text)
        {
            return new Regex(@"\s+").Replace(text, " ");
        }
        /// <summary>
        /// Данный метод, возвращает текст в котором меняли кавычки програмиста на кавычки "ёлочки"
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string GetTextWithQuotes(string text)
        {
            Regex regex = new Regex("\"(.*?)\"");
            return regex.Replace(text, "«$1»");
        }
        /// <summary>
        /// Метод, который возвращает текст, котором 3 точки поменяны на троеточие
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string ReturnsTheCorrectEllipsis(string text)
        {
            Regex regex = new Regex(@"\.{3}");
            return regex.Replace(text, "…");
        }
        /// <summary>
        /// Метод, который возвращает текст, с конструкцией ±
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string GetCorrectSpellingOfTheConstructionPlusMinus(string text)
        {
            Regex regex = new Regex(@"\+-");
            return regex.Replace(text, "±");
        }
        /// <summary>
        /// Метод, который возвращает текст с правильным написания ариф. операции (вычитание)
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string GetwritingAMinus(string text)
        {
            Regex regex = new Regex(@"(?<=\d) - (?=\d)");
            return regex.Replace(text, " - ");
        }
        /// <summary>
        /// Метод, который возвращает текст с заглавными буквами 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string GetCapitalizedSentences(string text)
        {
            string incorrectText = Regex.Replace(text, @"([.!?;])\s+", "$1");
            char BigChar = Char.ToUpper(text[0]);
            string BigLetterText = BigChar + incorrectText.Substring(1);
            Regex regex = new Regex(@"(?<=[.!?;])\w");
            return regex.Replace(BigLetterText, m => " " + m.ToString().ToUpper());
        }
        /// <summary>
        /// Возвращает  текст с нижним регистром
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string GetLowercaseText(string text)
        {
            return text.ToLower();
        }
        /// <summary>
        /// Возвращает текст с верхним регистром
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string GetUppercaseText(string text)
        {
            return text.ToUpper();
        }
        /// <summary>
        /// Вохвращает текст с (Точка) вместо "."
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string GetDotLetters(string text) // лютый абсурд
        {
            Regex regex = new Regex(@"\.");
            return regex.Replace(text, "(Точка)");
        }
    }
}
