using PizzaMizza.Abstractions;
using PizzaMizza.Helper;
using PizzaMizza.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.Services
{
    internal class Pizzaservice : Iservice<Pizzas>
    {
        public void Add(Pizzas model)
        {
            Sql.ExecCommand($"Insert into Pizzas values (N'{model.Name}',N{model.Image})");
        }

        public void Delete(int id)
        {
            Sql.ExecCommand($"DELETE PIZZAS WHERE Id={id}");
        }
        public void Update( Pizzas model)
        {
            Sql.ExecCommand($"UPTADE PIZZAS SET Name = {model.Name} WHERE Id={model.Id}");
        }
        public List<Pizzas> GetAll()
        {
            DataTable dt = Sql.ExecQuery("SELECT*FROM PIZZAS");
            List<Pizzas> pizzas= new List<Pizzas>();
            foreach(DataRow dr in dt.Rows)
            {
                pizzas.Add(new Pizzas { Id= Convert.ToInt32(dr["ID"]) , Name = dr["Name"].ToString(), Image = dr["Image"].ToString() });
            }
            return pizzas;
        }
    }
}
