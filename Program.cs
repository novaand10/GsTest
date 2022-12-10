using System;

namespace TestGS
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\n");
            Console.WriteLine("=== this Program to stop the killing by wild ===\n");
            Program.GetFormula();
            Console.WriteLine("\n=============================================================\n");
            Console.WriteLine("==== Input Data Person A & B ===");
            Console.Write("\nPerson A Age of Death:");
            int AOD = Convert.ToInt32(Console.ReadLine());
            Console.Write("Person A Year of Death:");
            int YOD = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nPerson B Age of Death:");
            int BOD = Convert.ToInt32(Console.ReadLine());
            Console.Write("Person B Year of Death:");
            int BYOD = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=============================================================");
            Program.GetAverrage(AOD, YOD, BOD, BYOD);
            Console.WriteLine("\n\n");
        }
        static void GetFormula()
        {
            Console.WriteLine("On the 1st year she kills 1 villager");
            Console.WriteLine("On the 2st year she kills 1 + 1 = "+Program.GetNumOfKill(2)+" villager");
            Console.WriteLine("On the 3st year she kills 1 + 1 + 2 = " + Program.GetNumOfKill(3) + " villager");
            Console.WriteLine("On the 4st year she kills 1 + 1 + 2 + 3= " + Program.GetNumOfKill(4) + " villager");
            Console.WriteLine("On the 5st year she kills 1 + 1 + 2 + 3 + 5 = " + Program.GetNumOfKill(5) + " villager");
        }

        static void GetAverrage(int a, int b, int c, int d)
        {
            Console.WriteLine("Person A Age of Death:" + a + ", Year of Death:" + b + ".\n");
            Console.WriteLine("Person B Age of Death:" + c + ", Year of Death:" + d + ".\n");
            Console.WriteLine("==================================================================================");
            int selisiha = Program.GetSelisih(a, b);
            int selisihb = Program.GetSelisih(c, d);
            if (selisiha<0 || selisihb < 0) {
                Console.Write("So the average is -1");
            }
            else { 
                double nokA = Program.GetNumOfKill(selisiha);
                double nokb = Program.GetNumOfKill(selisihb);
                double avg = (nokb + nokA) / 2;
                Console.WriteLine("Person A born on year = " + b + "-" + a + " = " + selisiha + " , number of people killed on year " + selisiha + " is " + nokA + "\n");
                Console.WriteLine("Person B born on year = " + d + "-" + c + " = " + selisihb + ", number of people killed on year " + selisihb + " is " + nokb + "");

                Console.WriteLine("==================================================================================");
                Console.Write("So the average is (" + nokb + "+" + nokA + ") / 2 = ");
                Console.Write(avg);
                Console.WriteLine("\n==============================");
            }
        }
        static int GetSelisih(int a, int b)
        {
            int c = b - a;
            return c;
        }

        static double GetNumOfKill(int val)
        {
            int hasil = 0;
            switch (val)
            {
                case 1:
                    hasil = 1;
                    break;
                case 2:
                    hasil = 2;
                    break;
                case 3:
                    hasil = 5;
                    break;
                case 4:
                    hasil = 7;
                    break;
                case 5:
                    hasil = 12;
                    break;

            }

            return hasil;
        }
    }
}
