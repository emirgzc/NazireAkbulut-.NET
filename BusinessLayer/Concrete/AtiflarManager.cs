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
	public class AtiflarManager : IAtiflarService
	{
		IAtiflarDal _atiflarDal;

		public AtiflarManager(IAtiflarDal atiflarDal)
		{
			_atiflarDal = atiflarDal;
		}

		public void AtiflarAdd(Atiflar atiflar)
		{
			_atiflarDal.Add(atiflar);
		}

		public void AtiflarDelete(Atiflar atiflar)
		{
			_atiflarDal.Delete(atiflar);
		}

		public void AtiflarUpdate(Atiflar atiflar)
		{
			_atiflarDal.Update(atiflar);
		}

		public List<Atiflar> GetAtiflarByID(int id)
		{
			return _atiflarDal.GetAll(x => x.AtiflarID == id);
		}

		public List<Atiflar> GetAll()
		{
			return _atiflarDal.GetAll();
		}

		public Atiflar GetByID(int id)
		{
			return _atiflarDal.Get(x => x.AtiflarID == id);
		}
	}
}
