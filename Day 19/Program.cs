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
                Console.WriteLine("\t1. Create(Add New Record)\n\t2. Read(Show Records)\n\t3. Update(Edit Record)\n\t4. Delete(Remove Record)");
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
                    var articles = appContext.Articles.ToList();
                    foreach(Article item in articles)
                    {
                        Console.WriteLine(new string('*', 30));
                        Console.WriteLine($"{item.ID}. {item.ArticleName}");
                        Console.WriteLine($"Date of Publishing: {item.ArticleDate}");
                        Console.WriteLine($"{item.ArticleBody}");
                        Console.WriteLine(new string('*', 30));
                    }
                }

                if (cmd == "3")
                {
                    Console.Write("Input Article ID: ");
                    string id = Console.ReadLine();
                    var account = appContext.Articles.Find(int.Parse(id));
                    Console.Write("Input Article Name: ");
                    string articleName = Console.ReadLine();
                    Console.Write("Input Article Body: ");
                    string articleBody = Console.ReadLine();
                    account.ArticleName = articleName;
                    account.ArticleBody = articleBody;
                    appContext.SaveChanges();
                }

                if (cmd == "4")
                {
                    Console.Write("Input Article ID: ");
                    string id = Console.ReadLine();
                    var account = appContext.Articles.Find(int.Parse(id));
                    appContext.Articles.Remove(account);
                    appContext.SaveChanges();
                }
            }
        }
    }
}
