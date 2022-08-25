using System;

namespace ToDo_Application
{
    class Card
    {
        private string _title;
        private string _content;
        private int _memberId;
        private Size _enumSize;


        public string Title { get => _title; set => _title = value; }
        public string Content { get => _content; set => _content = value; }
        public int MemberId { get => _memberId; set => _memberId = value; }
        internal Size EnumSize { get => _enumSize; set => _enumSize = value; }

        public Card()
        {

        }

        public Card(string title, string content, int memberId, Size enumSize)
        {
            Title = title;
            Content = content;
            MemberId = memberId;
            EnumSize = enumSize;
        }

    }

    enum Size
    {
        XS = 1,
        S,
        M,
        L,
        XL
    }
}