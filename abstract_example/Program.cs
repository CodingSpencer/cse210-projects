// See https://aka.ms/new-console-template for more information


Book mistborn = new Book("Mistborn", "Brandon Sanderson");

Book scythe = new Book("Scythe", "Neal Shusterman");

mistborn.Display();
Console.WriteLine(mistborn.IsAvailable());


scythe.Display();
Console.WriteLine(mistborn.IsAvailable());


