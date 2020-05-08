/*
 * **********************************************************
 * Строка для соединения с сервером и БД описана в файле App.config
 * Код для установки EntityFramework: install-package entityframework
 * ********************************************************** 
 */


using System;
using System.Linq;

namespace Day_19
{
    class Program
    {
        static void Main(string[] args)
        {
            AppContext appContext = new AppContext();

            string cmd = string.Empty;
            while(cmd != "0")
            {
                Console.WriteLine("\t1. Create(Add New Record)\n\t2. Read(Show Records)\n\t3. Update(Edit Record)\n\t1. Delete(Remove Record)");
                Console.Write("Input (1, 2, 3, 4): ");
                cmd = Console.ReadLine();

                if(cmd == "1")
                {
                    Console.Write("Input Article Name: ");
                    string articleName = Console.ReadLine();
                    Console.Write("Input Article Body: ");
                    string articleBody = Console.ReadLine();
                    Console.Write("Input Article Date: ");
                    string articleDate = Console.ReadLine();

                    var newArticle = new Article()
                    {
                        ArticleName = articleName,
                        ArticleBody = articleBody,
                        ArticleDate = articleDate
                    };

                    appContext.Articles.Add(newArticle);
                    appContext.SaveChanges();
                }

                if (cmd == "2")
                {
                    var articles = 
                    foreach(Article items in )
                }

                if (cmd == "3")
                {

                }

                if (cmd == "4")
                {

                }
            }
        }
    }
}
