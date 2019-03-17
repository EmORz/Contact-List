using System.Collections.Generic;
using System.Linq;
using Data.Models;

namespace Data.Departments
{
    public class ProgramAndEkologie
    {
        public static List<Employee> PrigramAndEkologieEmp()
        {
            //todo add info and concat
            string[] fullName =
            {
                "Недим Ахмедов Тахиров",
                "Христина Димитрова Русева",
                "Даниела Тодорова Неделчева",
                "Пешо Димитров Димитров",
                "Света Красимирова Маринова",
                "Румяна Ненова Енчева",
                "Иван Василев Дучев",
                "Елвин Ердоан Шукриева",
                "Айля Юмерова Кърджалиева",
                "Татяна Димитрова Трифонова",
            };
            Employee emp = new Employee();
            emp.Department = "Дирекция \"Програми и околна среда\"";
            emp.professionalLeve = "Директор";
            emp.FirstName = fullName[0].Split().ToArray()[0];
            emp.MiddleName = fullName[0].Split().ToArray()[1];
            emp.LastName = fullName[0].Split().ToArray()[2];
            emp.roomNumber = "1011";
            emp.email = "";
            emp.phoneNumber = "618/278";

            //var infoData = new List<string>
            //{
            //    "Директор	Недим Ахмедов Тахиров	110	n.tahirov@razgrad.bg	618/220",
            //    "Началник отдел	Христина Димитрова Русева	405а	ipc@razgrad.bg	618/247",
            //    "Главен експерт		405а	eu@razgrad.bg	618/247",
            //    "Старши експерт	Даниела Тодорова Неделчева	405	d.nedelcheva@razgrad.bg	618/226",
            //    "Главен експерт	Пешо Димитров Димитров	 9		 618/120",
            //    "Мл. експерт	Деница Йорданова Пенчева	405		618/226 замества се от Света Красимирова Маринова",
            //    "Главен специалист - сътрудник	Румяна Ненова Енчева	208	g.georgieva@razgrad.bg	618/134",
            //    "Гл. експерт	Иван Василев Дучев	103	ekologia@razgrad.bg	618/186",
            //    "Младши експерт - екология	Елвин Ердоан Шукриева	110	ekologia@razgrad.bg	618/220",
            //    "Младши експерт - екология	Айля Юмерова Кърджалиева	103		618/186",
            //    "Старши специалист	Татяна Димитрова Трифонова	103		618/186"
            //};
            List<Employee> empCollection = new List<Employee>
            {
                emp
            };

            return empCollection;
        }
    }
}