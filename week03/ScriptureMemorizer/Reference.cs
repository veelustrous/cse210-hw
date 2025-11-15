using System;

public class Reference
{
    private string _book;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int verse)
    {
        _book = book;
        _startVerse = verse;
        _endVerse = verse;
    }

    public Reference(string book, int startVerse, int endVerse, int v)
    {
        _book = book;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public override string ToString() =>
        _startVerse == _endVerse ? $"{_book} {_startVerse}" : $"{_book} {_startVerse}-{_endVerse}";
}
