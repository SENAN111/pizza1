using PizzaMizza.Helper;
using PizzaMizza.Models;
using PizzaMizza.Services;
using System.Collections.Generic;

namespace PizzaMizza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sql.ExecCommand("INSERT INTO  Ingredients VALUES(N'Pizza sous')"));

            IngeridentService ingerdientService = new IngeridentService();
            Ingridient ingridient = new Ingridient() { Name = "klfdejlkjl" };
            ingerdientService.Add(ingridient);
            IngeridentService deletes = new IngeridentService();
            ingerdientService.Delete(2);




        }
    }
}