using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstruct
{
    internal interface IAplicantService
    {
        void ApplyForMask(Person person);
        List<Person> GetList();

        bool ChekPerson(Person person);
    }
}
