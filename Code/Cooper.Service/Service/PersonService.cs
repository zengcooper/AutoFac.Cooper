using Cooper.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cooper.Service.Repository
{
    public class PersonService : IPersonService
    {
        private IPersonRepository _personRespository;
        //通过构造函数注入 repository
        public PersonService(IPersonRepository personRespository)
        {
            _personRespository = personRespository;
        }
        public string Eat()
        {
            return _personRespository.Eat();
        }
    }
}
