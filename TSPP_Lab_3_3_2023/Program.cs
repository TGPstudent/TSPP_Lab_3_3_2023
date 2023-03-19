//TSPP_Lab_3_3_2023 Робота з файлами та текстом. б) виводить на екран всі слова, довжина яких менша п'яти символів.
using System;
using System.Text;
using System.IO;

namespace TSPP_Lab_3_3_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            //Перевірка чи файл існує
            string pathInpFile = ("E:\\BUK_UNIVER\\II_kurs(II sem)\\ТСПП\\Laboratorni\\Lab3\\TSPP_Lab_3_3_2023\\input.txt");
            if (!File.Exists(pathInpFile))
            {
                Console.WriteLine("Файл:\n" + pathInpFile + "\n не можливо відкрити! Перевірьте його існування.");
                return;
            }
            else
            Console.WriteLine("Файл: ...//input.txt успішно відкрито!");
            //Відкриття файлу для читання, перевірка чи не пустий
            StreamReader inf = new StreamReader(File.Open(pathInpFile, FileMode.Open));
            string Line = inf.ReadLine();
            inf.Close();
            if (Line == null)
            {
              Console.WriteLine("Файл: ...//input.txt порожній! Перевірьте та збережіть в ньому текст");
              return;
            }
            Console.WriteLine("З файла: ...//input.txt считано наступний текстовий рядок:\n");
            Console.WriteLine(Line);
            string[] words = Line.Split(new Char[] { ' ', ',', '.', ':', ';' });
            //Опрацювання данних
            StringBuilder Rez = new StringBuilder();
            foreach (string s in words)
            {
              if (s.Trim() != "" && char.IsLetter(s[0]) && s.Length < 6)
              Rez.Append(s + "; ");
            }
            //Запис данних у файл
            string pathOutFile = ("E:\\BUK_UNIVER\\II_kurs(II sem)\\ТСПП\\Laboratorni\\Lab3\\TSPP_Lab_3_3_2023\\output.txt");
            StreamWriter outf = new StreamWriter(File.Open(pathOutFile, FileMode.OpenOrCreate));
               
                    outf.WriteLine(Rez);
                    outf.Close();
            //Перевірка чи файл створено
                if (!File.Exists(pathOutFile))
                {
                    Console.WriteLine("Файл:\n" + pathOutFile + "\n не не сворено.");
                    return;
                }
                else
                    Console.WriteLine("\n\n Файл: ...//output.txt успішно створено!");
            //Вивід інформації з файла в консоль
            StreamReader rezOut = new StreamReader(File.Open(pathOutFile, FileMode.Open));
            string rezLine = rezOut.ReadLine(); 
                    Console.WriteLine("У файл: ...//output.txt, записано слова в яких менше 5 літер:\n");
                    Console.WriteLine(rezLine);
               
            Console.ReadLine();

        }
    }
}
