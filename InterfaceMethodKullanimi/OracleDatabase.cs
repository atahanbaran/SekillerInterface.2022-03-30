using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceMethodKullanimi
{
    public class OracleDatabase : IDatabase
    {
        public string DatabaseName { get ; set; }
        public string Company { get ; set ; }

        public void Create()
        {
            Console.WriteLine("oracle");
        }

        public void Delete()
        {
            Console.WriteLine("oracle");
        }

        public void Read()
        {
            Console.WriteLine("oracle");
        }

        public void Update()
        {
            Console.WriteLine("oracle");
        }
    }
}
