using System;
using System.Collections.Generic;

namespace ZachotPls
{
    class Program
    {
        static void Main(string[] args)
        {
            Educator educator = new Educator(Human.Educator);
            Child child = new Child(Human.Child);            

            Random rand = new Random();
            int achievPeriod = rand.Next(35, 60); //Ачивки за период
            

            GiveAchievment(achievPeriod, educator.educatorAchievments, child.childAchievments, educator.educator, child.child);

            Console.WriteLine($"За период выдано {achievPeriod} ачивок");
            Console.WriteLine($"Воспитатель получил {educator.educatorAchievments.Count} ачивок.\nНоминирован на {educator.Status}");
            Console.WriteLine($"Ребёнок получил {child.childAchievments.Count} ачивок");

        }

        static void GiveAchievment(int period, List<int> arr1, List<int> arr2, Human human1, Human human2)
        {
            Random rand = new Random(); 
            for (int i = 0; i < period; i++)
            {
                int achieve = rand.Next(1, 3);
                
                if(achieve == (int)human1)
                {
                    arr1.Add(1);
                }

                if(achieve == (int)human2)
                {
                    arr2.Add(2);
                }
            }
        }
    }
}
