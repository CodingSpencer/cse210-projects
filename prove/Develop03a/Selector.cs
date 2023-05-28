public class Selector{

    public int _index;

    public string finalReference;

    public string finalScripture;



     Reference reference = new Reference();
     Scripture scripture = new Scripture();

    public void referenceSelector(int index){
        _index = index;
        if (_index == 1){
            Reference reference1 = new Reference("Alma", 48, 17,18);
            finalReference = reference1.DisplayMultiple();
        }
        else if (_index == 2){
            Reference reference2 = new Reference("Luke", 23, 39, 43);
            finalReference = reference2.DisplayMultiple();        }
        else{
            Reference reference3 = new Reference("Joseph Smith-History", 1, 17);
            finalReference = reference3.Display();        }
    }

    public void scriptureSelector(int index){
        _index = index;
        if (_index == 1){
            Scripture scripture1 = new Scripture("17 Yea, verily, verily I say unto you, if all men had been, and were, and ever would be, like unto Moroni, behold, the very powers of hell would have been shaken forever; \nyea, the devil would never have power over the hearts of the children of men.\n18 Behold, he was a man like unto Ammon, the son of Mosiah, yea, and even the other sons of Mosiah, yea, and also Alma and his sons, for they were all men of God.");
            scripture1.DisplayScripture();

            
        }
        else if (_index == 2){
            Scripture scripture2 = new Scripture("39 And one of the malefactors which were hanged railed on him, saying, If thou be Christ, save thyself and us.\n40 But the other answering rebuked him, saying, Dost not thou fear God, seeing thou art in the same condemnation?\n41 And we indeed justly; for we receive the due reward of our deeds: but this man hath done nothing amiss.\n42 And he said unto Jesus, Lord, remember me when thou comest into thy kingdom.\n43 And Jesus said unto him, Verily I say unto thee, To day shalt thou be with me in aparadise.");
            scripture2.DisplayScripture();
        }
        else if (_index == 3){
            Scripture scripture3 = new Scripture("17 It no sooner appeared than I found myself delivered from the enemy which held me bound. When the light rested upon me I saw two Personages, whose brightness and glory defy all description, estanding above me in the air. One of them spake unto me, calling me by name and said, pointing to the other—This is My Beloved Son. Hear Him!");
            scripture3.DisplayScripture();
        }
    }

    public void Random(){
            var random = new Random();
            int index = random.Next(0, 3);
            _index = index;
        }

}