using System.Collections.Generic;
using Data.Models;

namespace Data.Departments
{
    public class GRAON
    {
        public static List<Employee> GRAONEmp()
        {
            Employee emp = new Employee();
            emp.Department = "ГРАОН";
            emp.professionalLeve = "Началник отдел";
            emp.FirstName = "Марияна";
            emp.MiddleName = "Великова";
            emp.LastName = "Димитрова";
            emp.roomNumber = "5";
            emp.email = "graon3@razgrad.bg";
            emp.phoneNumber = "618/174";

            Employee emp1 = new Employee();
            emp1.Department = "ГРАОН";
            emp1.professionalLeve = "Главен експерт";
            emp1.FirstName = "Сюзан";
            emp1.MiddleName = "Хъкметова";
            emp1.LastName = "Хасанова";
            emp1.roomNumber = "Фронт-офис №5";
            emp1.email = "graon7@razgrad.bg";
            emp1.phoneNumber = "618/172";

            Employee emp2 = new Employee();
            emp2.Department = "ГРАОН";
            emp2.professionalLeve = "Старши експерт";
            emp2.FirstName = "Елка";
            emp2.MiddleName = "Кръстева";
            emp2.LastName = "Тодорова";
            emp2.roomNumber = "Фронт-офис №5";
            emp2.email = "graon4@razgrad.bg";
            emp2.phoneNumber = "618/167";

            Employee emp3 = new Employee();
            emp3.Department = "ГРАОН";
            emp3.professionalLeve = "Старши експерт";
            emp3.FirstName = "Радостин";
            emp3.MiddleName = "Станчев";
            emp3.LastName = "Мицов";
            emp3.roomNumber = "Фронт-офис №5";
            emp3.email = "radostin.mitsov@razgrad.bg";
            emp3.phoneNumber = "618/167";

            Employee emp4 = new Employee();
            emp4.Department = "ГРАОН";
            emp4.professionalLeve = "Старши специалист";
            emp4.FirstName = "Наташа";
            emp4.MiddleName = "Лалева";
            emp4.LastName = "Веселинова";
            emp4.roomNumber = "Фронт-офис №5";
            emp4.email = "graon5@razgrad.bg";
            emp4.phoneNumber = "618/168";

            Employee emp5 = new Employee();
            emp5.Department = "ГРАОН";
            emp5.professionalLeve = "Старши специалист";
            emp5.FirstName = "Недялка";
            emp5.MiddleName = "Илиева";
            emp5.LastName = "Андреева";
            emp5.roomNumber = "Фронт-офис №5";
            emp5.email = "graon6@razgrad.bg";
            emp5.phoneNumber = "618/168";

            /*      "Началник отдел	Марияна Великова Димитрова	5	graon3@razgrad.bg	618/174",
                "Главен експерт	Сюзан Хъкметова Хасанова	Фронт-офис №5	graon7@razgrad.bg	618/172",
                "Старши експерт	Елка Кръстева Тодорова	Фронт-офис №5	graon4@razgrad.bg	618/167",
                "Старши експерт	Радостин Станчев Мицов	Фронт-офис №5	radostin.mitsov@razgrad.bg	618/167",
                "Старши специалист	Наташа Лалева Веселинова	Фронт-офис №5	graon5@razgrad.bg	618/168",
                "Старши специалист	Недялка Илиева Андреева	Фронт-офис №5	graon6@razgrad.bg	618/168"*/
            List<Employee> empCollection = new List<Employee>
            {
                emp,emp1, emp2,emp3, emp4, emp5

            };
            
            return empCollection;
        }
    }
}