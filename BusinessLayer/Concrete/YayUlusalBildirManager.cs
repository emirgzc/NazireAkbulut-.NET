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
	public class YayUlusalBildirManager : IYayUlusalBildirService
	{
		IYayUlusalBildirDal _yayUlusalBildiriDal;

		public YayUlusalBildirManager(IYayUlusalBildirDal yayUlusalBildiriDal)
		{
			_yayUlusalBildiriDal = yayUlusalBildiriDal;
		}

		public void YayUlusalBildirAdd(YayUlusalBildir yayUlusalBildir)
		{
			_yayUlusalBildiriDal.Add(yayUlusalBildir);
		}

		public void YayUlusalBildirDelete(YayUlusalBildir yayUlusalBildiri)
		{
			_yayUlusalBildiriDal.Delete(yayUlusalBildiri);
		}

		public void YayUlusalBildirUpdate(YayUlusalBildir yayUlusalBildiri)
		{
			_yayUlusalBildiriDal.Update(yayUlusalBildiri);
		}

		public List<YayUlusalBildir> GetYayUlusalBildirByID(int id)
		{
			return _yayUlusalBildiriDal.GetAll(x => x.YayUlusalBildirID == id);
		}

		public List<YayUlusalBildir> GetAll()
		{
			return _yayUlusalBildiriDal.GetAll();
		}

		public YayUlusalBildir GetByID(int id)
		{
			return _yayUlusalBildiriDal.Get(x => x.YayUlusalBildirID == id);
		}
	}
}
