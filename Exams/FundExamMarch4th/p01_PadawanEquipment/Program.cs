using System;


class p01_PadawanEquipment
{
    static void Main()
    {
        float budget = float.Parse(Console.ReadLine());
        int students = int.Parse(Console.ReadLine());
        float lightsabers = float.Parse(Console.ReadLine());
        float robes = float.Parse(Console.ReadLine());
        float belts = float.Parse(Console.ReadLine());

        float lightsabersTotal = (float)Math.Ceiling(students * 1.10);
        float beltsNeeded = students - (students / 6);

        float sum = (lightsabers * lightsabersTotal) + (students * robes) + (beltsNeeded * belts);

        if (budget >= sum)
        {
            Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
        }
        else
        {
            Console.WriteLine($"Ivan Cho will need {sum - budget:f2}lv more.");
        }
    }
}

