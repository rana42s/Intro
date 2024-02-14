using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;

//variables --> camelCase

string message1 = "mesaj";
int months = 12;
bool isAuthenticated = false;

//yukarıdakiler gibi primitive değişkenler tanımlarken değişkene bir isim verip atanacak değerini yazarız
//Course course1 = new Course(); --> fakat bu tarz sınıf vb için bir REFERANS tipli değer ataması yapılacaksa onlar için "new" kullanmak zorundayız. 

CourseManager courseManager = new(new EfCourseDal());      //sınıfı kullanmak için new'ledik yine burada
List<Course> courses1 = courseManager.GetAll();
for (int i = 0; i < courses1.Count; i++)
{
    Console.WriteLine(courses1[i].Name + "  " + courses1[i].Price + "$");
}

Console.WriteLine("Kod Bitti..");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "0970970970";
customer1.FirstName = "Rana";
customer1.LastName = "Ayyıldız";
customer1.CustomerNumber = "123345";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "7983258";
customer2.FirstName = "Rümeysa";
customer2.LastName = "Öğ";
customer2.CustomerNumber = "54321";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Deniz";
customer3.CustomerNumber = "9823592";
customer3.TaxNumber = "12370";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "Nuray";
customer4.CustomerNumber = "23750392";
customer4.TaxNumber = "09412";

//value type: int, bool, double..
//ref type: array, class, interface..