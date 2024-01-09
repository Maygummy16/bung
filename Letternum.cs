using System.Runtime.CompilerServices;
using System.Xml.Schema;


Console.WriteLine("Enter Letter A-Z : ");
string word = Console.ReadLine();
int i = 0;
int total = 0;
while (i< word.Length){
    switch(word[i]){
        case 'a' :
            total = total + 1;
            break;
        case 'b' :
            total = total + 2;
            break;
        case 'c' :
            total = total + 3;
            break;
        case 'd' :
            total = total + 4;
            break;
        case 'e' :
            total = total + 5;
            break;
        case 'f' :
            total = total + 6;
            break;
        case 'g' :
            total = total + 7;
            break;
        case 'h' :
            total = total + 8;
            break;
        case 'i' :
            total = total + 9;
            break;
        case 'j' :
            total = total + 10;
            break;
        case 'k' :
            total = total + 11;
            break;
        case 'l' :
            total = total + 12;
            break;
        case 'm' :
            total = total + 13;
            break;
        case 'n' :
            total = total + 14;
            break;
        case 'o' :
            total = total + 15;
            break;
        case 'p' :
            total = total + 16;
            break;
        case 'q' :
            total = total + 17;
            break;
        case 'r' :
            total = total + 18;
            break;
        case 's' :
            total = total + 19;
            break;
        case 't' :
            total = total + 20;
            break;
        case 'u' :
            total = total + 21;
            break;
        case 'v' :
            total = total + 22;
            break;
        case 'w' :
            total = total + 23;
            break;
        case 'x' :
            total = total + 24;
            break;
        case 'y' :
            total = total + 25;
            break;
        case 'z' :
            total = total + 26;
            break;
    }
i++;
}
Console.WriteLine(total);