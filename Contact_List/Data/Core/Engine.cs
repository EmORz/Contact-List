using System.Collections.Generic;
using Data.Departments;
using Data.Models;

namespace Data.Core
{
    public class Engine
    {
        public List<Employee> allRec = new List<Employee>();

        public void RunFile()
        {
            var chief = Chief.ChiefEmp();
            var zveno = Data.Odit.OditEmp();
            var arhitect = Architect.ArchitectEmp();
            var lawers = Data.PNO.PNOEmp();
            //var cultutre = Cultur();
            //var piar = PIAR();
            //var mdt = FDMDT();
            //var programi = ProgramAndEkologiq();
            //var invest = Investicion();
            //var tsu = TSU();
            //var dhd = HumanActivity();
            var social = Data.SocialActivity.SocialActivityEmp();
           // var narko = Narko();
            var zoos = Data.ZOOS.ZOOSEmp();
            //var graon = GRAON();
            var it = ITService.ITServiceEmp();
            //var asd = ASD();
            //var kmetstva = LocalMunicipality();
            var others = Others.Oth();

            allRec.AddRange(chief);
            allRec.AddRange(arhitect);
            allRec.AddRange(zveno);
            allRec.AddRange(lawers);
            //allRecord.AddRange(cultutre);
            //allRecord.AddRange(piar);
            //allRecord.AddRange(mdt);
            //allRecord.AddRange(programi);
            //allRecord.AddRange(invest);
            //allRecord.AddRange(tsu);
            //allRecord.AddRange(dhd);
            allRec.AddRange(social);
            //allRecord.AddRange(narko);
            allRec.AddRange(zoos);
           // allRecord.AddRange(graon);
            allRec.AddRange(it);
           // allRecord.AddRange(asd);
           // allRecord.AddRange(kmetstva);
            allRec.AddRange(others);
        }

    }
}