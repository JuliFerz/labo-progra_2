using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        // las mismas columnas que la tabla de clientes
        private int id;
        private string name;
        private string secondName;
        private string surName;
        private int age;
        private string email;
        private int sales_ids;

        public int Id { get => this.id; set => this.id = value; }
        public string Name { get => this.name; set => this.name = value; }
        public string SecondName { get => this.secondName; set => this.secondName = value; }
        public string SurName { get => this.surName; set => this.surName = value; }
        public int Age { get => this.age; set => this.age = value; }
        public string Email { get => this.email; set => this.email = value; }
        public int Sales_ids { get => this.sales_ids; set => this.sales_ids = value; }

        public Cliente(string name, string secondName, string surName, int age, string email, int sales_ids)
        {
            this.name = name;
            this.secondName = secondName;
            this.surName = surName;
            this.age = age;
            this.email = email;
            this.sales_ids = sales_ids;
        }

        public Cliente(int id, string name, string secondName, string surName, int age, string email, int sales_ids)
            : this(name, secondName, surName, age, email, sales_ids)
        {
            this.id = id;
        }
    }
}
