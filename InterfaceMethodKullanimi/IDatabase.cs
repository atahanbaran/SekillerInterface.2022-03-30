using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceMethodKullanimi
{
    public interface IDatabase
    {

        public string DatabaseName { get; set; }
        public string Company { get; set; }

        void Create();
        void Update();

        void Delete();

        void Read();

    }
}
