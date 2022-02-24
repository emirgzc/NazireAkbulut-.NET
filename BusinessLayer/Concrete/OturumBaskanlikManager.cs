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
	public class OturumBaskanlikManager : IOturumBaskanlikService
	{
		IOturumBaskanlikDal _oturumBaskanlikDal;

		public OturumBaskanlikManager(IOturumBaskanlikDal oturumBaskanlikDal)
		{
			_oturumBaskanlikDal = oturumBaskanlikDal;
		}

		public void OturumBaskanlikAdd(OturumBaskanlik oturumBaskanlik)
		{
			_oturumBaskanlikDal.Add(oturumBaskanlik);
		}

		public void OturumBaskanlikDelete(OturumBaskanlik oturumBaskanlik)
		{
			_oturumBaskanlikDal.Delete(oturumBaskanlik);
		}

		public void OturumBaskanlikUpdate(OturumBaskanlik oturumBaskanlik)
		{
			_oturumBaskanlikDal.Update(oturumBaskanlik);
		}

		public List<OturumBaskanlik> GetOturumBaskanlikByID(int id)
		{
			return _oturumBaskanlikDal.GetAll(x => x.OturumBaskanlikID == id);
		}

		public List<OturumBaskanlik> GetAll()
		{
			return _oturumBaskanlikDal.GetAll();
		}

		public OturumBaskanlik GetByID(int id)
		{
			return _oturumBaskanlikDal.Get(x => x.OturumBaskanlikID == id);
		}
	}
}
