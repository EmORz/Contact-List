using System.Collections.Generic;

namespace Data
{
    public class ITService
    {
        public static List<Employee> ITServiceEmp()
        {
            Employee emp1 = new Employee();
            emp1.Department = "Информационно обслужване";
            emp1.professionalLeve = "Главен експерт";
            emp1.FirstName = "инж. Адриан";
            emp1.MiddleName = "Димитров";
            emp1.LastName = "Атанасов";
            emp1.roomNumber = "113";
            emp1.email = "it@razgrad.bg";
            emp1.phoneNumber = "618/273";

            Employee emp2 = new Employee();
            emp2.Department = "Информационно обслужване";
            emp2.professionalLeve = "Главен експерт";
            emp2.FirstName = "Галя";
            emp2.MiddleName = "Кръстева";
            emp2.LastName = "Кръстева";
            emp2.roomNumber = "113";
            emp2.email = "it@razgrad.bg / it_mdt@razgrad.bg";
            emp2.phoneNumber = "618/272";

            Employee emp3 = new Employee();
            emp3.Department = "Информационно обслужване";
            emp3.professionalLeve = "младши експерт";
            emp3.FirstName = "Десислава";
            emp3.MiddleName = "Стилиянова";
            emp3.LastName = "Тоцева";
            emp3.roomNumber = "Фронт-офис №1";
            emp3.email = "fo@razgrad.bg";
            emp3.phoneNumber = "618/304";

            Employee emp4 = new Employee();
            emp4.Department = "Информационно обслужване";
            emp4.professionalLeve = "Старши специалист";
            emp4.FirstName = "Валентина";
            emp4.MiddleName = "Иванова";
            emp4.LastName = "Илиева";
            emp4.roomNumber = "Фронт-офис №1";
            emp4.email = "";
            emp4.phoneNumber = "618/305";

            Employee emp5 = new Employee();
            emp5.Department = "Информационно обслужване";
            emp5.professionalLeve = "Старши специалист";
            emp5.FirstName = "Красимира";
            emp5.MiddleName = "Костадинова";
            emp5.LastName = "Неделчева";
            emp5.roomNumber = "Фронт-офис №1";
            emp5.email = "";
            emp5.phoneNumber = "618/303";

            //var infoData = new List<string>
            //{
            //    "Главен експерт	 Адриан Димитров Атанасов	113	it@razgrad.bg	618/273",
            //    "Главен експерт	Галя Кръстева Кръстева	113	it_mdt@razgrad.bg	618/272	it@razgrad.bg	",
            //    "Младши експерт	Десислава Стилиянова Тоцева	Фронт-офис №1	fo@razgrad.bg	618/304",
            //    "Младши експерт		Фронт-офис №1		618/306",
            //    "Старши специалист	Валентина Иванова Илиева 	Фронт-офис №1		618/305",
            //    "Старши специалист	Зелиха Юкселова Сали	Фронт-офис №1		618/303	Замества се от Красимира Костадинова Неделчева"
            //};
            List<Employee> empCollection = new List<Employee>
            {
                emp1,emp2,emp3,emp4,emp5
            };

            //allRecords.AddRange(infoData);

            return empCollection;
        }
    }
}