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
	public class SemKonBilDanKurUyeManager : ISemKonBilDanKurUyeService
	{
		ISemKonBilDanKurUyeDal _semKonBilDanKurUyeDal;

		public SemKonBilDanKurUyeManager(ISemKonBilDanKurUyeDal semKonBilDanKurUyeDal)
		{
			_semKonBilDanKurUyeDal = semKonBilDanKurUyeDal;
		}

		public void SemKonBilDanKurUyeAdd(SemKonBilDanKurUye semKonBilDanKurUye)
		{
			_semKonBilDanKurUyeDal.Add(semKonBilDanKurUye);
		}

		public void SemKonBilDanKurUyeDelete(SemKonBilDanKurUye semKonBilDanKurUye)
		{
			_semKonBilDanKurUyeDal.Delete(semKonBilDanKurUye);
		}

		public void SemKonBilDanKurUyeUpdate(SemKonBilDanKurUye semKonBilDanKurUye)
		{
			_semKonBilDanKurUyeDal.Update(semKonBilDanKurUye);
		}

		public List<SemKonBilDanKurUye> GetSemKonBilDanKurUyeByID(int id)
		{
			return _semKonBilDanKurUyeDal.GetAll(x => x.SemID == id);
		}

		public List<SemKonBilDanKurUye> GetAll()
		{
			return _semKonBilDanKurUyeDal.GetAll();
		}

		public SemKonBilDanKurUye GetByID(int id)
		{
			return _semKonBilDanKurUyeDal.Get(x => x.SemID == id);
		}
	}
}
