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
	public class MakaleManager : IMakaleService
	{
		IMakaleDal _makaleDal;

		public MakaleManager(IMakaleDal makaleDal)
		{
			_makaleDal = makaleDal;
		}
		public List<Makale> GetAll()
		{
			return _makaleDal.GetAll();
		}

		public Makale GetByID(int id)
		{
			return _makaleDal.Get(x => x.MakaleID == id);
		}

		public List<Makale> GetMakaleByID(int id)
		{
			return _makaleDal.GetAll(x => x.MakaleID == id);
		}

		public List<Makale> GetOrderByDate()
		{
			return _makaleDal.GetAll().OrderByDescending(z => z.MakaleDate).ToList();
		}

		public void MakaleAdd(Makale kitap)
		{
			_makaleDal.Add(kitap);
		}

		public void MakaleDelete(Makale kitap)
		{
			_makaleDal.Delete(kitap);
		}

		public void MakaleUpdate(Makale kitap)
		{
			_makaleDal.Update(kitap);
		}
	}
}
