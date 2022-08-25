using System;
using System.Collections.Generic;

namespace ToDo_Application.NewFolder
{
    class Board
    {
        public static List<Card> ToDo;
        public static List<Card> InProgress;
        public static List<Card> Done;


        public Board()
        {
            ToDo = DefaultToDo();
            InProgress = DefaultInProgress();

        }

        public static List<Card> DefaultToDo()
        {
            return new List<Card>(){
                new Card("Title : 1","Content : 1",1,Size.L),
                new Card("Title : 2","Content : 2",2,Size.S),

            };
        }

        public static List<Card> DefaultInProgress()
        {
            return new List<Card>(){
                new Card("Title : 3","Content : 3",3,Size.XL)

            };
        }
    }
}