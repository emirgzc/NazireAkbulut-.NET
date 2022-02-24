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
	public class AkacemikCVManager : IAkacemikCVService
	{
		IAkacemikCVDal _akademikCVDal;

		public AkacemikCVManager(IAkacemikCVDal akademikCVDal)
		{
			_akademikCVDal = akademikCVDal;
		}

		public void AkacemikCVAdd(AkacemikCV akademikCV)
		{
			_akademikCVDal.Add(akademikCV);
		}

		public void AkacemikCVDelete(AkacemikCV akademikCV)
		{
			_akademikCVDal.Delete(akademikCV);
		}

		public void AkacemikCVUpdate(AkacemikCV akademikCV)
		{
			_akademikCVDal.Update(akademikCV);
		}

		public List<AkacemikCV> GetAkacemikCVByID(int id)
		{
			return _akademikCVDal.GetAll(x => x.CvID == id);
		}

		public List<AkacemikCV> GetAll()
		{
			return _akademikCVDal.GetAll();
		}

		public AkacemikCV GetByID(int id)
		{
			return _akademikCVDal.Get(x => x.CvID == id);
		}
	}
}
