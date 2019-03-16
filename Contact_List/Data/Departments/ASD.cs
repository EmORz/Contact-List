using System.Collections.Generic;
using System.Linq;
using Data.Models;

namespace Data.Departments
{
    public class ASD
    {
        public static List<Employee> ASDEmp()
        {
            string[] fullName =
            {
                "Свилен Петков Станев",
                "Пламена Неделчева Тодорова",
                "Силвия Миленова Янева",
                "Хафизе Реджеб Кадриева",
                "Гергина Василева Цолова",
                "Петя Цонева Петрова"
            };
            Employee emp = new Employee();
            emp.Department = "АСД, деловодство и архив";
            emp.professionalLeve = "Старши експерт";
            emp.FirstName = fullName[0].Split().ToArray()[0];
            emp.MiddleName = fullName[0].Split().ToArray()[1];
            emp.LastName = fullName[0].Split().ToArray()[2];
            emp.roomNumber = "1011";
            emp.email = "";
            emp.phoneNumber = "618/278";

            Employee emp1 = new Employee();
            emp1.Department = "АСД, деловодство и архив";
            emp1.professionalLeve = "Старши експерт - деловодител";
            emp1.FirstName = fullName[1].Split().ToArray()[0];
            emp1.MiddleName = fullName[1].Split().ToArray()[1];
            emp1.LastName = fullName[1].Split().ToArray()[2];
            emp1.roomNumber = "Фронт офис 4";
            emp1.email = "obshtina@razgrad.bg";
            emp1.phoneNumber = "618/213";

            Employee emp2 = new Employee();
            emp2.Department = "АСД, деловодство и архив";
            emp2.professionalLeve = "Старши експерт - деловодител";
            emp2.FirstName = fullName[2].Split().ToArray()[0];
            emp2.MiddleName = fullName[2].Split().ToArray()[1];
            emp2.LastName = fullName[2].Split().ToArray()[2];
            emp2.roomNumber = "Фронт офис 4";
            emp2.email = "obshtina@razgrad.bg";
            emp2.phoneNumber = "618/213";

            Employee emp3 = new Employee();
            emp3.Department = "АСД, деловодство и архив";
            emp3.professionalLeve = "Старши експерт - деловодител";
            emp3.FirstName = fullName[3].Split().ToArray()[0];
            emp3.MiddleName = fullName[3].Split().ToArray()[1];
            emp3.LastName = fullName[3].Split().ToArray()[2];
            emp3.roomNumber = "Фронт офис 4";
            emp3.email = "obshtina@razgrad.bg";
            emp3.phoneNumber = "618/213";

            Employee emp4 = new Employee();
            emp4.Department = "АСД, деловодство и архив";
            emp4.professionalLeve = "Главен специалист архив";
            emp4.FirstName = fullName[4].Split().ToArray()[0];
            emp4.MiddleName = fullName[4].Split().ToArray()[1];
            emp4.LastName = fullName[4].Split().ToArray()[2];
            emp4.roomNumber = "609";
            emp4.email = "";
            emp4.phoneNumber = "618/215";

            Employee emp5 = new Employee();
            emp5.Department = "АСД, деловодство и архив";
            emp5.professionalLeve = "Технически изпълнител";
            emp5.FirstName = fullName[5].Split().ToArray()[0];
            emp5.MiddleName = fullName[5].Split().ToArray()[1];
            emp5.LastName = fullName[5].Split().ToArray()[2];
            emp5.roomNumber = "7";
            emp5.email = "";
            emp5.phoneNumber = "618/282";

            Employee emp6 = new Employee();
            emp6.Department = "АСД, деловодство и архив";
            emp6.professionalLeve = "Хигиенисти";
            emp6.roomNumber = "1013";
            emp6.email = "";
            emp6.phoneNumber = "618/274";

            /* "Старши експерт - АСД, деловодство и архив	Свилен Петков Станев	1011		618/278",
               "Старши експерт - деловодител	Пламена Неделчева Тодорова	Фронт офис 4	obshtina@razgrad.bg	618/213 Деловодство",
               "Старши експерт	Силвия Миленова Янева 	Фронт офис 4	obshtina@razgrad.bg	618/213	Деловодство		",
               "Младши експерт	Хафизе Реджеб Кадриева	Фронт офис 4	obshtina@razgrad.bg	618/213	Деловодство		",
               "Главен специалист архив	Гергина Василева Цолова	609		618/215",
               "Технически изпълнител	Петя Цонева Петрова	7		618/282",
               "Хигиенисти		1013		618/274"*/
            List<Employee> empCollection = new List<Employee>
            {
                emp, emp1, emp2, emp3, emp4, emp5, emp6
            };

            return empCollection;
        }
    }
}