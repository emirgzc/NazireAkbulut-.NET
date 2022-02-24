using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class MesKurUyeManager : IMesKurUyeService
	{
		IMesKurUyeDal _mesKurUyeDal;

		public MesKurUyeManager(IMesKurUyeDal mesKurUyeDal)
		{
			_mesKurUyeDal = mesKurUyeDal;
		}

		public void MeskurUyeAdd(MesKurUye mesKurUye)
		{
			_mesKurUyeDal.Add(mesKurUye);
		}		

		public List<MesKurUye> GetAll()
		{
			return _mesKurUyeDal.GetAll();
		}

		public MesKurUye GetByID(int id)
		{
			return _mesKurUyeDal.Get(x => x.MesKurId == id);
		}

		public List<MesKurUye> GetMeskurUyeByID(int id)
		{
			return _mesKurUyeDal.GetAll(x => x.MesKurId == id);
		}

		public void MeskurUyeUpdate(MesKurUye meskurUye)
		{
			_mesKurUyeDal.Update(meskurUye);
		}

		public void MeskurUyeDelete(MesKurUye meskurUye)
		{
			_mesKurUyeDal.Delete(meskurUye);
		}
	}
}
