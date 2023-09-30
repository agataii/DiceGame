internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Let's go ==>");
        while (true) 
        {
            Random rnd1 = new Random();
            int player1 = rnd1.Next(1, 6);
            int player2 = rnd1.Next(1, 6);

            Console.ReadKey();
            Console.Clear();

            Render(player1);
            Console.WriteLine("===");
            Render(player2);

            if (player1 == player2)
            {
                Console.WriteLine("Ничья");
            }
            else if (player1 < player2)
            {
                Console.WriteLine("2-й игрок победил");
            }
            else
            {
                Console.WriteLine("1-й игрок победил");
            }
        }
    }

    public static void Render(int randomNumber)
    {
        string one = @"   
 * 
   ";
        string two = @"   
* *
   ";
        string three = @"  *
 * 
*  ";
        string four = @"* *
   
* *";
        string five = @"* *
 * 
* *";
        string six = @"* *
* *
* *";

        switch (randomNumber)
        {
            case 1:
                Console.WriteLine(one);
                break;
            case 2:
                Console.WriteLine(two);
                break;
            case 3:
                Console.WriteLine(three);
                break;
            case 4:
                Console.WriteLine(four);
                break;
            case 5:
                Console.WriteLine(five);
                break;
            case 6:
                Console.WriteLine(six);
                break;
        }
    }
}