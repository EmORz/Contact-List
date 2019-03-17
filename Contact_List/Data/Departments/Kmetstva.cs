using System.Collections.Generic;
using System.Linq;
using Data.Models;

namespace Data.Departments
{
    public class Kmetstva
    {
        public static List<Employee> KmetstvaEmp()
        {
            //todo add info concat
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
                emp
            };

            return empCollection;
        }
    }
}