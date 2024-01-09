using System.Runtime.CompilerServices;
using System.Xml.Schema;


Console.WriteLine("Enter word");
string word = Console.ReadLine();
int i = 0;
string newWord = "";
while (i< word.Length){
    if(i == 0){
        newWord = newWord+char.ToUpper(word[i]);
        i++;
        continue;
    }
    if((word[i-1]) == ' '){
    newWord = newWord+char.ToUpper(word[i]);
    i++;
    continue; 

    }

    newWord = newWord+word[i];
    i++;
}
Console.WriteLine(newWord);