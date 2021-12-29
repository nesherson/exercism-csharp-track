using System;
using System.Collections.Generic;

public static class Languages
{
    public static List<string> NewList()
    {
        return new List<string>();
    }

    public static List<string> GetExistingLanguages()
    {
        return new List<string> { "C#", "Clojure", "Elm" };
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);

        return languages;
    }

    public static int CountLanguages(List<string> languages)
    {
        return languages.Count;
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        throw new NotImplementedException("Please implement the static Languages.HasLanguage() method");
    }

    public static List<string> ReverseList(List<string> languages)
    {
        throw new NotImplementedException("Please implement the static Languages.ReverseList() method");
    }

    public static bool IsExciting(List<string> languages)
    {
        throw new NotImplementedException("Please implement the static Languages.IsExciting() method");
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        throw new NotImplementedException("Please implement the static Languages.RemoveLanguage() method");
    }

    public static bool IsUnique(List<string> languages)
    {
        throw new NotImplementedException("Please implement the static Languages.IsUnique() method");
    }
}
