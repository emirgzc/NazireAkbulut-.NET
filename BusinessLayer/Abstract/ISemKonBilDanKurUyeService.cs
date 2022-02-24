using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface ISemKonBilDanKurUyeService
	{
        List<SemKonBilDanKurUye> GetAll();
        /*List<SemKonBilDanKurUye> GetOrderByDate();*/
        List<SemKonBilDanKurUye> GetSemKonBilDanKurUyeByID(int id);
        SemKonBilDanKurUye GetByID(int id);
        void SemKonBilDanKurUyeAdd(SemKonBilDanKurUye semKonBilDanKurUye);
        void SemKonBilDanKurUyeUpdate(SemKonBilDanKurUye semKonBilDanKurUye);
        void SemKonBilDanKurUyeDelete(SemKonBilDanKurUye semKonBilDanKurUye);
    }
}
