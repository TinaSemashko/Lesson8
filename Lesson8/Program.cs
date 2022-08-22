using System;
using System.Text.RegularExpressions;

void Print(string pattern, string[] data)
{
    for (int i = 0; i < data.Length; i++)
    {
        if (Regex.IsMatch(data[i], pattern, RegexOptions.IgnoreCase))
        {
            if(pattern == "patternTel") Console.WriteLine(data[i] + " " + data[i - 1]);
            else Console.WriteLine(data[i] + " " + data[i + 1]);
        }
    }
}

Console.WriteLine("What do you want find (fname, lname, tel)");
string typeSearch = Console.ReadLine();
if (typeSearch == "fname" || typeSearch == "lname" || typeSearch == "tel")
{
    Console.WriteLine("Insert " + typeSearch);
    string input = Console.ReadLine();

    string patternFName = @".+?(" + input + ")([A-Za-z_]+)?\\s";
    string patternLName = @"\s.+?(" + input + ")([A-Za-z_]+)?";
    string patternTel = @"[^A-Za-z]+(" + input + ")([0-9]+)?";

    var data = new string[]
    {
    "Martin Pan ",
    "+12398764999",
    "Piter Pan",
    "+12345678999",
    "Gorge Piter",
    "+13435465566",
    "Grit Delon",
    "+43743989393"
    };

    switch (typeSearch)
    {
        case "fname":            
            Print(patternFName, data);
        break;

        case "lname":
            Print(patternLName, data);
        break;            

        case "tel":
            Print(patternTel, data);
        break;        
    }
}
else
{
    Console.WriteLine("Wrong keyword");
}
//checked
