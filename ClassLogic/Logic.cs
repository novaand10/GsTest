using System;

namespace ClassLogic
{
    public class Logic
    {

        public void GetFormula()
        {
            Console.WriteLine("On the 1st year she kills 1 villager");
            Console.WriteLine("On the 2st year she kills 1 + 1 = " + Logic.GetNumOfKill(2) + " villager");
            Console.WriteLine("On the 3st year she kills 1 + 1 + 2 = " + Logic.GetNumOfKill(3) + " villager");
            Console.WriteLine("On the 4st year she kills 1 + 1 + 2 + 3= " + Logic.GetNumOfKill(4) + " villager");
            Console.WriteLine("On the 5st year she kills 1 + 1 + 2 + 3 + 5 = " + Logic.GetNumOfKill(5) + " villager");
            Console.WriteLine("and soon....");
        }

        public void GetAverrage(int a, int b, int c, int d)
        {
            Console.WriteLine("Person A Age of Death:" + a + ", Year of Death:" + b + ".\n");
            Console.WriteLine("Person B Age of Death:" + c + ", Year of Death:" + d + ".\n");
            Console.WriteLine("==================================================================================");
            int selisiha = Logic.GetSelisih(a, b);
            int selisihb = Logic.GetSelisih(c, d);
            if (selisiha < 0 || selisihb < 0)
            {
                Console.Write("So the average is -1");
            }
            else
            {
                double nokA = Logic.GetNumOfKill(selisiha);
                double nokb = Logic.GetNumOfKill(selisihb);
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
            int[] list = new int[3] { 0,1,1 };
            int hasil = 1;
            for (int i = 1; i < 100; i++)
            {

                //Console.WriteLine(hasil);
                if (i == 1)
                    {
                        hasil = 1;
                    }
                else if (i == 2)
                {
                    hasil = 2;
                }
                else
                    {
                        list[0] = list[1];
                        list[1] = list[2];
                        list[2] = list[0] + list[1];

                    hasil += list[2];
                }


                if ((val) == i)
                {
                    break;
                }
            }

            return hasil;
        }
    }
}
