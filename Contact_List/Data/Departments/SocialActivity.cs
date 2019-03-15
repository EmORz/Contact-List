using System.Collections.Generic;
using Data.Models;

namespace Data
{
    public class SocialActivity
    {
        public static List<Employee> SocialActivityEmp()
        {
            Employee emp = new Employee();
            emp.Department = "Отдел Социални дейности";
            emp.professionalLeve = "Началник отдел";
            emp.FirstName = "Росица";
            emp.MiddleName = "Бончева";
            emp.LastName = "Георгиева";
            emp.roomNumber = "512";
            emp.email = "r_boncheva@razgrad.bg";
            emp.phoneNumber = "618/312";

            Employee emp1 = new Employee();
            emp1.Department = "Отдел Социални дейности";
            emp1.professionalLeve = "Старши експерт";
            emp1.FirstName = "Кольо";
            emp1.MiddleName = "Недков";
            emp1.LastName = "Колев";
            emp1.roomNumber = "506";
            emp1.email = "k.kolev@razgrad.bg";
            emp1.phoneNumber = "618/218";

            Employee emp2 = new Employee();
            emp2.Department = "Отдел Социални дейности";
            emp2.professionalLeve = "Младши експерт";
            emp2.FirstName = "Галина/Кадер";
            emp2.MiddleName = "Иванова/Бейха";
            emp2.LastName = "Маркова/Мустафа";
            emp2.roomNumber = "506";
            emp2.email = "sdd_eksperts@razgrad.bg";
            emp2.phoneNumber = "618/218";

            Employee emp3 = new Employee();
            emp3.Department = "Отдел Социални дейности";
            emp3.professionalLeve = "Старши специалист - секретар Хасанов";
            emp3.FirstName = "Маринка";
            emp3.MiddleName = "Дачева";
            emp3.LastName = "Николова";
            emp3.roomNumber = "508";
            emp3.email = "";
            emp3.phoneNumber = "618/135";

            List<Employee> empCollection = new List<Employee>();
            empCollection.Add(emp);
            empCollection.Add(emp1);
            empCollection.Add(emp2);
            empCollection.Add(emp3);
            //var infoData = new List<string>
            //{
            //    "Началник отдел	Росица Бончева Георгиева	512	r_boncheva@razgrad.bg	618/312",
            //    "Старши експерт	Кольо Недков Колев	506	k.kolev@razgrad.bg	618/218",
            //    "Младши експерт	Галина Иванова Маркова	506	sdd_eksperts@razgrad.bg	618/218	Замества се от Кадер Бейхан Мустафова",
            //    "Старши специалист - социални дейности	Маринка Дачева Николова	508		618/135"
            //};
            //allRecords.AddRange(infoData);

            return empCollection;
        }
    }
}