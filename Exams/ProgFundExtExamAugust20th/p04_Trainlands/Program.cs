using System;
using System.Collections.Generic;
using System.Linq;

class p04_Trainlands
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, int>> trains = new Dictionary<string, Dictionary<string, int>>();

        string input;
        while ((input = Console.ReadLine()) != "It's Training Men!")
        {
            string[] tokens = input.Split();
            string trainName = tokens[0];

            if (tokens.Length == 5)
            {
                string wagonName = tokens[2];
                int wagonPower = int.Parse(tokens[4]);

                if (!trains.ContainsKey(trainName))
                {
                    trains.Add(trainName, new Dictionary<string, int>());
                }

                trains[trainName].Add(wagonName, wagonPower);
            }
            else
            {
                string secondTrainName = tokens[2];
                string delimiter = tokens[1];

                if (delimiter == "->")
                {
                    if (!trains.ContainsKey(trainName))
                    {
                        trains.Add(trainName, new Dictionary<string, int>());
                    }

                    foreach (var wagon in trains[secondTrainName])
                    {
                        trains[trainName].Add(wagon.Key, wagon.Value);
                    }
                    trains.Remove(secondTrainName);
                }
                else
                {
                    if (!trains.ContainsKey(trainName))
                    {
                        trains.Add(trainName, new Dictionary<string, int>());
                    }

                    trains[trainName].Clear();

                    foreach (var wagon in trains[secondTrainName])
                    {
                        trains[trainName].Add(wagon.Key, wagon.Value);
                    }
                }
            }
        }

        foreach (var train in trains.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Value.Values.Count))
        {
            Console.WriteLine($"Train: {train.Key}");
            foreach (var wagon in train.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"###{wagon.Key} - {wagon.Value}");
            }
        }
    }
}