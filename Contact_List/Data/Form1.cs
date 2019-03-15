using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Data;

namespace Data
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<string> allRecords = new List<string>();
        public List<string> allRecord = new List<string>();
        public List<Employee> allRec = new List<Employee>();
        
        public void RunFile()
        {
            var chief = Chief();
            var zveno = Odit();
            var arhitect = Architect();
            var lawers = PNO();
            var cultutre = Cultur();
            var piar = PIAR();
            var mdt = FDMDT();
            var programi = ProgramAndEkologiq();
            var invest = Investicion();
            var tsu = TSU();
            var dhd = HumanActivity();
            var social = SocialActivity();
            var narko = Narko();
            var zoos = ZOOS();
            var graon = GRAON();
            var it = ITService();
            var asd = ASD();
            var kmetstva = LocalMunicipality();
           // var others = Oth();
            var others = Others.Oth();

            allRec.AddRange(chief);
            allRec.AddRange(arhitect);
            allRec.AddRange(zveno);
            allRec.AddRange(lawers);
            allRecord.AddRange(cultutre);
            allRecord.AddRange(piar);
            allRecord.AddRange(mdt);
            allRecord.AddRange(programi);
            allRecord.AddRange(invest);
            allRecord.AddRange(tsu);
            allRecord.AddRange(dhd);
            allRec.AddRange(social);
            allRecord.AddRange(narko);
            allRec.AddRange(zoos);
            allRecord.AddRange(graon);
            allRec.AddRange(it);
            allRecord.AddRange(asd);
            allRecord.AddRange(kmetstva);
            allRec.AddRange(others);


        }
        private void button1_Click(object sender, EventArgs e)
        {
            RunFile();
            if (comboBox1.Text.Contains("Ръководство"))
            {
                var chief = Chief();
                //allRecords.AddRange(chief);
              
                PrintT(chief);

            }

            else if (comboBox1.Text.Contains("Звено за вътрешен одит"))
            {
                var odit = Odit();
            

                // allRecords.AddRange(odit);

                PrintT(odit);
            }
            else if (comboBox1.Text.Contains("Главен архитект"))
            {
                var odit = Architect();
                PrintT(odit);
            }
            else if (comboBox1.Text.Contains("Дирекция \"Правно нормативно обслужване\""))
            {
                var odit = PNO();
                PrintT(odit);
            }
            else if (comboBox1.Text.Contains("Дирекция \"Култура спорт и туризъм\""))
            {
                var odit = Cultur();
                //allRecords.AddRange(odit);

                Print(odit); 
            }
            else if (comboBox1.Text.Contains("Връзки с обществеността, протокол и международни дейности"))
            {
                var odit = PIAR();
                //allRecords.AddRange(odit);

                Print(odit);
            }
            else if (comboBox1.Text.Contains("Дирекция \"Финансови дейности и МДТ\""))
            {
                var odit = FDMDT();
                //allRecords.AddRange(odit);

                Print(odit);
            }
            else if (comboBox1.Text.Contains("Дирекция \"Програми и околна среда\""))
            {
                var odit = ProgramAndEkologiq();
               // allRecords.AddRange(odit);

                Print(odit);
            }
            else if (comboBox1.Text.Contains("Отдел \"Инвестиционни дейности\""))
            {
                var odit = Investicion();
                //allRecords.AddRange(odit);

                Print(odit);
            }
            else if (comboBox1.Text.Contains("Дирекция \"ТСУ, общинска собственост и контрол в строителството\""))
            {
                var odit = TSU();
               // allRecords.AddRange(odit);

                Print(odit);
            }
            else if (comboBox1.Text.Contains("Дирекция \"Хуманитарни дейности\""))
            {
                var odit = HumanActivity();
                //allRecords.AddRange(odit);

                Print(odit);
            }
            else if (comboBox1.Text.Contains("Отдел \"Социални дейности\""))
            {
                var odit = SocialActivity();
                //allRecords.AddRange(odit);

                PrintT(odit);
            }
            else if (comboBox1.Text.Contains("Общински съвет по наркотични вещества"))
            {
                var odit = Narko();
               // allRecords.AddRange(odit);

                Print(odit);
            }
            else if (comboBox1.Text.Contains("Отдел \"Гражданска регистрация и административно обслужване на населението\""))
            {
                var odit = GRAON();
               // allRecords.AddRange(odit);

                Print(odit);
            }
            else if (comboBox1.Text.Contains("Звено „Обслужване на Общински съвет”"))
            {
                var odit = ZOOS();
                //allRecords.AddRange(odit);

                PrintT(odit);
            }
            else if (comboBox1.Text.Contains("Информационно обслужване"))
            {
                var odit = ITService();
                //allRecords.AddRange(odit);

                PrintT(odit);
            }
            else if (comboBox1.Text.Contains("АСД, деловодство и архив"))
            {
                var odit = ASD();
                //allRecords.AddRange(odit);

                Print(odit);
            }
            else if (comboBox1.Text.Contains("Кметства"))
            {
                var odit = LocalMunicipality();
                //allRecords.AddRange(odit);

                Print(odit);
            }

            else if (comboBox1.Text.Contains("Други дейности към общинска администрация"))
            {
                var odit = Others.Oth();
                PrintT(odit);
            }
            else
            {
                var all = BossData(textBox1.Text.ToString()).Distinct();
                foreach (var b in all)
                {
                    this.richTextBox1.Text += b + "\n";
                }

                all.ToList().Clear();
                
                allRecord.Clear();
            }
         
            
        }

        private List<Employee> Odit()
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
        private List<Employee> Architect()
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
        private List<Employee> PNO()
        {
            
            Employee emp = new Employee();
            emp.Department = "Правно нормативно обслужване";
            emp.professionalLeve = "Директор дирекция";
            emp.FirstName = "Хубан";
            emp.MiddleName = "Евгениев";
            emp.LastName = "Соколов";
            emp.roomNumber = "301";
            emp.email = "h.sokolov@razgrad.bg";
            emp.phoneNumber = "618/175";

            Employee emp1 = new Employee();
            emp1.Department = "Правно нормативно обслужване";
            emp1.professionalLeve = "Главен юрисконсулт - обществени поръчки";
            emp1.FirstName = "Билял";
            emp1.MiddleName = "Ибрахимов";
            emp1.LastName = "Црънгалов";
            emp1.roomNumber = "303";
            emp1.email = "b.trangalov@razgrad.bg";
            emp1.phoneNumber = "618/121";

            Employee emp2 = new Employee();
            emp2.Department = "Правно нормативно обслужване";
            emp2.professionalLeve = "Главен юрисконсулт - обществени поръчки";
            emp2.FirstName = "Виргиния";
            emp2.MiddleName = "Николаева";
            emp2.LastName = "Станкова";
            emp2.roomNumber = "303";
            emp2.email = "v.stankova@razgrad.bg";
            emp2.phoneNumber = "618/173";

            Employee emp3 = new Employee();
            emp3.Department = "Правно нормативно обслужване";
            emp3.professionalLeve = "Главен юрисконсулт - обществени поръчки";
            emp3.FirstName = "Веселка";
            emp3.MiddleName = "Младенова";
            emp3.LastName = "Дакова";
            emp3.roomNumber = "304";
            emp3.email = "v.dakova@razgrad.bg";
            emp3.phoneNumber = "618/171";

            Employee emp4 = new Employee();
            emp4.Department = "Правно нормативно обслужване";
            emp4.professionalLeve = "юрисконсулт";
            emp4.FirstName = "Мирослава";
            emp4.MiddleName = "Владимирова";
            emp4.LastName = "Михайлова";
            emp4.roomNumber = "304";
            emp4.email = "m.mihaylova@razgrad.bg";
            emp4.phoneNumber = "618/171";

            Employee emp5 = new Employee();
            emp5.Department = "Правно нормативно обслужване";
            emp5.professionalLeve = "юрисконсулт";
            emp5.FirstName = "Кристина";
            emp5.MiddleName = "Ивелинова";
            emp5.LastName = "Колева";
            emp5.roomNumber = "304";
            emp5.email = "k.koleva@razgrad.bg";
            emp5.phoneNumber = "618/171";


            Employee emp6 = new Employee();
            emp6.Department = "Правно нормативно обслужване";
            emp6.professionalLeve = "Главен юрисконсулт";
            emp6.FirstName = "Сабри";
            emp6.MiddleName = "Велиев";
            emp6.LastName = "Дурльов";
            emp6.roomNumber = "310";
            emp6.email = "";
            emp6.phoneNumber = "618/138";
            List<Employee> employees = new List<Employee>
            {
                emp, emp2, emp3, emp4, emp5, emp6
            };
            //var infoData = new List<string>
            //{
            //    "Директор дирекция	Хубан Евгениев Соколов	301	h.sokolov@razgrad.bg	618/175",
            //    "Главен юрисконсулт	Сабри Велиев Дурльов	310		618/138",
            //    "Главен юрисконсулт - обществени поръчки	Билял Ибрахимов Црънгалов	303	b.trangalov@razgrad.bg	618/121",
            //    "Главен юрисконсулт - обществени поръчки	Виргиния Николаева Станкова	303	v.stankova@razgrad.bg	618/173",
            //    "Главен юрисконсулт - обществени поръчки	Веселка Младенова Дакова 	304	v.dakova@razgrad.bg	618/171",
            //    "Юрисконсулт - обществени поръчки	Мирослава Владимирова Михайлова	304	m.mihaylova@razgrad.bg	618/171",
            //    "Юрисконсулт - обществени поръчки	Кристина Ивелинова Колева	304	k.koleva@razgrad.bg	618/171"
            //};
           // allRecords.AddRange(infoData);

            return employees;
        }
        private List<string> Cultur()
        {
            var infoData = new List<string>
            {
                "Гл. експерт Спорт	Валери Бойчев Деков	503	boichev@razgrad.bg	618/243",
                "Гл. експерт	Камен Тодоров Кулев	503	kultura@razgrad.bg	618/243",
                "Гл. експерт „Култура” 	Виолета Антонова Атанасова	501	kultura@razgrad.bg	618/241",
                "Младши експерт	Росица Рашкова Раденкова	503	kultura@razgrad.bg	618/243",
                "Младши експерт	Виктория Недкова Иванова	512	kultura@razgrad.bg	618/214"
            };
            //allRecords.AddRange(infoData);

            return infoData;
        }

        private List<string> PIAR()
        {
            var infoData = new List<string>
            {
                "Старши експерт	Магдалина Йорданова Банкова	309	pr@razgrad.bg	660/230 618/300",
                "Главен специалист	Деница Веселинова Дилова-Маркова	310а		618/289",
                "Главен специалист-сътрудник 	Красимира Илиева Василева	307	kmet@razgrad.bg	660/092 618/133",
                "Главен специалист ръководител гараж	Галимир Димитров Минчев			618/124"
            };
            //allRecords.AddRange(infoData);

            return infoData;
        }
        private List<string> FDMDT()
        {
            var infoData = new List<string>
            {
                 "Директор	 Полина Тодорова Иванова	407	p.ivanova@razgrad.bg	618/144",
                "Началник отдел	 Кремена Красимирова Приставова	9	mdt@razgrad.bg	618/120 k.pristavova@razgrad.bg",
                "Главен експерт	Мариана Маринова Дочева	10	m.docheva@razgrad.bg	618/130",
                "Счетоводител оперативен	Елка Маринова Господинова	10		618/130",
                "Главен инспектор	Росен Йорданов Стоянов	111		618/112",
                "Инспектор	Павлинка Игнатова Петкова	фронт офис 2		618/301",
                "Специалист	Севинч Ергинова Исмаилова	фронт офис 2		618/301",
                "Данъчен инспектор	Павлина Стоянова Добрева	фронт офис 2	mdt_office@razgrad.bg 	618/301",
                "Инспектор	Йордан Йорданов Цанев	112		618/254",
                "Специалист	Цветомира Любомирова Иванова 	фронт офис 3		618/111",
                "Данъчен инспектор	Стоян Валентинов Стоянов	фронт офис 2		618/301",
                "Старши специалист	 Мария Тодорова Иванова	фронт офис 3		618/110",
                "Юрисконсулт	Емине Алкин Хюсеинова	302		618/315 замества се от Мариета Станимирова Борисова",
                "Старши специалист	Бахтишен Сали Тефик 	фронт офис 2		618/301",
                "Юрисконсулт	Димитър Василев Генов 	302	d.genov@razgrad.bg 	618/315",
                "Инспектор	Станислава Петрова Дачева	фронт офис 2		618/301",
                "Инспектор	 Неделина Йорданова Йорданова	112		618/254",
                "Инспектор	Николай Цонев Николов	112		618/254",
                "Ст. счетоводител	Павлина Тодорова Вангелова	403	p.vangelova@razgrad.bg	618/229",
                "Ст. счетоводител	Велина Великова Дачева	403	finansi@razgrad.bg	618/228",
                "Ст. счетоводител	Недялка Георгиева Янкова	404	n.yankova@razgrad.bg	618/221",
                "Ст. счетоводител	Галина Стоянова Йорданова	404	finansi@razgrad.bg	618/221 замества се отГабриела Миленова Петрова",
                "Ст. счетоводител	Габриела Красимирова Иванова-Илиева	404	finansi@razgrad.bg	618/225",
                "Счетоводител-оперативен	Нели Иванова Станчева	404	finansi@razgrad.bg	618/225",
                "Счетоводител	Анка Михайлова Иванова	411	a.ivanova@razgrad.bg	618/233",
                "Касиер-счетоводство	Галина Недялкова Димитрова	Фронт офис 1	g.dimitrova@razgrad.bg	618/302",
                "Главен експерт	Даниела Йорданова Николова	406	budget@razgrad.bg	618/137",
                "Главен експерт	Мартина Румянова Цолова	401	trz@razgrad.bg	618/231",
                "Главен експерт	Севдалина Иванова Карачанова	401	s.karachanova@razgrad.bg	618/235",
                "Главен експерт Човешки ресурси	Милена Найденова Рашкова 	402A	m.rashkova@razgrad.bg	618/285",
                "Главен специалист 	Галина Трифонова Неделчева	402	galina.nedelcheva@razgrad.bg	618/286",
                "Главен експерт Човешки ресурси	Галина Тодорова Великова 	402	g.velikova@razgrad.bg  	618/286"
            };
            //allRecords.AddRange(infoData);

            return infoData;
        }
        private List<string> ProgramAndEkologiq()
        {
            var infoData = new List<string>
            {
                "Директор	Недим Ахмедов Тахиров	110	n.tahirov@razgrad.bg	618/220",
                "Началник отдел	Христина Димитрова Русева	405а	ipc@razgrad.bg	618/247",
                "Главен експерт		405а	eu@razgrad.bg	618/247",
                "Старши експерт	Даниела Тодорова Неделчева	405	d.nedelcheva@razgrad.bg	618/226",
                "Главен експерт	Пешо Димитров Димитров	 9		 618/120",
                "Мл. експерт	Деница Йорданова Пенчева	405		618/226 замества се от Света Красимирова Маринова",
                "Главен специалист - сътрудник	Румяна Ненова Енчева	208	g.georgieva@razgrad.bg	618/134",
                "Гл. експерт	Иван Василев Дучев	103	ekologia@razgrad.bg	618/186",
                "Младши експерт - екология	Елвин Ердоан Шукриева	110	ekologia@razgrad.bg	618/220",
                "Младши експерт - екология	Айля Юмерова Кърджалиева	103		618/186",
                "Старши специалист	Татяна Димитрова Трифонова	103		618/186"
            };
            //allRecords.AddRange(infoData);

            return infoData;
        }
        private List<string> Investicion()
        {
            var infoData = new List<string>
            {
                "Началник отдел	Галина Панайотова Замфирова	204	invdeinost@razgrad.bg	618/183",
                "Главен експерт Поддръжка ЕЛ и ОВ	инж. Дончо Иванов Дончев	206	energetica@razgrad.bg	618/113",
                "Главен експерт	инж. Камен Димитров Илиев	202а	k.iliev@razgrad.bg	618/141",
                "Старши експерт	Иван Тодоров Иванов	206	ato@razgrad.bg	618/113",
                "Главен специалист инвеститорски контрол	Иванка Белева Минчева	203	i.beleva@razgrad.bg	618/178",
                "Главен специалист инвеститорски контрол	Димитринка Иванова Спасова	203	d.spasova@razgrad.bg	618/178",
                "Главен специалист инвеститорски контрол		203	ato@razgrad.bg	618/178",
                "Шофьор лекотоварен автомобил	 Искрен Иванов Иванов"
            };
            //allRecords.AddRange(infoData);

            return infoData;
        }
        private List<string> TSU()
        {
            var infoData = new List<string>
            {
               "Директор на дирекция	Христо Стоянов Христов	201	hhristov@razgrad.bg	618/177",
               "Старши специалист",
               "Старши юрисконсулт		205		618/187",
               "Отдел Териториално и селищно устройство, кадастър и търговия				",
               "Началник отдел		201		618/177",
               "Главен експерт	Ангел Георгиев Ангелов	211		618/211",
               "Главен специалист	Атанаска Спирова Стойчева	202	ato@razgrad.bg	618/181",
               "Старши специалист	Павел Петров Павлов	211		618/211",
               "Главен специалист	Пламена Йорданова Анферос	212	ato@razgrad.bg	618/212",
               "Главен специалист	Тодорка Симеонова Димитрова	205а	tsu@razgrad.bg	618/188",
               "Главен специалист	Кремена Росенова Неделчева	211	k.nedelcheva@razgrad.bg	618/211",
               "Старши специалист		209	  tsu@razgrad.bg	618/142",
               "Търговия				",
               "Главен експерт	Диана Стоянова Петкова	116	turgovia@razgrad.bg	618/222",
               "Главен експерт		116а	turgovia@razgrad.bg	618/224",
               "Старши експерт	Галя Василева Маринова	116а	turgovia@razgrad.bg	618/224",
               "Отдел Контрол по строителството ОРО и транспорт				",
               "Началник отдел		107	oro@razgrad.bg	618/155",
               "Главен инспектор	 Теодор Иванов Тодоров	114	ks@razgrad.bg	618/152",
               "Транспорт				",
               "Главен експерт Транспорт	Станимир Тодоров Стоянов	601	transport@razgrad.bg	618/257",
               "Главен специалист	Иваничка Темелкова Иванова	210a	tsu@razgrad.bg	618/244",
               "Главен експерт	Милен Асенов Миланов	210a	tsu@razgrad.bg	618/244",
               "Специалист	Сашка Крумова Възелова	105		618/251",
               "Контрол по обществен ред и транспорт				",
               "Старши инспектор ОРО	Пенка Тодорова Спиридонова	114		618/152",
               "Инспектор ОРО	Мелис Бейхатова Ибрахимова	115		618/258",
               "Инспектор ОРО	Димитър Стоянов Христов	115		618/258",
               "Инспектор ОРО	Светлан Иванов Стоянов	115		618/258",
               "Отдел Общинска собственост и земеделие				",
               "Н-к отдел	Иван Тодоров Ненов	412	ob_sobstvenost@razgrad.bg	618/143",
               "Главен експерт Общинска собственост	Ирина Иванова Илиева	413	i.ilieva@razgrad.bg,ob_sobstvenost@razgrad.bg	618/234",
               "Главен експерт Общинска собственост	Магдалена Михайлова Петрова	413	ob_sobstvenost@razgrad.bg	618/234",
               "Земеделие и стопанска дейност				",
               "Главен експерт Земеделие и стопанска дейност	Михаил Стефанов Балтаджиев	105	zemedelie@razgrad.bg	618/253",
               "Старши експерт	Пенка Димитрова Парашкевова	105	zemedelie@razgrad.bg	618/251",
               "Юрисконсулт	Стамена Стоянова Иванова	 413	urist.zemedelie@razgrad.bg	618/234",
               "Специалист поддръжка	Сунай Юкселов Мехмедов			618/277",
               "Главен експерт	Мирослава Георгиева Дзанева	гр.Разград, бул.България 21		661/366",
               "Старши специалист	Кремена Стоянова Йорданова	гр.Разград, бул.България 21		661/366",
               "Главен специалист - поддръжка	Валери Ангелов Вълчев	гр.Разград, бул.България 21		661/366",
            };
            //allRecords.AddRange(infoData);

            return infoData;
        }
        private List<string> HumanActivity()
        {
            var infoData = new List<string>
            {
                "Директор	Елка Станева Драмалиева	108	e.dramalieva@razgrad.bg	618/320",
                "Отдел Здравеопазване				",
                "Началник отдел	Йълдъз Хаккъ Шеремет	511	zdraveopazvane@razgrad.bg	618/311",
                "Отдел Образование",
                "Началник отдел	Красимира Танасова Кирчева	109 	obrazovanie@razgrad.bg	618/326",
                "Главен експерт Средно образование	Даринка Иванова Димитрова	109	obrazovanie@razgrad.bg	618/321",
                "Главен експерт	Айлин Решидова Маджарова-Ахмедова	109	obrazovanie@razgrad.bg	618/321",
                "Замества се от Теодора Найденова Ненкова			",
                "Младши експерт ”Предучилищно възпитание”		109	obrazovanie@razgrad.bg	618/325",
                "Технолог	Мехнур Ахмед Чакал		obrazovanie@razgrad.bg	618/324",
                "Главен счетоводител	Миглена Стефанова Дучева	109	obrazovanie@razgrad.bg	618/322",
                "Главен специалист “Бюджет и финанси”	Галина  Неделчева Крумова	109		618/322",
                "експерт ЧР и ТРЗ	Ралица Стоянова Дечева	109	obrazovanie@razgrad.bg	618/327"
            };
            //allRecords.AddRange(infoData);

            return infoData;
        }

        private List<Employee> SocialActivity()
        {
            Employee emp = new Employee();
            emp.Department = "Отдел Социални дейности";
            emp.professionalLeve = "Началник отдел";
            emp.FirstName = "Росица";
            emp.MiddleName = "Бончева";
            emp.LastName = "Георгиева";
            emp.roomNumber = "512";
            emp.email = "r_boncheva@razgrad.bg";
            emp.phoneNumber = "618/312";

            Employee emp1 = new Employee();
            emp1.Department = "Отдел Социални дейности";
            emp1.professionalLeve = "Старши експерт";
            emp1.FirstName = "Кольо";
            emp1.MiddleName = "Недков";
            emp1.LastName = "Колев";
            emp1.roomNumber = "506";
            emp1.email = "k.kolev@razgrad.bg";
            emp1.phoneNumber = "618/218";

            Employee emp2 = new Employee();
            emp2.Department = "Отдел Социални дейности";
            emp2.professionalLeve = "Младши експерт";
            emp2.FirstName = "Галина/Кадер";
            emp2.MiddleName = "Иванова/Бейха";
            emp2.LastName = "Маркова/Мустафа";
            emp2.roomNumber = "506";
            emp2.email = "sdd_eksperts@razgrad.bg";
            emp2.phoneNumber = "618/218";

            Employee emp3 = new Employee();
            emp3.Department = "Отдел Социални дейности";
            emp3.professionalLeve = "Старши специалист - секретар Хасанов";
            emp3.FirstName = "Маринка";
            emp3.MiddleName = "Дачева";
            emp3.LastName = "Николова";
            emp3.roomNumber = "508";
            emp3.email = "";
            emp3.phoneNumber = "618/135";

            List<Employee> empCollection = new List<Employee>();
            empCollection.Add(emp);
            empCollection.Add(emp1);
            empCollection.Add(emp2);
            empCollection.Add(emp3);
            //var infoData = new List<string>
            //{
            //    "Началник отдел	Росица Бончева Георгиева	512	r_boncheva@razgrad.bg	618/312",
            //    "Старши експерт	Кольо Недков Колев	506	k.kolev@razgrad.bg	618/218",
            //    "Младши експерт	Галина Иванова Маркова	506	sdd_eksperts@razgrad.bg	618/218	Замества се от Кадер Бейхан Мустафова",
            //    "Старши специалист - социални дейности	Маринка Дачева Николова	508		618/135"
            //};
            //allRecords.AddRange(infoData);

            return empCollection;
        }


        private List<string> Narko()
        {
            var infoData = new List<string>
            {
                "Секретар	Станислава Иванова Петрова		pic_rz@abv.bg	661/395",
                "Превантивно-информационен център към ОбСНВ				",
                "Главен експерт	Димитър Трифонов Димитров		pic_rz@abv.bg	661/395",
                "Главен експерт	Гергана Георгиева Йорданова		pic_rz@abv.bg	661/395",
                "Главен експерт	Миневер Ремзиева Мехмед		pic_rz@abv.bg	661/395",
                "Главен експерт-ПИЦ	Йорданка Цонева Маркова		pic_rz@abv.bg	661/395"
            };
            //allRecords.AddRange(infoData);

            return infoData;
        }
        private List<string> GRAON()
        {
            var infoData = new List<string>
            {
                "Началник отдел	Марияна Великова Димитрова	5	graon3@razgrad.bg	618/174",
                "Главен експерт	Сюзан Хъкметова Хасанова	Фронт-офис №5	graon7@razgrad.bg	618/172",
                "Старши експерт	Елка Кръстева Тодорова	Фронт-офис №5	graon4@razgrad.bg	618/167",
                "Старши експерт	Радостин Станчев Мицов	Фронт-офис №5	radostin.mitsov@razgrad.bg	618/167",
                "Старши специалист	Наташа Лалева Веселинова	Фронт-офис №5	graon5@razgrad.bg	618/168",
                "Старши специалист	Недялка Илиева Андреева	Фронт-офис №5	graon6@razgrad.bg	618/168"
            };
            //allRecords.AddRange(infoData);

            return infoData;
        }

        private List<Employee> ZOOS()
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

        private List<Employee> ITService()
        {
            Employee emp1 = new Employee();
            emp1.Department = "Информационно обслужване";
            emp1.professionalLeve = "Главен експерт";
            emp1.FirstName = "инж. Адриан";
            emp1.MiddleName = "Димитров";
            emp1.LastName = "Атанасов";
            emp1.roomNumber = "113";
            emp1.email = "it@razgrad.bg";
            emp1.phoneNumber = "618/273";

            Employee emp2 = new Employee();
            emp2.Department = "Информационно обслужване";
            emp2.professionalLeve = "Главен експерт";
            emp2.FirstName = "Галя";
            emp2.MiddleName = "Кръстева";
            emp2.LastName = "Кръстева";
            emp2.roomNumber = "113";
            emp2.email = "it@razgrad.bg / it_mdt@razgrad.bg";
            emp2.phoneNumber = "618/272";

            Employee emp3 = new Employee();
            emp3.Department = "Информационно обслужване";
            emp3.professionalLeve = "младши експерт";
            emp3.FirstName = "Десислава";
            emp3.MiddleName = "Стилиянова";
            emp3.LastName = "Тоцева";
            emp3.roomNumber = "Фронт-офис №1";
            emp3.email = "fo@razgrad.bg";
            emp3.phoneNumber = "618/304";

            Employee emp4 = new Employee();
            emp4.Department = "Информационно обслужване";
            emp4.professionalLeve = "Старши специалист";
            emp4.FirstName = "Валентина";
            emp4.MiddleName = "Иванова";
            emp4.LastName = "Илиева";
            emp4.roomNumber = "Фронт-офис №1";
            emp4.email = "";
            emp4.phoneNumber = "618/305";

            Employee emp5 = new Employee();
            emp5.Department = "Информационно обслужване";
            emp5.professionalLeve = "Старши специалист";
            emp5.FirstName = "Красимира";
            emp5.MiddleName = "Костадинова";
            emp5.LastName = "Неделчева";
            emp5.roomNumber = "Фронт-офис №1";
            emp5.email = "";
            emp5.phoneNumber = "618/303";

            //var infoData = new List<string>
            //{
            //    "Главен експерт	 Адриан Димитров Атанасов	113	it@razgrad.bg	618/273",
            //    "Главен експерт	Галя Кръстева Кръстева	113	it_mdt@razgrad.bg	618/272	it@razgrad.bg	",
            //    "Младши експерт	Десислава Стилиянова Тоцева	Фронт-офис №1	fo@razgrad.bg	618/304",
            //    "Младши експерт		Фронт-офис №1		618/306",
            //    "Старши специалист	Валентина Иванова Илиева 	Фронт-офис №1		618/305",
            //    "Старши специалист	Зелиха Юкселова Сали	Фронт-офис №1		618/303	Замества се от Красимира Костадинова Неделчева"
            //};
            List<Employee> empCollection = new List<Employee>
            {
                emp1,emp2,emp3,emp4,emp5
            };

            //allRecords.AddRange(infoData);

            return empCollection;
        }
        private List<string> ASD()
        {
            var infoData = new List<string>
            {
                "Старши експерт - АСД, деловодство и архив	Свилен Петков Станев	1011		618/278",
                "Старши експерт - деловодител	Пламена Неделчева Тодорова	Фронт офис 4	obshtina@razgrad.bg	618/213 Деловодство",
                "Старши експерт	Силвия Миленова Янева 	Фронт офис 4	obshtina@razgrad.bg	618/213	Деловодство		",
                "Младши експерт	Хафизе Реджеб Кадриева	Фронт офис 4	obshtina@razgrad.bg	618/213	Деловодство		",
                "Главен специалист архив	Гергина Василева Цолова	609		618/215",
                "Технически изпълнител	Петя Цонева Петрова	7		618/282",
                "Хигиенисти		1013		618/274"
            };
            //allRecords.AddRange(infoData);

            return infoData;
        }
        private List<string> LocalMunicipality()
        {
            var infoData = new List<string>
            {
                "Кмет		Тошко Николов Илиев	balkanski@razgrad.bg 	84719	224",
                "Ст. специалист		Диянка Цонева Димитрова	balkanski@razgrad.bg	84719	224",
                "Кмет		Момчил Йосифов Мизурски	blagoevo@razgrad.bg 	84713	225",
                "Ст. специалист		Божидарка Ганчева Радоева	blagoevo@razgrad.bg 	84713	225",
                "Кмет		Емил Боянов Гиздов	getsovo@razgrad.bg 	84	662730",
                "Ст. специалист		Мариана Пенчева Стоянова	getsovo@razgrad.bg 	84	662730",
                "Кмет		Христинка Иванoва Колева	dryanovets@razgrad.bg 	84718	220",
                "Ст. специалист		Ценка Йовчева Неделчева	dryanovets@razgrad.bg 	84718	220",
                "Кмет		Хюсеин Гафур Хаккъ	dyankovo@razgrad.bg 	84723	460",
                "Ст. специалист		Станчо Иванов Русев	dyankovo@razgrad.bg 	84723	422",
                "Ст. специалист		Зелиха Али Ибрахим	dyankovo1@razgrad.bg 	84723	235",
                "Кмет		Дамян Илиев Йосифов	kichenitsa@razgrad.bg 	84725	330",
                "Ст. специалист		Сюлбие Мюхидинова Тефик	kichenitsa@razgrad.bg	84725	330",
                "Кмет		Неждет Хасанов Мехмедов	lipnik@razgrad.bg	84721	221",
                "Ст. специалист		Лейля Исуфова Салиева	lipnik@razgrad.bg 	84721	221",
                "Кмет		Ферди Динчер Мехед	mortagonovo@razgrad.bg .	84711	201",
                "Ст. специалист		 Нурай Илми Ахмедова	mortagonovo@razgrad.bg 	84711	260",
                "Кмет		Хафизе Изетова Хасанова	nedoklan@razgrad.bg 	84269	213",
                "Ст. специалист		Господинка Костова Станева	nedoklan@razgrad.bg	84269	213",
                "Кмет		Димитър Минков Димитров	osenets@razgrad.bg 	84898	929",
                "Ст. специалист		Петя Матеева Иванова	osenets@razgrad.bg 	84898	929",
                "Кметски наместник		Лина Тошкова Тодорова	ostrovche@razgrad.bg 	84764	284",
                "Ст. специалист			ostrovche@razgrad.bg	84764	284",
                "Кмет		Росица Ненова Якимова	pobitkamak@razgrad.bg 	84717	201",
                "Специалист		Мая Вескова Цонева	pobitkamak@razgrad.bg	84717	201",
                "Кмет		Живка Валентинова Петрова	poroishte@razgrad.bg 	84	620991",
                "Ст. специалист		Снежана Добрева Атанасова	poroishte@razgrad.bg 	84	620991",
                "Кмет	Румяна Антонова Балтова		prostorno@razgrad.bg 	84266	266",
                "Ст. специалист	Нели Христова Хараламбиева		prostorno@razgrad.bg 	84266	266",
                "Кмет		Хава Исмаил Хюсеин	radingrad@razgrad.bg 	84726	310",
                "Кмет		Сюлейман Махмудов Салиев	rakovski@razgrad.bg 	84728	360",
                "Ст. специалист		Рефика Басриева Хюсеинова		84728	360",
                "Кмет		Нуридин Шинаси Мехмед	strazhets@razgrad.bg 	84	662731",
                "Ст. специалист		Севгюл Ахмед Мустафа	strazhets@razgrad.bg 	84	662731",
                "Кмет		Мирена Енева Симова	topchii@razgrad.bg 	84720	261",
                "Мл. експерт		Милена Дончева Стоянова	topchii@razgrad.bg 	84720	261",
                "Кмет		Иван Тодоров Димитров	ushintsi@razgrad.bg 	84726	232",
                "Ст. специалист		Вера Леонидова Димова	ushintsi@razgrad.bg 	84726	232",
                "Кметски наместник		Величка Андреева Стоянова	cherkovna@razgrad.bg	84722	267",
                "Ст. специалист			cherkovna@razgrad.bg	84722	267",
                "Кмет		Гюлджан Ахмедов Ахмедов	yasenovets@razgrad.bg 	84722	310",
                "Ст. специалист		Радостина Христова Великова	yasenovets@razgrad.bg	84722	313"
            };
            allRecords.AddRange(infoData);

            return infoData;
        }
        private List<string> Oth()
        {
            var infoData = new List<string>
            {
                "Мл.експерт „Етнически и интеграционни въпроси	 Емануил Александров Николов	602	eiv@razgrad.bg	618/180",
                "Функция Отбрана и сигурност			",
                "Главен експерт ОМП и сигурност на информацията		305	omp@razgrad.bg	618/252",
                "Младши експерт ОМП		305	omp@razgrad.bg	618/252",
                "Старши специалист	Данчо Владимиров Димитров	305		618/252",
                "Организация, контрол и изпълнение дейностите по поддържане чистотата в обществените територии				",
                "Ръководител звено	Николай Добромиров Николаев	114a	  	618/271",
                "Младши експерт	Рефие Гюрсел Хюсню	114a	r.hyusnyu@razgrad.bg	618/271",
                "Хижа м. „Пчелина”				",
                "Управител	 Ваня Стефанова Коцева			662/736",
                "Специалист поддръжка	 Матьо Иванов Коцев			662/736",
                "Дежурни				",
                "Денонощна охрана		1		618/132",
                "Пропуск		4		618/151",
                "Кафе „Панорама” Сграда на Общинска администрация, 11 ет. 618/287"
            };

            return infoData;
        }

        public void PrintT(List<Employee> collection)
        {
     

            this.richTextBox1.Text += "ОТДЕЛ/ДИРЕКЦИЯ" + " => "  +"ПРОФЕСИОНАЛНО НИВО"+" || "+ " ИМЕНА НА СЛУЖИТЕЛЯ "  + " || "+"СТАЯ/КАБИНЕТ"+" ИМЕЙЛ "+"ТЕЛЕФОНЕН НОМЕР"+ $"\n{new string('*', 130)}\n";
            var count = 0;
            this.richTextBox1.Text += $"Общо записи: {collection.Count}\n";
            foreach (var employee in collection)
            {
                this.richTextBox1.Text += count+". "+ employee.Department + " => " +employee.professionalLeve+" || "+ employee.FirstName + " "+employee.MiddleName+" " + employee.LastName+" || "
                                          +employee.roomNumber+" || "+employee.email+" || "+employee.phoneNumber + $"\n{new string('*', 130)}\n";
                count++;

            }

        }

        public void Print(List<string> temp)
        {
            for (int i = 0; i < temp.Count; i++)
            {
                this.richTextBox1.Text += i + " => " + temp[i] + $"\n{new string('*', 130)}\n";
            }
            allRecord.Clear();
        }

        public List<Employee> Chief()
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
        public List<string> BossData(string input)
        {
            var result =  new List<string>();
            var result01 = new List<string>();


            var counter = 0;

            for (int i = 0; i < allRec.Count; i++)
            {
                if (allRec[i].professionalLeve.ToLower().Contains(input.ToLower())||allRec[i].Department.ToLower().Contains(input) 
                                                                        || allRec[i].FirstName.ToLower().Contains(input.ToLower())
                                                                        ||allRec[i].LastName.ToLower().Contains(input.ToLower())
                                                                        ||allRec[i].MiddleName.ToLower().Contains(input.ToLower())
                                                                        ||allRec[i].roomNumber.ToLower().Contains(input.ToLower())
                                                                        ||allRec[i].email.ToLower().Contains(input.ToLower())
                                                                        ||allRec[i].phoneNumber.ToLower().Contains(input.ToLower()))
                {

                    var removeEmpty = allRec[i];
                    var temp = "";
                    StringBuilder sb = new StringBuilder();
                    sb.Append(counter);
                    sb.Append(" "+removeEmpty);
                    sb.AppendLine($"\n{new string('*', 130)}"+"\n");
                    counter++;
                    result.Add(sb.ToString());
                    result.Distinct();

                }
            }
            allRecord.Clear();
            foreach (var s in result.Distinct()) ;
            var tempo = result.Distinct().ToList();
            return tempo;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //otdel
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //person
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
            this.textBox1.Clear();
            this.allRec.Clear();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }

   
}
