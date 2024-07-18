using System;
using System.IO;

namespace FILE
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Dinamik konum
                string[] yol = Directory.GetCurrentDirectory().Split('\\');
                string dosyaYol = " ";
                for (int i = 0; i < yol.Length - 3; i++)
                    dosyaYol += yol[i] + '\\';
                dosyaYol += "Rakamlar.txt";


                // Dosya Okuma ve yazma
                using(StreamReader sr= new StreamReader(dosyaYol))
                {

                    string line;
                    while ((line= sr.ReadLine())!=null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
          
            }
        }
    }
}
