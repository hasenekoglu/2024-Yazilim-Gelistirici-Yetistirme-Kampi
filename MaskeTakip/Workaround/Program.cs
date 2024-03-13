using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    public class Program
    {
        static void Main(string[] args)
        {
           

            Person person1 = new Person();  
            Person person2 = new Person();  

            person1.FirstName = "Alper";
            person1.LastName ="Onat";
            person1.NationalIdentitiy =123;
            person1.DateOfBirthYear = 2001;
            person2.FirstName = "Selim";

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
        }
    }
}
