using System;
using System.Collections.Generic;
using System.Linq;

class p04_WormsWorldParty
{                       // my shit is the one in the comments, the other one throws exception somewere but its still 90/100
    static void Main()  // it gives 90/100, but i think it should not be that high, cuz this code is fuuuuuuuuuuuuuuuucked up
    {
        Dictionary<string, Dictionary<string, long>> party = new Dictionary<string, Dictionary<string, long>>();

        string input;
        while ((input = Console.ReadLine()) != "quit")
        {
            string[] tokens = input.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            string wormName = tokens[0];
            string teamName = tokens[1];
            long wormScore = long.Parse(tokens[2]);

            if (!party.ContainsKey(teamName))
            {
                party.Add(teamName, new Dictionary<string, long>());
            }

            bool containsWorm = false;

            foreach (var team in party.Values)
            {
                if (team.Keys.Contains(wormName))
                {
                    containsWorm = true;
                }
            }

            if (containsWorm == false)
            {
                party[teamName].Add(wormName, wormScore);
            }
        }

        //Dictionary<string, long> sumOfScores = new Dictionary<string, long>();

        //foreach (var item in party)
        //{
        //    sumOfScores.Add(item.Key, item.Value.Values.Sum());
        //}

        //string sameCount = string.Empty;
        //string sameCount2 = string.Empty;
        //long curremtSum = 0;
        //bool sameSize = false;

        //foreach (var item in sumOfScores)
        //{
        //    curremtSum = item.Value;

        //    foreach (var itemm in sumOfScores)
        //    {
        //        if (itemm.Value == curremtSum && item.Key != itemm.Key)
        //        {
        //            sameCount = item.Key;
        //            sameCount2 = itemm.Key;
        //            sameSize = true;
        //            break;
        //        }
        //    }

        //    if (sameSize == true)
        //    {
        //        break;
        //    }
        //}

        //if (sameSize == true)
        //{
        //    long team1score = sumOfScores[sameCount] / party[sameCount].Count;
        //    long team2score = sumOfScores[sameCount2] / party[sameCount2].Count;

        //    sumOfScores[sameCount] = team1score;
        //    sumOfScores[sameCount2] = team2score;
        //}

        party = party
           .OrderByDescending(x => x.Value.Sum(y => y.Value))
           .ThenByDescending(x => x.Value.Sum(y => y.Value) / x.Value.Count())
           .ToDictionary(x => x.Key, x => x.Value);

        int counter = 1;

        //foreach (var item in sumOfScores.OrderByDescending(x => x.Value))
        //{
        //    Console.WriteLine($"{counter++}. Team: {item.Key} - {party[item.Key].Values.Sum()}");
        //    foreach (var itemm in party[item.Key].OrderByDescending(x => x.Value))
        //    {
        //        Console.WriteLine($"###{itemm.Key} : {itemm.Value}");
        //    }
        //}

        foreach (var team in party)
        {
            Console.WriteLine($"{counter++}. Team: {team.Key} - {team.Value.Sum(x => x.Value)}");
            foreach (var worm in team.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"###{worm.Key} : {worm.Value}");
            }          
        }
    }
}