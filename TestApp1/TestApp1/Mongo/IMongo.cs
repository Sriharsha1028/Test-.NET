using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp1.Models;

namespace TestApp1.Mongos
{
    public interface IMongo
    {
        void CreatePerson(Person person);
    }
}
