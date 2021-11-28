//// See https://aka.ms/new-console-template for more information
int num = 13;
int i = 1;
int count = 0;

if (num == 0 || num == 1)
{ Console.WriteLine("Ne sadedir ne de murekkeb"); }

else if (num < 0)
{ Console.WriteLine("Musbet eded daxil ediniz"); }
else
{
    while (i < num)
    {

        if (num % i == 0)
        {
            count++;
            i++;
        }
        else
        {
            i++;
        }
    }
}
if (count > 2)
{ Console.WriteLine("Murekkeb ededdir"); }
else
{
    Console.WriteLine("Sade ededdir");
}


int number = 786;
int reqem;
int cem = 0;
while (number > 0)
{
    reqem = number % 10;
    cem = reqem + cem;
    number = number / 10;
}
Console.WriteLine(cem);


int fesil = 13;
switch (fesil)
{
    case 1:
    case 2:
    case 12:
        Console.WriteLine("Qis");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Yaz");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Yay");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Payiz");
        break;       
    default:
        Console.WriteLine("Duzgun ededi daxil edin");
            break;
}



















