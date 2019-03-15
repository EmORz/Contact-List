using System.Collections.Generic;
using Data.Models;

namespace Data
{
    public class Odit
    {

        public static List<Employee> OditEmp()
        {
            Employee emp = new Employee();
            emp.Department = "Звено за вътрешен одит";
            emp.professionalLeve = "Главен вътрешен одитор";
            emp.FirstName = "Даринка";
            emp.MiddleName = "Неделчева";
            emp.LastName = "Илиева";
            emp.roomNumber = "906";
            emp.email = "darina.ilieva@razgrad.bg";
            emp.phoneNumber = "618/182";



            List<Employee> empCollection = new List<Employee>();
            empCollection.Add(emp);

            //allRecords.AddRange(infoData);
            return empCollection;


        }

    }
}