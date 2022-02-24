using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IMesKurUyeService
	{
        List<MesKurUye> GetAll();
        /*List<MesKurUye> GetOrderByDate();*/
        List<MesKurUye> GetMeskurUyeByID(int id);
        MesKurUye GetByID(int id);
        void MeskurUyeAdd(MesKurUye meskurUye);
        void MeskurUyeUpdate(MesKurUye meskurUye);
        void MeskurUyeDelete(MesKurUye meskurUye);
    }
}
