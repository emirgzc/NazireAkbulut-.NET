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
	public class GazeteDergiManager : IGazeteDergiService
	{
		IGazeteDergiDal _gazeteDergiDal;

		public GazeteDergiManager(IGazeteDergiDal gazeteDergiDal)
		{
			_gazeteDergiDal = gazeteDergiDal;
		}

		public void GazeteDergiAdd(GazeteDergi gazeteDergi)
		{
			_gazeteDergiDal.Add(gazeteDergi);
		}

		public void GazeteDergiDelete(GazeteDergi gazeteDergi)
		{
			_gazeteDergiDal.Delete(gazeteDergi);
		}

		public void GazeteDergiUpdate(GazeteDergi gazeteDergi)
		{
			_gazeteDergiDal.Update(gazeteDergi);
		}

		public List<GazeteDergi> GetGazeteDergiByID(int id)
		{
			return _gazeteDergiDal.GetAll(x => x.GazID == id);
		}

		public List<GazeteDergi> GetAll()
		{
			return _gazeteDergiDal.GetAll();
		}

		public GazeteDergi GetByID(int id)
		{
			return _gazeteDergiDal.Get(x => x.GazID == id);
		}
	}
}
