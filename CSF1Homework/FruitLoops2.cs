using System;

namespace CSF1Homework
{

    class FruitLoops2
    {
        static void Main(string[] args)
        {

            string[] fruitNames = { "Apple", "Banana", "Orange", "Lemon", "Lime", "Peach" };//Initialize array of 6 strings with fruit names
            string periods = "";
            foreach (string fruit in fruitNames)
            {
                Console.WriteLine(fruit);
                periods += ".";
                Console.WriteLine(periods);
            }//end for 
        }//end main
    }//end class
}//end namespace