using Business.Abstruct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IAplicantService _applicantService;

        public PttManager(IAplicantService applicantService) //Constructor(oluşturucu demek) new yapıldığında bu blok önce çalışır.
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {
            //PersonManager personManager = new PersonManager(); //iş katmanlarında new leme yaparsak bir yere bağımlı oluruz, istenen değişikliklere program direnç gösterir.
            if (_applicantService.ChekPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName + "için maske verilemedi.");
            }
        }

    }
}
