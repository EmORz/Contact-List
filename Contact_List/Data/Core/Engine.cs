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
            var cultutre = Culture.CultureEmp();
            var piar = PIAR.PiarEmp();
            //var mdt = FDMDT();
            //var programi = ProgramAndEkologiq();
            var invest = Investion.InvestionEmp();
            //var tsu = TSU();
            var dhd = HumanitieActivity.HumanitieEmp();
            var social = Data.SocialActivity.SocialActivityEmp();
           var narko = Narko.NarkoEmp();
            var zoos = Data.ZOOS.ZOOSEmp();
            var graon = GRAON.GRAONEmp();
            var it = ITService.ITServiceEmp();
            var asd = ASD.ASDEmp();
            //var kmetstva = LocalMunicipality();
            var others = Others.Oth();

            allRec.AddRange(chief);
            allRec.AddRange(arhitect);
            allRec.AddRange(zveno);
            allRec.AddRange(lawers);
            allRec.AddRange(cultutre);
            allRec.AddRange(piar);
            //allRecord.AddRange(mdt);
            //allRecord.AddRange(programi);
            allRec.AddRange(invest);
            //allRecord.AddRange(tsu);
            allRec.AddRange(dhd);
            allRec.AddRange(social);
            allRec.AddRange(narko);
            allRec.AddRange(zoos);
            allRec.AddRange(graon);
            allRec.AddRange(it);
           allRec.AddRange(asd);
           // allRecord.AddRange(kmetstva);
            allRec.AddRange(others);
        }

    }
}