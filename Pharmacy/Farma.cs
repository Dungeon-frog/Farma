using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farma
{

    class Farma 
    {
        public string name;
        public List<string>  MedName;
        public List<int> MedPrice;

        public Farma(string name)
        {
            this.MedName = new List<string>();
            this.MedPrice = new List<int>();
            this.name = name;
        }

        public void Show()
        {
            Console.WriteLine($"Вы создали аптеку - {name}");
        }

        public void NewMedecine(string Name, int Price)
        {
            MedName.Add(Name);
            MedPrice.Add(Price);
        }

        public int MaxPriceMedecine()
        {
            int max = 0;
            for (int item = 0; item < MedName.Count; item++)
            {
                if (MedPrice[item] > MedPrice[max]) max = item;
            }
            return max;
        }

        public void ShowMaxPriceMedecine()
        {
            int index = MaxPriceMedecine();
            Console.WriteLine($"Самое дорогое лекарство {MedName[index]} стоит - {MedPrice[index]}");
        }

        public int AllPriceMedecine()
        {
            int summ = 0;
            for (int i = 0; i < MedName.Count; i++)
            {
                summ += MedPrice[i]; 
            }
            return summ;
        }

        public void ShowAllPriceMedecine()
        {
            Console.WriteLine($"Сумма всех {MedName.Count} равна - {AllPriceMedecine()}");
        }
        static Random rnd = new Random();
        public void AddNewMedecine()
        {
            int n;
            string m;
            Console.WriteLine();
            Console.Write("Введите количество лекарств - ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Название лекарства");
            Console.WriteLine(" ");
            for (int i = 0; i < n; i++)
            {
                m = Console.ReadLine();
                this.NewMedecine(m, rnd.Next(0, 2000));
            }
        }

        public void ShowAllMedecine()
        {
            for (int i = 0; i < MedName.Count; i++)
            {
                Console.Write(MedName[i]);
                Console.WriteLine("--" + MedPrice[i]);
            }
        }

    }
}
