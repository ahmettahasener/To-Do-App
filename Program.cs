using System;
using ToDo_Application.NewFolder;

namespace ToDo_Application
{
    internal class Program
    {
        public static int select = 0;
        static void Main(string[] args)
        {
            while (select != 5)
            {
                CardManager.Choice();
                if (select < 0 || select > 5)
                {
                    Console.WriteLine("Choose from 1 to 4. Press 5 to exit.");
                    select = int.Parse(Console.ReadLine());
                }
                switch (select)
                {
                    case 1:
                        CardManager.GetBoard();
                        break;
                    case 2:
                        CardManager.AddCard();
                        break;
                    case 3:
                        CardManager.DeleteCard();
                        break;
                    case 4:
                        CardManager.MoveCard();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
