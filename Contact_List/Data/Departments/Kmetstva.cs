﻿using System.Collections.Generic;
using Data.Models;

namespace Data.Departments
{
    public class Kmetstva
    {
        public static List<Employee> KmetstvaEmp()
        {
            Employee emp = new Employee();
            emp.Department = "Главен архитект";
            emp.professionalLeve = "";
            emp.FirstName = "Илин";
            emp.MiddleName = "Любомиров";
            emp.LastName = "Солаков";
            emp.roomNumber = "210";
            emp.email = "solakov@razgrad.bg";
            emp.phoneNumber = "618/149";

            //var infoData = new List<string>
            //{
            //    "Главен архитект	 арх. Илин Любомиров Солаков	210	solakov@razgrad.bg	618/149"
            //};
            List<Employee> empCollection = new List<Employee>();
            empCollection.Add(emp);

            //allRecords.AddRange(infoData);
            return empCollection;
        }
    }
}