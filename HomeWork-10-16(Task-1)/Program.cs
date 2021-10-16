using System;

namespace HomeWork_10_16_Task_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Advertisement add1 = new Advertisement("addName1", 32.51, "ownerAdd1");
            Advertisement add2 = new Advertisement("addName2", 22.52, "ownerAdd2");
            Advertisement add3 = new Advertisement("addName3", 12.53, "ownerAdd3");

            Advertisement[] advertisements = { add1, add2, add3 };
            try
            {
                Array.Sort(advertisements);
            }
            catch (Exception)
            {
                Console.WriteLine("Gonderdiyin array sort oluna bilmir.");
            }

            foreach (Advertisement item in advertisements)
            {
                Console.WriteLine(item);
            }

            Console.Write("1 ile 5 arasinda eded daxil edin:");
            int enums = Convert.ToInt32(Console.ReadLine());
            Advertisement add = new Advertisement();
            add.category = (Category)enums;

            if (add.category == Category.Preschoolers)
            {
                Console.WriteLine("everyone can watch");
            }
            else if (add.category == Category.Kids)
            {
                Console.WriteLine("3+ can watch");
            }
            else if (add.category == Category.Tweens)
            {
                Console.WriteLine("7+ can watch");
            }
            else if (add.category == Category.Teens)
            {
                Console.WriteLine("13+ can watch");
            }
            else
            {
                Console.WriteLine("18+ can watch");
            }
        }
    }
    enum Category : byte{Preschoolers = 1, Kids, Tweens, Teens, Adults}
}
