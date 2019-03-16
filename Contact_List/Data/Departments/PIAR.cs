using System;
using System.Collections.Generic;
using System.Linq;
using Data.Models;

namespace Data.Departments
{
    public class PIAR
    {
        public static List<Employee> PiarEmp()
        {
            string[] fullName =
            {
                "Магдалина Йорданова Банкова", "Деница Веселинова Дилова-Маркова", "Красимира Илиева Василева",
                "Галимир Димитров Минчев"
            };
            Employee emp = new Employee();
            emp.Department = "Връзки с обществеността, протокол и международни дейности";
            emp.professionalLeve = "Старши експерт";
            emp.FirstName = fullName[0].Split().ToArray()[0];
            emp.MiddleName = fullName[0].Split().ToArray()[1];
            emp.LastName = fullName[0].Split().ToArray()[2];
            emp.roomNumber = "309";
            emp.email = "pr@razgrad.bg";
            emp.phoneNumber = "618/300;660/230";

            Employee emp1 = new Employee();
            emp1.Department = "Връзки с обществеността, протокол и международни дейности";
            emp1.professionalLeve = "Главен специалист";
            emp1.FirstName = fullName[1].Split().ToArray()[0];
            emp1.MiddleName = fullName[1].Split().ToArray()[1];
            emp1.LastName = fullName[1].Split().ToArray()[2];
            emp1.roomNumber = "310a";
            emp1.email = "";
            emp1.phoneNumber = "618/289";

            Employee emp2 = new Employee();
            emp2.Department = "Връзки с обществеността, протокол и международни дейности";
            emp2.professionalLeve = "Главен специалист - сътрудник";
            emp2.FirstName = fullName[2].Split().ToArray()[0];
            emp2.MiddleName = fullName[2].Split().ToArray()[1];
            emp2.LastName = fullName[2].Split().ToArray()[2];
            emp2.roomNumber = "307";
            emp2.email = "kmet@razgrad.bg";
            emp2.phoneNumber = "660/092 618/133";

            Employee emp3 = new Employee();
            emp3.Department = "Връзки с обществеността, протокол и международни дейности";
            emp3.professionalLeve = "Главен специалист - ръководител гараж";
            emp3.FirstName = fullName[3].Split().ToArray()[0];
            emp3.MiddleName = fullName[3].Split().ToArray()[1];
            emp3.LastName = fullName[3].Split().ToArray()[2];
            emp3.roomNumber = "307";
            emp3.email = "kmet@razgrad.bg";
            emp3.phoneNumber = "618/124";

            //"Старши експерт	Магдалина Йорданова Банкова	309	pr@razgrad.bg	660/230 618/300",
            //"Главен специалист	Деница Веселинова Дилова-Маркова	310а		618/289",
            //"Главен специалист-сътрудник 	Красимира Илиева Василева	307	kmet@razgrad.bg	660/092 618/133",
            //"Главен специалист ръководител гараж	Галимир Димитров Минчев			618/124";
            List<Employee> empCollection = new List<Employee>
            {
                emp, emp1, emp2, emp3
            };
            
            return empCollection;
        }
    }
}