using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Application.NewFolder
{
    class CardManager
    {
        public static void Choice()
        {
            Console.WriteLine("**********Welcome to the ToDo Application**********");
            Console.WriteLine("Please select the action you want to do: \n*******************************************\n(1) Get boards\n(2) Add card to board\n(3) Delete card to board\n(4) Move card");
            Program.select = int.Parse(Console.ReadLine());
        }
        public static void AddCard()
        {
            Card kart = new Card();

            Console.Write("Enter Title: ");
            kart.Title = Console.ReadLine();

            Console.Write("Enter Content: ");
            kart.Title = Console.ReadLine();

            Console.Write("Chose Size -> XS(1),S(2),M(3),L(4),XL(5)  : ");
            kart.EnumSize = (Size)int.Parse(Console.ReadLine());

            Console.Write("Write Member Id: ");
            kart.MemberId = int.Parse(Console.ReadLine());
            int temp = 0;

            foreach (var item in TeamManager.TeamList)
            {
                if (item.Id == kart.MemberId)
                {
                    temp++;
                    Board.ToDo.Add(kart);
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("Incorrect entry. A user with the entered ID could not be found.");
            }
            else
            {
                Console.WriteLine("Added card.");
            }
        }
        public static void DeleteCard()
        {
            Console.WriteLine("First you need to select the card you want to delete.");
            Console.WriteLine("Please write the card title:");
            string title = Console.ReadLine();

            int temp = 0;

            foreach (var item in Board.ToDo)
            {
                if (item.Title.ToLower() == title.ToLower())
                {
                    temp++;
                    Board.ToDo.Remove(item);
                    Console.WriteLine("The deletion has been performed.");
                    break;
                }
            }
            foreach (var item in Board.InProgress)
            {
                if (item.Title.ToLower() == title.ToLower())
                {
                    temp++;
                    Board.InProgress.Remove(item);
                    Console.WriteLine("The deletion has been performed.");
                    break;
                }
            }
            foreach (var item in Board.Done)
            {
                if (item.Title.ToLower() == title.ToLower())
                {
                    temp++;
                    Board.Done.Remove(item);
                    Console.WriteLine("The deletion has been performed.");
                    break;
                }
            }

            if (temp == 0)
            {
                Console.WriteLine("The card matching your search criteria was not found on the board. Please make a selection.");
                Console.WriteLine("* To end the deletion : (1)");
                Console.WriteLine("* To try again : (2)");

                int selected = int.Parse(Console.ReadLine());
                if (selected == 1)
                {
                }
                else if (selected == 2)
                {
                    DeleteCard();
                }
            }
        }
        public static void MoveCard()
        {
            Console.WriteLine("First you need to select the card you want to update.");
            Console.WriteLine("Please write the card title:");
            string title = Console.ReadLine();

            Console.WriteLine("Card Information Found:");
            Console.WriteLine("**************************************");

            int temp = 0;
            if (temp == 0)
            {
                foreach (var item in Board.ToDo)
                {
                    if (item.Title.ToLower() == title.ToLower())
                    {
                        temp++;
                        Console.WriteLine("Title      :{0}", item.Title);
                        Console.WriteLine("Content      :{0}", item.Content);
                        Console.WriteLine("Team Member :{0}", item.MemberId);
                        Console.WriteLine("Size    :{0}", item.EnumSize);
                        Console.WriteLine("Line        :ToDo");

                        ChoseLine();
                        int selected = int.Parse(Console.ReadLine());
                        if (selected == 1)
                        {
                        }
                        else if (selected == 2)
                        {
                            Board.InProgress.Add(item);
                            Board.ToDo.Remove(item);
                        }
                        else if (selected == 3)
                        {
                            Board.Done.Add(item);
                            Board.ToDo.Remove(item);
                        }
                        Console.WriteLine("TRANSPORT HAS BEEN MADE.");
                        break;
                    }
                }
            }
            if (temp == 0)
            {
                foreach (var item in Board.InProgress)
                {
                    if (item.Title.ToLower() == title.ToLower())
                    {
                        temp++;
                        Console.WriteLine("Title      :{0}", item.Title);
                        Console.WriteLine("Content      :{0}", item.Content);
                        Console.WriteLine("Team Member :{0}", item.MemberId);
                        Console.WriteLine("Size    :{0}", item.EnumSize);
                        Console.WriteLine("Line        :InProgress");

                        ChoseLine();
                        int selected = int.Parse(Console.ReadLine());
                        if (selected == 1)
                        {
                            Board.ToDo.Add(item);
                            Board.InProgress.Remove(item);
                        }
                        else if (selected == 2)
                        {

                        }
                        else if (selected == 3)
                        {
                            Board.Done.Add(item);
                            Board.InProgress.Remove(item);
                        }
                        Console.WriteLine("TRANSPORT HAS BEEN MADE.");
                        break;
                    }
                }
            }
            if (temp == 0)
            {
                foreach (var item in Board.Done)
                {
                    if (item.Title.ToLower() == title.ToLower())
                    {
                        temp++;
                        Console.WriteLine("Title      :{0}", item.Title);
                        Console.WriteLine("Content      :{0}", item.Content);
                        Console.WriteLine("Team Member :{0}", item.MemberId);
                        Console.WriteLine("Size    :{0}", item.EnumSize);
                        Console.WriteLine("Line        :ToDo");

                        ChoseLine();
                        int selected = int.Parse(Console.ReadLine());
                        if (selected == 1)
                        {
                            Board.ToDo.Add(item);
                            Board.Done.Remove(item);
                        }
                        else if (selected == 2)
                        {
                            Board.InProgress.Add(item);
                            Board.Done.Remove(item);
                        }
                        else if (selected == 3)
                        {
                        }
                        Console.WriteLine("TRANSPORT HAS BEEN MADE.");
                        break;
                    }
                }
            }
        }
        public static void GetBoard()
        {
            Console.WriteLine("TODO Line");
            Console.WriteLine("************************");
            if (Board.ToDo.Count == 0)
            {
                Console.WriteLine("~ Empty ~");
            }
            else
            {
                foreach (var item in Board.ToDo)
                {
                    Console.WriteLine("Title      :{0}", item.Title);
                    Console.WriteLine("Content      :{0}", item.Content);
                    Console.WriteLine("Team Member :{0}", item.MemberId);
                    Console.WriteLine("Size    :{0}", item.EnumSize);
                    Console.WriteLine("Line        :ToDo");
                }
            }
            Console.WriteLine();

            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("************************");
            if (Board.InProgress.Count == 0)
            {
                Console.WriteLine("~ Empty ~");
            }
            else
            {
                foreach (var item in Board.InProgress)
                {
                    Console.WriteLine("Title      :{0}", item.Title);
                    Console.WriteLine("Content      :{0}", item.Content);
                    Console.WriteLine("Team Member :{0}", item.MemberId);
                    Console.WriteLine("Size    :{0}", item.EnumSize);
                    Console.WriteLine("Line        :ToDo");
                }
            }
            Console.WriteLine();

            Console.WriteLine("DONE Line");
            Console.WriteLine("************************");
            if (Board.Done.Count == 0)
            {
                Console.WriteLine("~ Empty ~");
            }
            else
            {
                foreach (var item in Board.Done)
                {
                    Console.WriteLine("Title      :{0}", item.Title);
                    Console.WriteLine("Content      :{0}", item.Content);
                    Console.WriteLine("Team Member :{0}", item.MemberId);
                    Console.WriteLine("Size    :{0}", item.EnumSize);
                    Console.WriteLine("Line        :ToDo");
                }
            }

        }
        public static void ChoseLine()
        {
            Console.WriteLine("Please select the Line you want to move:");
            Console.WriteLine("(1) TODO");
            Console.WriteLine("(2) IN PROGRESS");
            Console.WriteLine("(3) DONE");
        }
    }
}
