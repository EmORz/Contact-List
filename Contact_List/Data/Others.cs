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

            var infoData = new List<Employee>
            {
                emp1, emp2
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
