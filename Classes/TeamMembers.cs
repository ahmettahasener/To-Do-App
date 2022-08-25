using System;
using System.Collections.Generic;

namespace ToDo_Application.NewFolder
{
    public class Team
    {
        private int id;

        private string Name;

        public Team(int id, string ad = null)
        {
            this.id = id;
            Name = ad;
        }


        public int Id { get => id; set => id = value; }

        public string Ad { get => Name; set => Name = value; }

    }

    public static class TeamManager
    {
        public static List<Team> TeamList;

        static TeamManager()
        {
            TeamList = DefaultTeam();
        }

        public static List<Team> DefaultTeam()
        {
            return new List<Team>()
            {
                new Team(1,"Taha Şener"),
                new Team(2,"Oliver Jake"),
                new Team(1,"Jack Connor"),
                new Team(2,"Harry Callum"),
                new Team(1,"Charlie	Kyle"),
                new Team(2,"Thomas Joe"),
            };
        }

    }
}