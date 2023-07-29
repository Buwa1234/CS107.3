using System;
using System.Collections.Generic;
using System.Linq;

namespace university
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Convert time from 12-hour format to 24-hour format
            Console.Write("Enter time in 12-hour format (hh:mm:ssAM/PM): ");
            string time12Hour = Console.ReadLine();

            string time24Hour = ConvertTo24HourFormat(time12Hour);
            Console.WriteLine($"Time in 24-hour format: {time24Hour}");

            Find the most frequent bird ID
            int[] sightings = { 1, 4, 4, 4, 5, 3 };
            int mostFrequentBirdID = FindMostFrequentBirdID(sightings);
            Console.WriteLine("Most frequent bird ID: " + mostFrequentBirdID);
        }

        static string ConvertTo24HourFormat(string time12Hour)
        {

            return time12Hour;
        }

        static int FindMostFrequentBirdID(int[] sightings)
        {
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            foreach (int birdID in sightings)
            {
                if (frequencyMap.ContainsKey(birdID))
                {
                    frequencyMap[birdID]++;
                }
                else
                {
                    frequencyMap[birdID] = 1;
                }
            }

            int maxFrequency = frequencyMap.Values.Max();
            int mostFrequentBirdID = frequencyMap.Where(x => x.Value == maxFrequency)
                                                 .Select(x => x.Key)
                                                 .Min();

            return mostFrequentBirdID;
        }
    }
}
