namespace BlazorApp.Interfaces
{
    public interface ITranslatorService
    {
         string Translate(string source, string target, string word);
    }
}