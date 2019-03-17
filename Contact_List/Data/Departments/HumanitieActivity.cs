using System.Collections.Generic;
using System.Linq;
using Data.Models;

namespace Data.Departments
{
    public class HumanitieActivity
    {
        public static List<Employee> HumanitieEmp()
        {
            //todo concat
            string[] fullName =
            {
                "Елка Станева Драмалиева",
                "Йълдъз Хаккъ Шеремет",
                "Красимира Танасова Кирчева",
                "Даринка Иванова Димитрова",
                "Теодора Найденова Ненкова",
                "Мехнур Ахмед Чакал",
                "Миглена Стефанова Дучева",
                "Галина  Неделчева Крумова",
                "Ралица Стоянова Дечева"
            };
            Employee emp = new Employee();
            emp.Department = "Дирекция \"Хуманитарни дейности\"";
            emp.professionalLeve = "Директор";
            emp.FirstName = fullName[0].Split().ToArray()[0];
            emp.MiddleName = fullName[0].Split().ToArray()[1];
            emp.LastName = fullName[0].Split().ToArray()[2];
            emp.roomNumber = "108";
            emp.email = "e.dramalieva@razgrad.bg";
            emp.phoneNumber = "618/320";

            Employee emp1 = new Employee();
            emp1.Department = "Дирекция \"Хуманитарни дейности\"";
            emp1.professionalLeve = "Началник отдел - Здравеопазване";
            emp1.FirstName = fullName[1].Split().ToArray()[0];
            emp1.MiddleName = fullName[1].Split().ToArray()[1];
            emp1.LastName = fullName[1].Split().ToArray()[2];
            emp1.roomNumber = "511";
            emp1.email = "zdraveopazvane@razgrad.bg";
            emp1.phoneNumber = "618/311";


            Employee emp2 = new Employee();
            emp2.Department = "Дирекция \"Хуманитарни дейности\"";
            emp2.professionalLeve = "Началник отдел - Образование";
            emp2.FirstName = fullName[2].Split().ToArray()[0];
            emp2.MiddleName = fullName[2].Split().ToArray()[1];
            emp2.LastName = fullName[2].Split().ToArray()[2];
            emp2.roomNumber = "109";
            emp2.email = "obrazovanie@razgrad.bg";
            emp2.phoneNumber = "618/326";

            Employee emp3 = new Employee();
            emp3.Department = "Дирекция \"Хуманитарни дейности\"";
            emp3.professionalLeve = "Главен експерт Средно образование";
            emp3.FirstName = fullName[3].Split().ToArray()[0];
            emp3.MiddleName = fullName[3].Split().ToArray()[1];
            emp3.LastName = fullName[3].Split().ToArray()[2];
            emp3.roomNumber = "109";
            emp3.email = "obrazovanie@razgrad.bg";
            emp3.phoneNumber = "618/321";

            Employee emp4 = new Employee();
            emp4.Department = "Дирекция \"Хуманитарни дейности\"";
            emp4.professionalLeve = "Главен експерт Средно образование";
            emp4.FirstName = fullName[4].Split().ToArray()[0];
            emp4.MiddleName = fullName[4].Split().ToArray()[1];
            emp4.LastName = fullName[4].Split().ToArray()[2];
            emp4.roomNumber = "109";
            emp4.email = "obrazovanie@razgrad.bg";
            emp4.phoneNumber = "618/321";

            Employee emp5 = new Employee();
            emp5.Department = "Дирекция \"Хуманитарни дейности\"";
            emp5.professionalLeve = "Технолог";
            emp5.FirstName = fullName[5].Split().ToArray()[0];
            emp5.MiddleName = fullName[5].Split().ToArray()[1];
            emp5.LastName = fullName[5].Split().ToArray()[2];
            emp5.roomNumber = "";
            emp5.email = "obrazovanie@razgrad.bg";
            emp5.phoneNumber = "618/324";


            Employee emp6 = new Employee();
            emp6.Department = "Дирекция \"Хуманитарни дейности\"";
            emp6.professionalLeve = "Главен счетоводител";
            emp6.FirstName = fullName[6].Split().ToArray()[0];
            emp6.MiddleName = fullName[6].Split().ToArray()[1];
            emp6.LastName = fullName[6].Split().ToArray()[2];
            emp6.roomNumber = "109";
            emp6.email = "obrazovanie@razgrad.bg";
            emp6.phoneNumber = "618/322";

            Employee emp7 = new Employee();
            emp7.Department = "Дирекция \"Хуманитарни дейности\"";
            emp7.professionalLeve = "Главен специалист";
            emp7.FirstName = fullName[7].Split().ToArray()[0];
            emp7.MiddleName = fullName[7].Split().ToArray()[1];
            emp7.LastName = fullName[7].Split().ToArray()[2];
            emp7.roomNumber = "109";
            emp7.email = "obrazovanie@razgrad.bg";
            emp7.phoneNumber = "618/322";


            Employee emp8 = new Employee();
            emp8.Department = "Дирекция \"Хуманитарни дейности\"";
            emp8.professionalLeve = "експерт ЧР и ТРЗ";
            emp8.FirstName = fullName[8].Split().ToArray()[0];
            emp8.MiddleName = fullName[8].Split().ToArray()[1];
            emp8.LastName = fullName[8].Split().ToArray()[2];
            emp8.roomNumber = "109";
            emp8.email = "obrazovanie@razgrad.bg";
            emp8.phoneNumber = "618/327";

            //var infoData = new List<string>
            //{
            //    "Директор	Елка Станева Драмалиева	108	e.dramalieva@razgrad.bg	618/320",
            //    "Отдел Здравеопазване				",
            //    "Началник отдел	Йълдъз Хаккъ Шеремет	511	zdraveopazvane@razgrad.bg	618/311",
            //    "Отдел Образование",
            //    "Началник отдел	Красимира Танасова Кирчева	109 	obrazovanie@razgrad.bg	618/326",
            //    "Главен експерт Средно образование	Даринка Иванова Димитрова	109	obrazovanie@razgrad.bg	618/321",
            //    "Главен експерт	Айлин Решидова Маджарова-Ахмедова	109	obrazovanie@razgrad.bg	618/321",
            //    "Замества се от Теодора Найденова Ненкова			",
            //    "Младши експерт ”Предучилищно възпитание”		109	obrazovanie@razgrad.bg	618/325",
            //    "Технолог	Мехнур Ахмед Чакал		obrazovanie@razgrad.bg	618/324",
            //    "Главен счетоводител	Миглена Стефанова Дучева	109	obrazovanie@razgrad.bg	618/322",
            //    "Главен специалист “Бюджет и финанси”	Галина  Неделчева Крумова	109		618/322",
            //    "експерт ЧР и ТРЗ	Ралица Стоянова Дечева	109	obrazovanie@razgrad.bg	618/327"
            //};
            List<Employee> empCollection = new List<Employee>
            {
                emp, emp1, emp2, emp3, emp4, emp5, emp6,emp7, emp8
            };

            return empCollection;
        }
    }
}