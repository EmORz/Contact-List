using System.Collections.Generic;

namespace Data
{
    public class ZOOS
    {


        public static List<Employee> ZOOSEmp()
        {
            Employee emp = new Employee();
            emp.Department = "Звено за обслужване на Общински съвет";
            emp.professionalLeve = "Старши експерт";
            emp.FirstName = "д-р Едибе";
            emp.MiddleName = "Реджаиева";
            emp.LastName = "Ахмедова";
            emp.roomNumber = "505";
            emp.email = "e.ahmedova@razgrad.bg";
            emp.phoneNumber = "618/217";

            Employee emp1 = new Employee();
            emp1.Department = "Звено за обслужване на Общински съвет";
            emp1.professionalLeve = "Главен специалист";
            emp1.FirstName = "Светлозара";
            emp1.MiddleName = "Венелинова";
            emp1.LastName = "Захариева";
            emp1.roomNumber = "505А";
            emp1.email = "s.zaharieva@razgrad.bg";
            emp1.phoneNumber = "618/237";



            List<Employee> empCollection = new List<Employee>();
            empCollection.Add(emp);
            empCollection.Add(emp1);

            return empCollection;
        }
    }
}