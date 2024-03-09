public class Reference{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

   

    public Reference(){

    }

    public Reference(string book, int chapter, int startVerse){
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;

    }
    public Reference(string book, int chapter, int startVerse, int endVerse){
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string Display(){
        return $"{_book} {_chapter}:{_startVerse}";
    }

    public string DisplayMultiple(){
        return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }

    
}