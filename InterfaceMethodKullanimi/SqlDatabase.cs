using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceMethodKullanimi
{
    public class SqlDatabase : IDatabase
    {
        public string DatabaseName { get ; set ; }
        public string Company { get; set; }

        public void Create()
        {
            Console.WriteLine("sql ile yaratıldı" );
        }

        public void Delete()
        {
            Console.WriteLine("sql ile yaratıldı" );
        }

        public void Read()
        {
            Console.WriteLine("sql ile yaratıldı" );
        }

        public void Update()
        {
            Console.WriteLine("sql ile yaratıldı" );
        }
    }
}
