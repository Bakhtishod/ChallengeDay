using System;

class ChallengeDay
{
    static void Main(string[] args)
    {
        int dataLength = Convert.ToInt32(Console.ReadLine());

        string[] settlements = new string[dataLength];
        int[] populations = new int[dataLength];
        int[] participants = new int[dataLength];

        int[] categories = new int[7];
        string highestParticipantsSettlement = "";
        int highestParticipantsCount = 0;

        for (int i = 0; i < dataLength; i++)
        {
            string settlementName = Console.ReadLine();
            settlements[i] = settlementName;
            int populationCount = Convert.ToInt32(Console.ReadLine());
            populations[i] = populationCount;
            int participantCount = Convert.ToInt32(Console.ReadLine());
            participants[i] = participantCount;

            int category = 0;

            if (populations[i] < 700)
            {
                category = 0;
            }
            else if (populations[i] <= 1499)
            {
                category = 1;
            }
            else if (populations[i] <= 2999)
            {
                category = 2;
            }
            else if (populations[i] <= 7999)
            {
                category = 3;
            }
            else if (populations[i] <= 24999)
            {
                category = 4;
            }
            else if (populations[i] <= 69999)
            {
                category = 5;
            }
            else
            {
                category = 6;
            }

            categories[category] += participants[i];

            if (participants[i] > highestParticipantsCount)
            {
                highestParticipantsCount = participants[i];
                highestParticipantsSettlement = settlements[i];
            }
        }

        for (int i = 0; i < 7; i++)
        {
            if (i == 6)
            {
                Console.WriteLine($"{categories[i]}");
            }
            else
            {
                Console.Write($"{categories[i]} ");
            }
        }
        Console.WriteLine(highestParticipantsSettlement);
    }
}
