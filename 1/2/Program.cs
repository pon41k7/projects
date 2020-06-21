using System;
using System.IO;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string username1, password1;
            Console.WriteLine("Регистрация - 0; Авторизация - 1;");//предоставление выбора
            int x = int.Parse(Console.ReadLine());
            if (x == 0)
            {
                //регистрация

                Console.WriteLine("Введите логин");
                string username = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                string password = Console.ReadLine();

                FileStream file1 = new FileStream(@"C:\Users\Володя\OneDrive\Документы\1.txt", FileMode.Create); //файловый поток
                StreamWriter writer = new StreamWriter(file1); //потоковый писатель

                //записываем данные
                writer.WriteLine(username);
                writer.WriteLine(password);
                writer.Close();
            }
            else
            {
                //авторизация

                Console.WriteLine("Введите логин");
                string username = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                string password = Console.ReadLine();

                FileStream file2 = new FileStream(@"C:\Users\Володя\OneDrive\Документы\1.txt", FileMode.Open); //файловый поток
                StreamReader reader = new StreamReader(file2); //связываем файловый поток с "потоковым читателем"

                //считываем построчно
                username1 = reader.ReadLine();
                password1 = reader.ReadLine();
                reader.Close();

                //сравниваем данные
                if (username == username1 && password == password1)
                {
                    Console.WriteLine("Вход выполнен успешно");
                }
                else
                {
                    Console.WriteLine("Вход не выполнен");
                }

            }
        }
    }
}
