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
	public class GuncelYazilarManager : IGuncelYazilarService
	{
		IGuncelYazilarDal _guncelYazilarDal;

		public GuncelYazilarManager(IGuncelYazilarDal guncelYazilarDal)
		{
			_guncelYazilarDal = guncelYazilarDal;
		}

		public void GuncelYazilarAdd(GuncelYazilar guncelYazilar)
		{
			_guncelYazilarDal.Add(guncelYazilar);
		}

		public void GuncelYazilarDelete(GuncelYazilar guncelYazilar)
		{
			_guncelYazilarDal.Delete(guncelYazilar);
		}

		public void GuncelYazilarUpdate(GuncelYazilar guncelYazilar)
		{
			_guncelYazilarDal.Update(guncelYazilar);
		}

		public List<GuncelYazilar> GetGuncelYazilarByID(int id)
		{
			return _guncelYazilarDal.GetAll(x => x.YaziID == id);
		}

		public List<GuncelYazilar> GetAll()
		{
			return _guncelYazilarDal.GetAll();
		}

		public GuncelYazilar GetByID(int id)
		{
			return _guncelYazilarDal.Get(x => x.YaziID == id);
		}

		public List<GuncelYazilar> GetOrderByDate()
		{
			return _guncelYazilarDal.GetAll().OrderByDescending(z=>z.DateYazi).ToList();
		}
	}
}
