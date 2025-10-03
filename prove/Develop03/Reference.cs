public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;

    public Reference(string Reference)
    {
        ParseReference(_sReference);
    }

    private void ParseReference(string _sReference)
    {
        _sReference = _sReference.Replace(" ", "");
        bool _isBook = true;
        bool _isChapter = false;
        bool _isVerse = false;
        for (int index = 0; index < _sReference.Count(); index++)
        {
            if (_isBook == true)
            {
                if (index == 0 && char.IsDigit(_sReference[index]))
                {
                    _book += _sReference[index];
                }
                else if (char.IsDigit(_sReference[index]))
                {
                    _isBook = false;
                    _isChapter = true;
                    _chapter += _sReference[index];
                }
                else
                {
                    _book += _sReference[index];
                }
            }
            else if (_isChapter == true)
            {
                if (char.IsDigit(_sReference[index]))
                {
                    _chapter += _sReference[index];
                }
                else if (char.ToString(_sReference[index]) == ":")
                {
                    _isChapter = false;
                    _isVerse = true;
                }
            }
            else if (_isVerse == true)
            {
                if (char.ToString(_sReference[index]) == ",")
                {
                    _verse += $"{_sReference[index]} ";
                }
                else if (char.ToString(_sReference[index]) == "-")
                {
                    _verse += _sReference[index];
                }
                else
                {
                    _verse += _sReference[index];
                }
            }
        }
    }

    public string GetReference()
    {
        string strReference = $"{_book} {_chapter}:{_verse} -> ";
        return strReference;
    }
}
