using Data.Core;
using Data.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Data.Models;

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

        Engine engine = new Engine();

        public void RunFile()
        {
            var mdt = FDMDT();
            var programi = ProgramAndEkologiq();
            var tsu = TSU();
            var kmetstva = LocalMunicipality();
            
            allRecord.AddRange(mdt);
            allRecord.AddRange(programi);
            allRecord.AddRange(tsu);
            allRecord.AddRange(kmetstva);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            engine.RunFile();
            RunFile();
            if (comboBox1.Text.Contains("Ръководство"))
            {
                var chief = Chief.ChiefEmp();
                PrintT(chief);
            }

            else if (comboBox1.Text.Contains("Звено за вътрешен одит"))
            {
                var odit = Data.Odit.OditEmp();
                PrintT(odit);
            }
            else if (comboBox1.Text.Contains("Главен архитект"))
            {
                var odit = Architect.ArchitectEmp();
                PrintT(odit);
            }
            else if (comboBox1.Text.Contains("Дирекция \"Правно нормативно обслужване\""))
            {
                var odit = Data.PNO.PNOEmp();
                PrintT(odit);
            }
            else if (comboBox1.Text.Contains("Дирекция \"Култура спорт и туризъм\""))
            {
                var odit = Culture.CultureEmp();
                PrintT(odit); 
            }
            else if (comboBox1.Text.Contains("Връзки с обществеността, протокол и международни дейности"))
            {
                var odit = Departments.PIAR.PiarEmp();
                PrintT(odit);
            }
            else if (comboBox1.Text.Contains("Дирекция \"Финансови дейности и МДТ\""))
            {
                var odit = FDMDT();
                Print(odit);
            }
            else if (comboBox1.Text.Contains("Дирекция \"Програми и околна среда\""))
            {
                var odit = ProgramAndEkologiq();
                Print(odit);
            }
            else if (comboBox1.Text.Contains("Отдел \"Инвестиционни дейности\""))
            {
                var odit = Investion.InvestionEmp();
                PrintT(odit);
            }
            else if (comboBox1.Text.Contains("Дирекция \"ТСУ, общинска собственост и контрол в строителството\""))
            {
                var odit = TSU();
                Print(odit);
            }
            else if (comboBox1.Text.Contains("Дирекция \"Хуманитарни дейности\""))
            {
                var odit = HumanitieActivity.HumanitieEmp();
                PrintT(odit);
            }
            else if (comboBox1.Text.Contains("Отдел \"Социални дейности\""))
            {
                var odit = Data.SocialActivity.SocialActivityEmp();
                PrintT(odit);
            }
            else if (comboBox1.Text.Contains("Общински съвет по наркотични вещества"))
            {
                var odit = Narko.NarkoEmp();
                PrintT(odit);
            }
            else if (comboBox1.Text.Contains("Отдел \"Гражданска регистрация и административно обслужване на населението\""))
            {
                var odit = Departments.GRAON.GRAONEmp();
                PrintT(odit);
            }
            else if (comboBox1.Text.Contains("Звено „Обслужване на Общински съвет”"))
            {
                var odit = Data.ZOOS.ZOOSEmp();
                PrintT(odit);
            }
            else if (comboBox1.Text.Contains("Информационно обслужване"))
            {
                var odit = ITService.ITServiceEmp();
                PrintT(odit);
            }
            else if (comboBox1.Text.Contains("АСД, деловодство и архив"))
            {
                var odit = Departments.ASD.ASDEmp();

                PrintT(odit);
            }
            else if (comboBox1.Text.Contains("Кметства"))
            {
                var odit = LocalMunicipality();
                Print(odit);
            }

            else if (comboBox1.Text.Contains("Други дейности към общинска администрация"))
            {
                var odit = Others.Oth();
                PrintT(odit);
            }
            else
            {
                var all = BossData(textBox1.Text.ToString());
                foreach (var b in all)
                {
                    this.richTextBox1.Text += b + "\n";
                }
                all.ToList().Clear();
                allRecord.Clear();
            }
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
        

        public void PrintT(List<Employee> collection)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ОТДЕЛ/ДИРЕКЦИЯ" + " => " + "ПРОФЕСИОНАЛНО НИВО" + " || " + " ИМЕНА НА СЛУЖИТЕЛЯ " + " || " + "СТАЯ/КАБИНЕТ" + " ИМЕЙЛ " + "ТЕЛЕФОНЕН НОМЕР" + $"\n{new string('*', 130)}\n");
            var count = 0;
            sb.AppendLine($"Общо записи: {collection.Count}\n");
            foreach (var employee in collection)
            {
                sb.AppendLine(count+".=> "+employee+ $"\n{new string('*', 130)}\n");
                this.richTextBox1.Text = sb.ToString().Trim();
                count++;
            }
        }

        public void Print(List<string> temp)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ОТДЕЛ/ДИРЕКЦИЯ" + " => " + "ПРОФЕСИОНАЛНО НИВО" + " || " + " ИМЕНА НА СЛУЖИТЕЛЯ " + " || " + "СТАЯ/КАБИНЕТ" + " ИМЕЙЛ " + "ТЕЛЕФОНЕН НОМЕР" + $"\n{new string('*', 130)}\n");
            sb.AppendLine($"Общо записи: {temp.Count}\n");

            for (int i = 0; i < temp.Count; i++)
            {
                sb.AppendLine(i + ".=> " + temp[i] + $"\n{new string('*', 130)}\n");
                this.richTextBox1.Text = sb.ToString().Trim();
            }
            allRecord.Clear();
        }

        public List<string> BossData(string input)
        {
            var result =  new List<string>();
            var allRec = engine.allRec;

            var counter = 0;

            for (int i = 0; i < allRec.Count; i++)
            {
                if (allRec[i].professionalLeve.ToLower().Contains(input.ToLower().Trim())
                                                                        ||allRec[i].Department.ToLower().Contains(input.ToLower().Trim()) 
                                                                        || allRec[i].FirstName.ToLower().Contains(input.ToLower().Trim())
                                                                        ||allRec[i].LastName.ToLower().Contains(input.ToLower().Trim())
                                                                        ||allRec[i].MiddleName.ToLower().Contains(input.ToLower().Trim())
                                                                        ||allRec[i].roomNumber.ToLower().Contains(input.ToLower().Trim())
                                                                        ||allRec[i].email.ToLower().Contains(input.ToLower().Trim())
                                                                        ||allRec[i].phoneNumber.ToLower().Contains(input.ToLower().Trim()))
                {

                    var removeEmpty = allRec[i];
                    StringBuilder sb = new StringBuilder();
                    sb.Append(counter);
                    sb.Append(" "+removeEmpty);
                    sb.AppendLine($"\n{new string('*', 130)}"+"\n");
                    counter++;
                    result.Add(sb.ToString());
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
            engine.allRec.Clear();
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
