using System;
using BlazorApp.Interfaces;

namespace BlazorApp.Services
{
    public class TranslatorService : ITranslatorService
    {
        public string Translate(string source, string target, string word) 
        {
            if (string.IsNullOrEmpty(word))
            {
                return word;
            }

            return word;
        }
    }
}