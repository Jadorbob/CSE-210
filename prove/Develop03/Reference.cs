public class Reference
{
    private string _book;
    private int _chapter;
    private string _verseNum;

    // ----------------------------

    public Reference(string book, int chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verseNum = verse;
    }

    // -----------------------------

    public string GetReferenceString()
    {
        return $"{_book}, Chapter {_chapter}, Verse {_verseNum}";
    }
}