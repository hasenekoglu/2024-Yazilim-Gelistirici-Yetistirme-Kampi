using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;

namespace Intro
{
    public class Program
    {
        static void Main(string[] args)
        {
          IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.NationalIdentity = "123456234234";
            customer1.FirstName = "Selim";
            customer1.LastName = "Hasenek";
            customer1.CustomerNumber = "12345";

            IndividualCustomer customer2 = new IndividualCustomer();
            customer2.Id = 2;
            customer2.NationalIdentity = "21314214234234";
            customer2.FirstName = "Ahmet";
            customer2.LastName = "Hasenek";
            customer2.CustomerNumber = "12345222";

            CoorporateCustomer customer3 = new CoorporateCustomer();
            customer3.Id = 3;
            customer3.Name = "Kodlama.io";
            customer3.CustomerNumber = "472137213";
            customer3.TaxNumber = "12345321312321";

            CoorporateCustomer customer4 = new CoorporateCustomer();
            customer4.Id = 4;
            customer4.Name = "Abc";
            customer4.CustomerNumber = "1234522222";
            customer4.TaxNumber = "12333213213";

            BaseCustomer[] customers = {customer1,customer2,customer3,customer4};

            foreach (BaseCustomer customer in customers)
            {
               
                Console.WriteLine(customer.CustomerNumber);
            }

            CourseManager courseManager = new(new EfCourseDal());
            List<Course> course2 = courseManager.GetAll();
            for(int i = 0; i < course2.Count; i++)
            {
                Console.WriteLine(course2[i].Name + "/" + course2[i].Price);
            }
        }
    }
}
