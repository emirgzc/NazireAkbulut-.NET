using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IKitapService
	{
        List<Kitap> GetAll();
        List<Kitap> GetOrderByDate();
        List<Kitap> GetKitapByID(int id);
        Kitap GetByID(int id);
        void KitapAdd(Kitap kitap);
        void KitapUpdate(Kitap kitap);
        void KitapDelete(Kitap kitap);
    }
}
