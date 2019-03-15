using System.Collections.Generic;
using Data.Models;

namespace Data.Departments
{
    public class Chief
    {
        public static List<Employee> ChiefEmp()
        {
            Employee emp1 = new Employee();
            emp1.Department = "Кмет";
            emp1.professionalLeve = "д-р";
            emp1.FirstName = "Валентин";
            emp1.MiddleName = "Стефанов";
            emp1.LastName = "Василев";
            emp1.roomNumber = "307";
            emp1.email = "kmet@razgrad.bg";
            emp1.phoneNumber = "660/091;618/100";

            Employee emp2 = new Employee();
            emp2.Department = "сътрудник-кмет";
            emp2.professionalLeve = "главен";
            emp2.FirstName = "Красимира";
            emp2.MiddleName = "Илиева";
            emp2.LastName = "Василева";
            emp2.roomNumber = "307";
            emp2.email = "";
            emp2.phoneNumber = "618/133";

            Employee emp3 = new Employee();
            emp3.Department = "Зам.-Кмет";
            emp3.professionalLeve = "";
            emp3.FirstName = "Галина";
            emp3.MiddleName = "Милкова";
            emp3.LastName = "Георгиева-Маринова";
            emp3.roomNumber = "409";
            emp3.email = "	g.georgieva@razgrad.bg";
            emp3.phoneNumber = "618/360";

            Employee emp4 = new Employee();
            emp4.Department = "сътрудник-зам.-кмет";
            emp4.professionalLeve = "главен специалист";
            emp4.FirstName = "Румяна";
            emp4.MiddleName = "Ненова";
            emp4.LastName = "Енчева";
            emp4.roomNumber = "408";
            emp4.email = "";
            emp4.phoneNumber = "618/134";


            Employee emp5 = new Employee();
            emp5.Department = "Зам.-Кмет";
            emp5.professionalLeve = "";
            emp5.FirstName = "Ердинч";
            emp5.MiddleName = "Ахмедов";
            emp5.LastName = "Хасанов";
            emp5.roomNumber = "508";
            emp5.email = "e.hasanov@razgrad.bg";
            emp5.phoneNumber = "618/350";

            Employee emp6 = new Employee();
            emp6.Department = "сътрудник-зам.-кмет";
            emp6.professionalLeve = "главен специалист";
            emp6.FirstName = "Маринка";
            emp6.MiddleName = "Дачева";
            emp6.LastName = "Николова";
            emp6.roomNumber = "508";
            emp6.email = "";
            emp6.phoneNumber = "618/135";

            Employee emp7 = new Employee();
            emp7.Department = "Секретар на Общината";
            emp7.professionalLeve = "";
            emp7.FirstName = "Нели";
            emp7.MiddleName = "Стоянова";
            emp7.LastName = "Добрева";
            emp7.roomNumber = "507";
            emp7.email = "sdd@razgrad.bg";
            emp7.phoneNumber = "618/146";


            //Ръководство
            var infoData = new List<Employee>
            {
                emp1,emp2,emp3,emp4,emp5,emp6,emp7
            };
            return infoData;
        }

    }
}