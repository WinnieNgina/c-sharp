// See https://aka.ms/new-console-template for more information

string UniqueCharacters(string input)
{
    Dictionary<char, int> character = new Dictionary<char, int>();
    for (int i = 0; i < input.Length; i++)
    {
        if (character.ContainsKey(input[i]))
        {
            character[input[i]] += 1;
        }
        else
        {
            character[input[i]] = 1;
        }
    }

    string s = string.Empty;
    foreach (var item in character.Keys)
    {
        s += item.ToString() + character[item];
    }

    return s;
}
Console.WriteLine(UniqueCharacters("aaaufdcbggjsjlscxn"));
