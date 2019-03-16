using System.Collections.Generic;
using Data.Models;

namespace Data.Departments
{
    public class Culture
    {
        public static List<Employee> CultureEmp()
        {
            Employee emp1 = new Employee();
            emp1.Department = "Дирекция \"Култура спорт и туризъм\"";
            emp1.professionalLeve = "Главен експерт - Спорт";
            emp1.FirstName = "Валери";
            emp1.MiddleName = "Бойчев";
            emp1.LastName = "Деков";
            emp1.roomNumber = "503";
            emp1.email = "boichev@razgrad.bg";
            emp1.phoneNumber = "618/243";

            Employee emp2 = new Employee();
            emp2.Department = "Дирекция \"Култура спорт и туризъм\"";
            emp2.professionalLeve = "Главен експерт";
            emp2.FirstName = "Камен";
            emp2.MiddleName = "Тодоров";
            emp2.LastName = "Кулев";
            emp2.roomNumber = "503";
            emp2.email = "kultura@razgrad.bg";
            emp2.phoneNumber = "618/243";


            Employee emp3 = new Employee();
            emp3.Department = "Дирекция \"Култура спорт и туризъм\"";
            emp3.professionalLeve = "Главен експерт - Култура";
            emp3.FirstName = "Виолета";
            emp3.MiddleName = "Антонова";
            emp3.LastName = "Атанасова";
            emp3.roomNumber = "501";
            emp3.email = "kultura@razgrad.bg";
            emp3.phoneNumber = "618/241";

            Employee emp4 = new Employee();
            emp4.Department = "Дирекция \"Култура спорт и туризъм\"";
            emp4.professionalLeve = "Младши експерт";
            emp4.FirstName = "Росица";
            emp4.MiddleName = "Рашкова";
            emp4.LastName = "Раденкова";
            emp4.roomNumber = "503";
            emp4.email = "kultura@razgrad.bg";
            emp4.phoneNumber = "618/243";

            Employee emp5 = new Employee();
            emp5.Department = "Дирекция \"Култура спорт и туризъм\"";
            emp5.professionalLeve = "Младши експерт";
            emp5.FirstName = "Виктория";
            emp5.MiddleName = "Недкова";
            emp5.LastName = "Иванова";
            emp5.roomNumber = "512";
            emp5.email = "kultura@razgrad.bg";
            emp5.phoneNumber = "618/214";

            //"Гл. експерт Спорт	Валери Бойчев Деков	503	boichev@razgrad.bg	618/243",
            //"Гл. експерт	Камен Тодоров Кулев	503	kultura@razgrad.bg	618/243",
            //"Гл. експерт „Култура” 	Виолета Антонова Атанасова	501	kultura@razgrad.bg	618/241",
            //"Младши експерт	Росица Рашкова Раденкова	503	kultura@razgrad.bg	618/243",
            //"Младши експерт	Виктория Недкова Иванова	512	kultura@razgrad.bg	618/214"

            var infoData = new List<Employee>
            {
                emp1,emp2,emp3,emp4,emp5
            };

            //allRecords.AddRange(infoData);
            return infoData;
        }
    }
}