using System;

class Program
{
    static void Main()
    {
        string str = "5+5*10+(40/2)+19";
        int index = 0;
        for (int i = str.Length - 1; i >= 0; i--)
        {
            if ((str[i] == '+') || (str[i] == '-') || (str[i] == '*') || (str[i] == '/') || (str[i] == '('))
            {
                index = i;
                break;
            }
        }
        str = str.Remove(index+1);
        Console.WriteLine(str);

        Console.ReadKey();


    }
}
