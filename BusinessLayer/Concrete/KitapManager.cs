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
	public class KitapManager : IKitapService
	{
		IKitapDal _kitapDal;

		public KitapManager(IKitapDal kitapDal)
		{
			_kitapDal = kitapDal;
		}
		public List<Kitap> GetAll()
		{
			return _kitapDal.GetAll();
		}

		public Kitap GetByID(int id)
		{
			return _kitapDal.Get(x => x.KitapID == id);
		}

		public List<Kitap> GetKitapByID(int id)
		{
			return _kitapDal.GetAll(x => x.KitapID == id);
		}

		public List<Kitap> GetOrderByDate()
		{
			return _kitapDal.GetAll().OrderByDescending(z => z.KitapDate).ToList();
		}

		public void KitapAdd(Kitap kitap)
		{
			_kitapDal.Add(kitap);
		}

		public void KitapDelete(Kitap kitap)
		{
			_kitapDal.Delete(kitap);
		}

		public void KitapUpdate(Kitap kitap)
		{
			_kitapDal.Update(kitap);
		}
	}
}
