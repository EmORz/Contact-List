using System.Collections.Generic;
using System.Linq;
using Data.Models;

namespace Data.Departments
{
    public class Investion
    {
        public static List<Employee> InvestionEmp()
        {
            //todo concat
            string[] fullName =
              {
                "Галина Панайотова Замфирова",
                "Дончо Иванов Дончев",
                "Камен Димитров Илиев",
                "Иван Тодоров Иванов",
                "Иванка Белева Минчеваа",
                "Димитринка Иванова Спасова",
                "Искрен Иванов Иванов"
            };
            Employee emp = new Employee();
            emp.Department = "Отдел \"Инвестиционни дейности\"";
            emp.professionalLeve = "Началник отдел";
            emp.FirstName = fullName[0].Split().ToArray()[0];
            emp.MiddleName = fullName[0].Split().ToArray()[1];
            emp.LastName = fullName[0].Split().ToArray()[2];
            emp.roomNumber = "204";
            emp.email = "invdeinost@razgrad.bg";
            emp.phoneNumber = "618/183";

            Employee emp1 = new Employee();
            emp1.Department = "Отдел \"Инвестиционни дейности\"";
            emp1.professionalLeve = "Главен експерт";
            emp1.FirstName = fullName[1].Split().ToArray()[0];
            emp1.MiddleName = fullName[1].Split().ToArray()[1];
            emp1.LastName = fullName[1].Split().ToArray()[2];
            emp1.roomNumber = "206";
            emp1.email = "energetica@razgrad.bg";
            emp1.phoneNumber = "618/113";


            Employee emp2 = new Employee();
            emp2.Department = "Отдел \"Инвестиционни дейности\"";
            emp2.professionalLeve = "Главен експерт";
            emp2.FirstName = fullName[2].Split().ToArray()[0];
            emp2.MiddleName = fullName[2].Split().ToArray()[1];
            emp2.LastName = fullName[2].Split().ToArray()[2];
            emp2.roomNumber = "202а";
            emp2.email = "k.iliev@razgrad.bg";
            emp2.phoneNumber = "618/141";

            Employee emp3 = new Employee();
            emp3.Department = "Отдел \"Инвестиционни дейности\"";
            emp3.professionalLeve = "Старши експерт";
            emp3.FirstName = fullName[3].Split().ToArray()[0];
            emp3.MiddleName = fullName[3].Split().ToArray()[1];
            emp3.LastName = fullName[3].Split().ToArray()[2];
            emp3.roomNumber = "206";
            emp3.email = "ato@razgrad.bg";
            emp3.phoneNumber = "618/113";

            Employee emp4 = new Employee();
            emp4.Department = "Отдел \"Инвестиционни дейности\"";
            emp4.professionalLeve = "Главен специалист";
            emp4.FirstName = fullName[4].Split().ToArray()[0];
            emp4.MiddleName = fullName[4].Split().ToArray()[1];
            emp4.LastName = fullName[4].Split().ToArray()[2];
            emp4.roomNumber = "203";
            emp4.email = "i.beleva@razgrad.bg";
            emp4.phoneNumber = "618/178";

            Employee emp5 = new Employee();
            emp5.Department = "Отдел \"Инвестиционни дейности\"";
            emp5.professionalLeve = "Главен специалист";
            emp5.FirstName = fullName[5].Split().ToArray()[0];
            emp5.MiddleName = fullName[5].Split().ToArray()[1];
            emp5.LastName = fullName[5].Split().ToArray()[2];
            emp5.roomNumber = "203";
            emp5.email = "d.spasova@razgrad.bg";
            emp5.phoneNumber = "618/178";
       

            Employee emp6 = new Employee();
            emp6.Department = "Отдел \"Инвестиционни дейности\"";
            emp6.professionalLeve = "Шофьор лекотоварен автомобил";
            emp6.FirstName = fullName[6].Split().ToArray()[0];
            emp6.MiddleName = fullName[6].Split().ToArray()[1];
            emp6.LastName = fullName[6].Split().ToArray()[2];
            emp6.roomNumber = "";
            emp6.email = "";
            emp6.phoneNumber = "";

            //var infoData = new List<string>
            //{
            //    "Началник отдел	Галина Панайотова Замфирова	204	invdeinost@razgrad.bg	618/183",
            //    "Главен експерт Поддръжка ЕЛ и ОВ	инж. Дончо Иванов Дончев	206	energetica@razgrad.bg	618/113",
            //    "Главен експерт	инж. Камен Димитров Илиев	202а	k.iliev@razgrad.bg	618/141",
            //    "Старши експерт	Иван Тодоров Иванов	206	ato@razgrad.bg	618/113",

            //    "Главен специалист инвеститорски контрол	Иванка Белева Минчева	203	i.beleva@razgrad.bg	618/178",

            //    "Главен специалист инвеститорски контрол	Димитринка Иванова Спасова	203	d.spasova@razgrad.bg	618/178",
            //    "Главен специалист инвеститорски контрол		203	ato@razgrad.bg	618/178",
            //    "Шофьор лекотоварен автомобил	 Искрен Иванов Иванов"
            //};

            List<Employee> empCollection = new List<Employee>
            {
                emp, emp1, emp2, emp3, emp4, emp5, emp6
            };

            return empCollection;
        }
    }
}