public static class Dictionary
{
    public static void AlphabetMeaning()
    {
        Dictionary<char, string> homeDictionary = new Dictionary<char, string>();
        {
           homeDictionary.Add ('A', "ace");
           homeDictionary.Add ('B', "bat");
           homeDictionary.Add ('C', "cat");
           homeDictionary.Add ('D', "dog");
           homeDictionary.Add ('E', "elephant");
           homeDictionary.Add ('F', "fowl");
           homeDictionary.Add ('G', "goat");
           homeDictionary.Add ('H', "horse");
           homeDictionary.Add ('I', "ink");
           homeDictionary.Add ('J', "jaguar");
           homeDictionary.Add ('K', "kangaroo"); 
           homeDictionary.Add ('L', "lion");
           homeDictionary.Add ('M', "man");
           homeDictionary.Add ('N', "niche");
           homeDictionary.Add ('O', "ostrich");
           homeDictionary.Add ('P', "pan");
           homeDictionary.Add ('Q', "queue");
           homeDictionary.Add ('R', "rat");
           homeDictionary.Add ('S', "snake");
           homeDictionary.Add ('T', "tree");
           homeDictionary.Add ('U', "union");
           homeDictionary.Add ('V', "vat");
           homeDictionary.Add ('W', "war");
           homeDictionary.Add ('X', "xmas");
           homeDictionary.Add ('Y', "yawn");
           homeDictionary.Add ('Z', "zaf");
        }

        int count = 0;
        foreach (var item in homeDictionary)
        {
            Console.WriteLine($"{count}.{item.Key} for {item.Value}");
            count++;
        }

    }
}
 

