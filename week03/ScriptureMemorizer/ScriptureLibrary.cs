using System;
using System.Collections.Generic;

public class ScriptureLibrary
{
    private List<Scripture> _scriptures;

    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3), "For God so loved the world that he gave his only Son"),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding"),
            new Scripture(new Reference("Psalm", 23), "The Lord is my shepherd I shall not want")
        };
    }

    public Scripture GetRandomScripture()
    {
        var random = new Random();
        return _scriptures[random.Next(_scriptures.Count)];
    }
}
