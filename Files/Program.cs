using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1.	В папке С:\temp создайте папки К1 и К2.
    2.	В папке К1:
    1.	создайте файл t1.txt, в который запишите следующий текст :
    Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов
    2.	создайте файл t2.txt, в который запишите следующий текст:
    Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс
    3.	В папке К2 создайте файл t3.txt, в который перепишите вначале текст из файла t1.txt, а затем из t2.txt
    4.	Выведите развернутую информацию о созданных файлах.
    5.	Файл t2.txt перенесите в папку K2.
    6.	Файл t1.txt скопируйте в папку K2.
    7.	Папку K2 переименуйте в ALL, а папку K1 удалите.
    8.	Вывести полную информацию о файлах папки All.

             */

            string path = @"C:\temp\K1\t1.txt"; // переменная для пути t1.txt
            string path2 = @"C:\temp\K1\t2.txt"; // переменная для пути t2.txt
            string path3 = @"C:\temp\K2\t3.txt"; // переменная для пути t3.txt

            Directory.CreateDirectory(@"C:\temp\K1"); // создаем директорию
            Directory.CreateDirectory(@"C:\temp\K1");

            FileInfo file = new FileInfo(path); //открываем поток
            FileStream fs = file.Create(); // создаем файл
            fs.Close(); // закрываем поток

            StreamWriter sw = new StreamWriter(path); // открываем поток записи в файл
            sw.Write("Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов"); // записываем в файл инфу
            sw.Close(); // закрываем поток

            FileInfo fi = new FileInfo(path2);
            FileStream fls = fi.Create();
            fls.Close();

            StreamWriter swr = new StreamWriter(path2);
            swr.Write(" Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");
            swr.Close();

            FileInfo file3 = new FileInfo(path3);
            FileStream fsm = file3.Create();
            fsm.Close();

            StreamReader sr = new StreamReader(path); //открываем поток считывания с файлов
            string text = sr.ReadToEnd(); // считать открытый файл до конца
            sr.Close(); //закрываем поток


            StreamWriter strwr = new StreamWriter(path3); // открываем поток записи в файл
            strwr.Write(text); // записываем в файл
            strwr.Close(); //закрываем поток

            StreamReader srr = new StreamReader(path2);
            string text2 = srr.ReadToEnd();
            sr.Close();

            using (StreamWriter strwr3331 = file3.AppendText()) //создаем переменную
            {
                strwr3331.Write(text2);
            }
           





        }



    }
}
