using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farma
{

    class Program
    {
        static Farma farma;
        public static void AddNewfarma()
        {

            Console.Write("Введите название аптеки - ");
            string name = Console.ReadLine();
            farma = new Farma(name);
        }
        static void Main(string[] args)
        {
            AddNewfarma();
            farma.Show();
            farma.AddNewMedecine();
            Console.WriteLine();
            Console.WriteLine("Стоимость лекарств");
            farma.ShowAllMedecine();
            Console.WriteLine();
            farma.ShowMaxPriceMedecine();
            farma.ShowAllPriceMedecine();
            Console.ReadKey();
        }
    }
}
