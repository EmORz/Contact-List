using System.Collections.Generic;

namespace Data
{
    public class Others
    {
        public static List<Employee> Oth()
        {
            Employee emp1 = new Employee();
            emp1.Department = "Отдел СД - Етнически и интеграционни въпроси";
            emp1.professionalLeve = "младши експерт";
            emp1.FirstName = "Емануил";
            emp1.MiddleName = "Александров";
            emp1.LastName = "Николов";
            emp1.roomNumber = "602";
            emp1.email = "eiv@razgrad.bg";
            emp1.phoneNumber = "618/180";

            Employee emp2 = new Employee();
            emp2.Department = "Функция Отбрана и сигурност";
            emp2.professionalLeve = "Старши специалист";
            emp2.FirstName = "Данчо";
            emp2.MiddleName = "Владимиров";
            emp2.LastName = "Димитров";
            emp2.roomNumber = "305";
            emp2.email = "";
            emp2.phoneNumber = "618/252";


            Employee emp3 = new Employee();
            emp3.Department = "Организация, контрол и изпълнение дейностите по поддържане чистотата в обществените територии";
            emp3.professionalLeve = "Ръководител звено";
            emp3.FirstName = "Николай";
            emp3.MiddleName = "Добромиров";
            emp3.LastName = "Николаев";
            emp3.roomNumber = "114а";
            emp3.email = "n.nikolaev@razgrad.bg";
            emp3.phoneNumber = "618/271";


            Employee emp4 = new Employee();
            emp4.Department = "Организация, контрол и изпълнение дейностите по поддържане чистотата в обществените територии";
            emp4.professionalLeve = "Младши експерт";
            emp4.FirstName = "Рефие";
            emp4.MiddleName = "Гюрсел";
            emp4.LastName = "Хюсню";
            emp4.roomNumber = "114а";
            emp4.email = "r.hyusnyu@razgrad.bg";
            emp4.phoneNumber = "618/271";

            Employee emp5 = new Employee();
            emp5.Department = "Хижа м. „Пчелина";
            emp5.professionalLeve = "Управител";
            emp5.FirstName = "Ваня";
            emp5.MiddleName = "Стефанова";
            emp5.LastName = "Коцева";
            emp5.roomNumber = "";
            emp5.email = "";
            emp5.phoneNumber = "662/736";


            Employee emp6 = new Employee();
            emp6.Department = "Хижа м. „Пчелина";
            emp6.professionalLeve = "Специалист поддръжка";
            emp6.FirstName = "Матьо";
            emp6.MiddleName = "Иванов";
            emp6.LastName = "Коцев";
            emp6.roomNumber = "";
            emp6.email = "";
            emp6.phoneNumber = "662/736";

            Employee emp7 = new Employee();
            emp7.Department = "Денонощна охрана";
            emp7.professionalLeve = "";
            emp7.FirstName = "";
            emp7.MiddleName = "";
            emp7.LastName = "";
            emp7.roomNumber = "1";
            emp7.email = "";
            emp7.phoneNumber = "618/132";


            Employee emp8 = new Employee();
            emp8.Department = "Пропуск";
            emp8.professionalLeve = "";
            emp8.FirstName = "";
            emp8.MiddleName = "";
            emp8.LastName = "";
            emp8.roomNumber = "4";
            emp8.email = "";
            emp8.phoneNumber = "618/151";

            Employee emp9 = new Employee();
            emp9.Department = "Кафе „Панорама”";
            emp9.professionalLeve = "";
            emp9.FirstName = "";
            emp9.MiddleName = "";
            emp9.LastName = "";
            emp9.roomNumber = "11 ет.";
            emp9.email = "";
            emp9.phoneNumber = "618/287";

            var infoData = new List<Employee>
            {
                emp1, emp2, emp3, emp4,emp5,emp6,emp7, emp8, emp9
            };

            //var infoData = new List<string>
            //{
            //    "Мл.експерт „Етнически и интеграционни въпроси	 Емануил Александров Николов	602	eiv@razgrad.bg	618/180",
            //    "Функция Отбрана и сигурност			",
            //    "Главен експерт ОМП и сигурност на информацията		305	omp@razgrad.bg	618/252",
            //    "Младши експерт ОМП		305	omp@razgrad.bg	618/252",
            //    "Старши специалист	Данчо Владимиров Димитров	305		618/252",
            //    "Организация, контрол и изпълнение дейностите по поддържане чистотата в обществените територии				",
            //    "Ръководител звено	Николай Добромиров Николаев	114a	  	618/271",
            //    "Младши експерт	Рефие Гюрсел Хюсню	114a	r.hyusnyu@razgrad.bg	618/271",
            //    "Хижа м. „Пчелина”				",
            //    "Управител	 Ваня Стефанова Коцева			662/736",
            //    "Специалист поддръжка	 Матьо Иванов Коцев			662/736",
            //    "Дежурни				",
            //    "Денонощна охрана		1		618/132",
            //    "Пропуск		4		618/151",
            //    "Кафе „Панорама” Сграда на Общинска администрация, 11 ет. 618/287"
            //};

            return infoData;
        }
    }
}
