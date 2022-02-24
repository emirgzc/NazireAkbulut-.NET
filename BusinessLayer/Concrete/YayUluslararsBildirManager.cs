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
	public class YayUluslararsBildirManager : IYayUluslararsBildirService
	{
		IYayUluslararsBildirDal _yayUluslararsBildirDal;

		public YayUluslararsBildirManager(IYayUluslararsBildirDal yayUluslararsBildirDal)
		{
			_yayUluslararsBildirDal = yayUluslararsBildirDal;
		}

		public void YayUluslararsBildirAdd(YayUluslararsBildir yayUluslararsBildir)
		{
			_yayUluslararsBildirDal.Add(yayUluslararsBildir);
		}

		public void YayUluslararsBildirDelete(YayUluslararsBildir yayUluslararsBildir)
		{
			_yayUluslararsBildirDal.Delete(yayUluslararsBildir);
		}

		public void YayUluslararsBildirUpdate(YayUluslararsBildir yayUluslararsBildir)
		{
			_yayUluslararsBildirDal.Update(yayUluslararsBildir);
		}

		public List<YayUluslararsBildir> GetYayUluslararsBildirByID(int id)
		{
			return _yayUluslararsBildirDal.GetAll(x => x.YayUluslararsBildirID == id);
		}

		public List<YayUluslararsBildir> GetAll()
		{
			return _yayUluslararsBildirDal.GetAll();
		}

		public YayUluslararsBildir GetByID(int id)
		{
			return _yayUluslararsBildirDal.Get(x => x.YayUluslararsBildirID == id);
		}

	}
}
