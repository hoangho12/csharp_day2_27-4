namespace B1;

using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhập một số nguyên không âm có tối đa 3 chữ số: ");
        int number = int.Parse(Console.ReadLine());
        string words = "";

        if (number < 0 || number > 999)
        {
            Console.WriteLine("Số không hợp lệ.");
            return;
        }

        string[] units = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
                           "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        if (number == 0)
        {
            Console.WriteLine("zero");
            return;
        }

        if ((number / 100) > 0)
        {
            words += units[number / 100] + " hundred ";
            number %= 100;
        }

        if (number > 0)
        {
            if (words != "")
                words += "and ";

            if (number < 20)
            {
                words += units[number];
            }
            else
            {
                words += tens[number / 10];
                if ((number % 10) > 0)
                    words += " " + units[number % 10];
            }
        }

        Console.WriteLine(words);
    }
}

