using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IGuncelYazilarService
	{
        List<GuncelYazilar> GetAll();
        List<GuncelYazilar> GetOrderByDate();
        List<GuncelYazilar> GetGuncelYazilarByID(int id);
        GuncelYazilar GetByID(int id);
        void GuncelYazilarAdd(GuncelYazilar guncelYazilar);
        void GuncelYazilarUpdate(GuncelYazilar guncelYazilar);
        void GuncelYazilarDelete(GuncelYazilar guncelYazilar);
    }
}
