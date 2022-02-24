using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IOturumBaskanlikService
	{
        List<OturumBaskanlik> GetAll();
        /*List<OturumBaskanlik> GetOrderByDate();*/
        List<OturumBaskanlik> GetOturumBaskanlikByID(int id);
        OturumBaskanlik GetByID(int id);
        void OturumBaskanlikAdd(OturumBaskanlik oturumBaskanlik);
        void OturumBaskanlikUpdate(OturumBaskanlik oturumBaskanlik);
        void OturumBaskanlikDelete(OturumBaskanlik oturumBaskanlik);
    }
}
