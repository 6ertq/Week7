using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("Sisestage oma eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Sisestage number vahemikus 1-3:");
            int number = int.Parse(Console.ReadLine());

            if (number == 1){
                FirstNameBackwards(firstName);
            }
            else if (number == 2){
                FirstNameFirstLetter(firstName[0]);
            }
            else if (number == 3){
                FirstNameLenght(firstName.Length);
            }
            else
                Console.WriteLine("Teie sisestatud number ei vastanud vahemikule.");
        }
        public static void FirstNameBackwards(string firstName){
            for (int i = firstName.Length - 1; i >= 0; i--)
            {
                Console.Write(firstName[i]);
            }
        }
        public static void FirstNameFirstLetter (char firstLetter){
            Console.WriteLine($"Teie nime esimene täht on {firstLetter}.");
        }
        public static void FirstNameLenght(int firstNameLenght){
            Console.WriteLine($"Teie nime pikkus on {firstNameLenght} tähemärki.");
        }
    }
}
