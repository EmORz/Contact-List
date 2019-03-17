using System.Collections.Generic;
using System.Linq;
using Data.Models;

namespace Data.Departments
{
    public class Narko
    {
        public static List<Employee> NarkoEmp()
        {
            //todo concat
            string[] fullName =
              {
                "Станислава Иванова Петрова",
                "Димитър Трифонов Димитров",
                "Гергана Георгиева Йорданова",
                "Миневер Ремзиева Мехмед",
                "Йорданка Цонева Маркова"
            };
            Employee emp = new Employee();
            emp.Department = "Общински съвет по наркотични вещества";
            emp.professionalLeve = "Секретар";
            emp.FirstName = fullName[0].Split().ToArray()[0];
            emp.MiddleName = fullName[0].Split().ToArray()[1];
            emp.LastName = fullName[0].Split().ToArray()[2];
            emp.roomNumber = "гр.Разград, ул.“Н.Й.Вапцаров” 10 Средношколско общежитие, стая 114";
            emp.email = "pic_rz@abv.bg";
            emp.phoneNumber = "661/395";

            Employee emp1 = new Employee();
            emp1.Department = "Общински съвет по наркотични вещества";
            emp1.professionalLeve = "Главен експерт";
            emp1.FirstName = fullName[1].Split().ToArray()[0];
            emp1.MiddleName = fullName[1].Split().ToArray()[1];
            emp1.LastName = fullName[1].Split().ToArray()[2];
            emp1.roomNumber = "гр.Разград, ул.“Н.Й.Вапцаров” 10 Средношколско общежитие, стая 114";
            emp1.email = "pic_rz@abv.bg";
            emp1.phoneNumber = "661/395";

            Employee emp2 = new Employee();
            emp2.Department = "Общински съвет по наркотични вещества";
            emp2.professionalLeve = "Главен експерт";
            emp2.FirstName = fullName[2].Split().ToArray()[0];
            emp2.MiddleName = fullName[2].Split().ToArray()[1];
            emp2.LastName = fullName[2].Split().ToArray()[2];
            emp2.roomNumber = "гр.Разград, ул.“Н.Й.Вапцаров” 10 Средношколско общежитие, стая 114";
            emp2.email = "pic_rz@abv.bg";
            emp2.phoneNumber = "661/395";

            Employee emp3 = new Employee();
            emp3.Department = "Общински съвет по наркотични вещества";
            emp3.professionalLeve = "Главен експерт";
            emp3.FirstName = fullName[3].Split().ToArray()[0];
            emp3.MiddleName = fullName[3].Split().ToArray()[1];
            emp3.LastName = fullName[3].Split().ToArray()[2];
            emp3.roomNumber = "гр.Разград, ул.“Н.Й.Вапцаров” 10 Средношколско общежитие, стая 114";
            emp3.email = "pic_rz@abv.bg";
            emp3.phoneNumber = "661/395";


            Employee emp4 = new Employee();
            emp4.Department = "Общински съвет по наркотични вещества";
            emp4.professionalLeve = "Главен експерт-ПИЦ";
            emp4.FirstName = fullName[4].Split().ToArray()[0];
            emp4.MiddleName = fullName[4].Split().ToArray()[1];
            emp4.LastName = fullName[4].Split().ToArray()[2];
            emp4.roomNumber = "гр.Разград, ул.“Н.Й.Вапцаров” 10 Средношколско общежитие, стая 114";
            emp4.email = "pic_rz@abv.bg";
            emp4.phoneNumber = "661/395";

            //var infoData = new List<string>
            //{
            //    "Секретар	Станислава Иванова Петрова		pic_rz@abv.bg	661/395",
            //    "Превантивно-информационен център към ОбСНВ				",
            //    "Главен експерт	Димитър Трифонов Димитров		pic_rz@abv.bg	661/395",
            //    "Главен експерт	Гергана Георгиева Йорданова		pic_rz@abv.bg	661/395",
            //    "Главен експерт	Миневер Ремзиева Мехмед		pic_rz@abv.bg	661/395",
            //    "Главен експерт-ПИЦ	Йорданка Цонева Маркова		pic_rz@abv.bg	661/395"
            //};
            List<Employee> empCollection = new List<Employee>
            {
                emp, emp1, emp2, emp3, emp4
            };

            return empCollection;
        }
    }
}