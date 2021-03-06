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
        return languages.Contains(language);
    }

    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages)
    {
        if (languages.Count <= 0)
            return false;

        if (languages[0] == "C#")
            return true;

        if (languages.Count == 2 || languages.Count == 3)
        {
            if (languages[1] == "C#")
                return true;
        }

        return false;
    }

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);

        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        if (languages.Count <= 0)
            return false;

        for (int i = 0; i < languages.Count; i++)
        {
            string tempLang = languages[i];
            int tempLangIndex = i;

            for (int j = 0; j < languages.Count; j++)
            {
                if (tempLang == languages[j] && tempLangIndex != j)
                {
                    return false;
                }
            }
        }

        return true;
    }
}
