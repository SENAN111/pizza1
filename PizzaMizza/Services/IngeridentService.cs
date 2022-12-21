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
    internal class IngeridentService : Iservice<Ingridient>
    {
        public void Add(Ingridient model)
        {
            Sql.ExecCommand($"Insert into Ingredients values (N'{model.Name}')");
        }

        public void Delete(int id)
        {
            Sql.ExecCommand($"DELETE  Ingredients WHERE Id={id}");
        }

        public List<Ingridient> GetAll()
        {
            DataTable dt = Sql.ExecQuery("SELECT*FROM Ingeridents");
            List<Ingridient> ingeridents = new List<Ingridient>();
            foreach (DataRow dr in dt.Rows)
            {
                ingeridents.Add(new Ingridient { Id = Convert.ToInt32(dr["ID"]), Name = dr["Name"].ToString() });
            }
            return ingeridents;
        }

        public void Update(Ingridient model)
        {
            throw new NotImplementedException();
        }
    }
}
