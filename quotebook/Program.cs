﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Board _board = new Board();

_board.AddQuote(
    new Quote(
        "Paul",
        "God hath not given us the spirit of fear; but of power, and of love, and of a sound mind.",
        new Source("2 Timothy 1:7")
    )
);

_board.AddQuote(
    new Quote(
        "Sister Elaine S. Dalton",
        "Work hard to achieve your dreams. Don't let discouragement or mistakes delay you.",
        new Source(
            "How to Dare Great Things",
            "https://www.churchofjesuschrist.org/study/new-era/2012/03/how-to-dare-great-things?lang=eng"
        )
    )
);

_board.AddQuote(new Quote("Alma","If ye have faith ye hope for things which are not seen, which are true.", new Source("Alma 32:21")));
_board.AddQuote(new Quote("Alma", "Live in thanksgiving daily.", new Source("Alma 34:38")));
_board.AddQuote(new Quote("Alma", "Councel with the Lord in all they doings, and he will direct thee for good.", new Source("Alma 37:37")));

// _board.GetRandomQuote();

Menu menu = new Menu(_board);
menu.Display();





// Source source = new Source("None Were with him","https://www.churchofjesuschrist.org");

// Console.WriteLine(source.Stringify());

// Quote holland = new Quote("Elder Holland", "Because Jesus walked such a long, lonely path utterly alone, we do not have to do so", source);

// Console.WriteLine(holland.GetQuote());

// Board quoteboard = new Board();
// quoteboard.AddQuote(holland);
// quoteboard.FindQuotesByAuthor("holland");