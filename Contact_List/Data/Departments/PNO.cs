using System.Collections.Generic;
using Data.Models;

namespace Data
{
    public class PNO
    {
        public static List<Employee> PNOEmp()
        {

            Employee emp = new Employee();
            emp.Department = "Правно нормативно обслужване";
            emp.professionalLeve = "Директор дирекция";
            emp.FirstName = "Хубан";
            emp.MiddleName = "Евгениев";
            emp.LastName = "Соколов";
            emp.roomNumber = "301";
            emp.email = "h.sokolov@razgrad.bg";
            emp.phoneNumber = "618/175";

            Employee emp1 = new Employee();
            emp1.Department = "Правно нормативно обслужване";
            emp1.professionalLeve = "Главен юрисконсулт - обществени поръчки";
            emp1.FirstName = "Билял";
            emp1.MiddleName = "Ибрахимов";
            emp1.LastName = "Црънгалов";
            emp1.roomNumber = "303";
            emp1.email = "b.trangalov@razgrad.bg";
            emp1.phoneNumber = "618/121";

            Employee emp2 = new Employee();
            emp2.Department = "Правно нормативно обслужване";
            emp2.professionalLeve = "Главен юрисконсулт - обществени поръчки";
            emp2.FirstName = "Виргиния";
            emp2.MiddleName = "Николаева";
            emp2.LastName = "Станкова";
            emp2.roomNumber = "303";
            emp2.email = "v.stankova@razgrad.bg";
            emp2.phoneNumber = "618/173";

            Employee emp3 = new Employee();
            emp3.Department = "Правно нормативно обслужване";
            emp3.professionalLeve = "Главен юрисконсулт - обществени поръчки";
            emp3.FirstName = "Веселка";
            emp3.MiddleName = "Младенова";
            emp3.LastName = "Дакова";
            emp3.roomNumber = "304";
            emp3.email = "v.dakova@razgrad.bg";
            emp3.phoneNumber = "618/171";

            Employee emp4 = new Employee();
            emp4.Department = "Правно нормативно обслужване";
            emp4.professionalLeve = "юрисконсулт";
            emp4.FirstName = "Мирослава";
            emp4.MiddleName = "Владимирова";
            emp4.LastName = "Михайлова";
            emp4.roomNumber = "304";
            emp4.email = "m.mihaylova@razgrad.bg";
            emp4.phoneNumber = "618/171";

            Employee emp5 = new Employee();
            emp5.Department = "Правно нормативно обслужване";
            emp5.professionalLeve = "юрисконсулт";
            emp5.FirstName = "Кристина";
            emp5.MiddleName = "Ивелинова";
            emp5.LastName = "Колева";
            emp5.roomNumber = "304";
            emp5.email = "k.koleva@razgrad.bg";
            emp5.phoneNumber = "618/171";


            Employee emp6 = new Employee();
            emp6.Department = "Правно нормативно обслужване";
            emp6.professionalLeve = "Главен юрисконсулт";
            emp6.FirstName = "Сабри";
            emp6.MiddleName = "Велиев";
            emp6.LastName = "Дурльов";
            emp6.roomNumber = "310";
            emp6.email = "";
            emp6.phoneNumber = "618/138";
            List<Employee> employees = new List<Employee>
            {
                emp, emp2, emp3, emp4, emp5, emp6
            };
            //var infoData = new List<string>
            //{
            //    "Директор дирекция	Хубан Евгениев Соколов	301	h.sokolov@razgrad.bg	618/175",
            //    "Главен юрисконсулт	Сабри Велиев Дурльов	310		618/138",
            //    "Главен юрисконсулт - обществени поръчки	Билял Ибрахимов Црънгалов	303	b.trangalov@razgrad.bg	618/121",
            //    "Главен юрисконсулт - обществени поръчки	Виргиния Николаева Станкова	303	v.stankova@razgrad.bg	618/173",
            //    "Главен юрисконсулт - обществени поръчки	Веселка Младенова Дакова 	304	v.dakova@razgrad.bg	618/171",
            //    "Юрисконсулт - обществени поръчки	Мирослава Владимирова Михайлова	304	m.mihaylova@razgrad.bg	618/171",
            //    "Юрисконсулт - обществени поръчки	Кристина Ивелинова Колева	304	k.koleva@razgrad.bg	618/171"
            //};
            // allRecords.AddRange(infoData);

            return employees;
        }
    }
}