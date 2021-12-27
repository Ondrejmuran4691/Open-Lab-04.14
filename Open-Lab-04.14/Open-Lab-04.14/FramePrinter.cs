using System;

namespace Open_Lab_04._14
{
    public class FramePrinter
    {
        public void Print(string[] strings)
        {
            int longest = 0;
            int len = 0;
            string first = "";
            int fir = 0;
            string last = "";
            int las = 0;
            string words = "";
            int wor = 0;
            foreach (string s in strings)
            {
              len = s.Length;
                if(len > longest)
                {
                    longest = len;
                }
            }
            do
            {
                first += "*";
                fir++;
            } while(fir < longest+4);
            Console.WriteLine(first);
            foreach (string st in strings)
            {

                words = "";
                words += "* ";
                words += st;
                do
                {
                    words += " ";

                } while (words.Length < longest + 3);
                words += "*";
                Console.WriteLine(words);
            }


            do
            {
                last += "*";
                las++;
            } while (las < longest+4);
            Console.WriteLine(last);
        }
    }
}