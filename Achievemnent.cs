using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asdf
{
    internal class Achievemnent
    {
        string achName;
        string achDescription;
        int achGoal;
        int achProgress = 0;
        bool achIsCompleted = false;

        static int TotalAchievements;
        static int CompletedAchievements;

        public Achievemnent(string name, string description, int goal)
        {
            achName = name;
            achDescription = description;
            achGoal = goal;

            TotalAchievements++;
        }
        public void Addprogress (int value)
        {
            achProgress += value;
            if(achGoal <= achProgress)
            {
                achProgress = achGoal;
                achIsCompleted = true;
                CompletedAchievements++;
               
            }
        }
        public void DisPlayInfo()
        {
            Console.WriteLine(achName);
            Console.WriteLine(achDescription);
            Console.WriteLine($"{achProgress}/{achGoal}");

            if (achIsCompleted == true)
                Console.WriteLine("달성");
            else if (achIsCompleted == false)
                Console.WriteLine("미달성");
            Console.WriteLine();
        }
        public static void DisplaySummary()
        {
            Console.Write($"\n현재 총 업적 개수 {TotalAchievements}\n");
            Console.WriteLine($"완료한 업적 개수 {CompletedAchievements}");
        }
    }
}
