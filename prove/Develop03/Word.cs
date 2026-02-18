public class Word
{
    private bool _isVisible;
    private string _wordContent;
    private string _shownContent;
    private string _hiddenContent;

    // ---------------------

    public Word(string content)
    {
        _isVisible = true;

        _wordContent = content;
        _shownContent = content;
        _hiddenContent = new string('_', content.Length);
    }

    // ---------------------

    public void MakeVisible()
    {
        _isVisible = true;
        _shownContent = _wordContent;
    }
    public void MakeNotVisible()
    {
        _isVisible = false;
        _shownContent = _hiddenContent;
    }

    public bool GetVisStatus()
    {
        return _isVisible;
    }
    public string GetShownContent()
    {
        return _shownContent;
    }
}