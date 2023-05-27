namespace B2;

class Program
{
    static void Main(string[] args)
    {
        int option;
            do 
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Draw the triangle");
                Console.WriteLine("2. Draw the square");
                Console.WriteLine("3. Draw the rectangle");
                Console.WriteLine("0. Exit");
      
                Console.Write("Enter your option: ");
                option = Convert.ToInt16(Console.ReadLine());

                switch (option) 
                {
                    case 1:
                        DrawTriangle();
                        break;
                    case 2:
                        DrawSquare();
                        break;
                    case 3:
                        DrawRectangle();
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
            } while (option != 0);
        }

        static void DrawTriangle()
        {
            for (int i = 0; i < 5; i++) 
            {
                for (int j = 0; j < 11; j++)
                {
                    if (j >= 5 - i && j <= 5 + i)
                    {
                        Console.Write(" * ");
                        continue;
                    }
                    Console.Write("   ");
                }
                Console.WriteLine();
            }
        }

        static void DrawSquare() 
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine("   ");
                
            }
        }

        static void DrawRectangle() 
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine("   ");
            }
        }
}
