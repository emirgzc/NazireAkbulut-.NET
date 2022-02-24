using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IKonusmaciService
	{
        List<Konusmaci> GetAll();
        /*List<Konusmaci> GetOrderByDate();*/
        List<Konusmaci> GetKonusmaciByID(int id);
        Konusmaci GetByID(int id);
        void KonusmaciAdd(Konusmaci konusmaci);
        void KonusmaciUpdate(Konusmaci konusmaci);
        void KonusmaciDelete(Konusmaci konusmaci);
    }
}
