using System;
using ClassLogic;

namespace TestGS
{
    class Program
    {
        static void Main()
        {
            ClassLogic.Logic _logic = new ClassLogic.Logic();
            Console.WriteLine("\n");
            Console.WriteLine("=== this Program to stop the killing by wild ===\n");
            _logic.GetFormula();
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
            _logic.GetAverrage(AOD, YOD, BOD, BYOD);
            Console.WriteLine("\n\n");
        }
    }
}
