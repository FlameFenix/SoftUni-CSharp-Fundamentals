using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTeams = int.Parse(Console.ReadLine());

            List<Teams> teams = new List<Teams>();

            for (int i = 0; i < numberOfTeams; i++)
            {
                string[] input = Console.ReadLine()
                                        .Split("-", StringSplitOptions.RemoveEmptyEntries)
                                        .ToArray();

                string creatorName = input[0];
                string teamName = input[1];

                Teams newTeam = new Teams(creatorName, teamName);

                bool isTeamExist = teams.Select(x => x.TeamName).Contains(teamName);
                bool isCreatorExist = teams.Select(x => x.CreatorName).Contains(creatorName);

                if (isTeamExist)
                {
                    if (isCreatorExist)
                    {
                        Console.WriteLine($"{creatorName} cannot create another team!");
                    }
                    else
                    {
                        Console.WriteLine($"Team {teamName} was already created!");
                    }
                }
                else
                {
                    if (isCreatorExist)
                    {
                        Console.WriteLine($"{creatorName} cannot create another team!");
                    }
                    else
                    {
                        teams.Add(newTeam);
                        Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                    }
                }
            }

            string joinTeam = Console.ReadLine();

            while (joinTeam != "end of assignment")
            {
                string[] cmdArgs = joinTeam.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                                           .ToArray();

                string memberName = cmdArgs[0];
                string teamName = cmdArgs[1];

                bool isTeamExist = teams.Select(x => x.TeamName).Contains(teamName);

                bool isCreatorExist = teams.Select(x => x.CreatorName).Contains(memberName);

                bool isMemberExist = teams.Select(x => x.Members).Any(x => x.Contains(memberName));

                if (!isTeamExist)
                {

                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (isCreatorExist || isMemberExist)
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                }
                else
                {
                    int index = teams.FindIndex(x => x.TeamName == teamName);
                    if (!isCreatorExist)
                    {
                        teams[index].Members.Add(memberName);
                    }
                }

                joinTeam = Console.ReadLine();
            }

            Teams[] teamsToDisband = teams.OrderBy(x => x.TeamName)
                                          .Where(x => x.Members.Count == 0)
                                          .ToArray();

            Teams[] fullTeams = teams.OrderBy(x => x.TeamName)
                                     .Where(x => x.Members.Count > 0)
                                     .ToArray();

            foreach (Teams item in fullTeams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.TeamName))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"{item.TeamName}");
                sb.AppendLine($"- {item.CreatorName}");
                foreach (var user in item.Members.OrderBy(x => x))
                {
                    sb.AppendLine($"-- {user}");


                }
                Console.Write(sb);
            }

            Console.WriteLine("Teams to disband:");

            foreach (Teams item in teamsToDisband)
            {
                Console.WriteLine(item.TeamName);
            }
        }

    }

    class Teams
    {
        public Teams(string creatorName, string teamName)
        {
            CreatorName = creatorName;
            TeamName = teamName;
            Members = new List<string>();
        }
        public string CreatorName { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }
    }

}
