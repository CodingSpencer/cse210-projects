// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//Player player = new Player();
Player neymar = new Player("Neymar Jr.", 10, "Forward");

Player kobe = new Player("Bryant", 24);
kobe.SetPosition("Shooting Guard");

Team awesomeSauce = new Team("Awesome Sauce");

awesomeSauce.AddPlayer(kobe);
awesomeSauce.AddPlayer(neymar);

awesomeSauce.AddLoss();
awesomeSauce.AddWin();

awesomeSauce.DisplayRoster();

