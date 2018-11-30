using System;
using System.Collections.Generic;
using System.Text;

namespace Cooper.Repository.Repository
{
    public class PersonRepository : IPersonRepository
    {
        public string Eat()
        {
            return "吃饭";
        }
    }
}
