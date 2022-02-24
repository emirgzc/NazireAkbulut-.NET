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
	public class KonusmaciManager : IKonusmaciService
	{
		IKonusmaciDal _konusmaciDal;

		public KonusmaciManager(IKonusmaciDal konusmaciDal)
		{
			_konusmaciDal = konusmaciDal;
		}

		public void KonusmaciAdd(Konusmaci konusmaci)
		{
			_konusmaciDal.Add(konusmaci);
		}

		public void KonusmaciDelete(Konusmaci konusmaci)
		{
			_konusmaciDal.Delete(konusmaci);
		}

		public void KonusmaciUpdate(Konusmaci konusmaci)
		{
			_konusmaciDal.Update(konusmaci);
		}

		public List<Konusmaci> GetKonusmaciByID(int id)
		{
			return _konusmaciDal.GetAll(x => x.KonusmaciID == id);
		}

		public List<Konusmaci> GetAll()
		{
			return _konusmaciDal.GetAll();
		}

		public Konusmaci GetByID(int id)
		{
			return _konusmaciDal.Get(x => x.KonusmaciID == id);
		}
	}
}
