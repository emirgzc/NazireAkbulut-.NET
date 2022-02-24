using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IAtiflarService
	{
        List<Atiflar> GetAll();
        /*List<Atiflar> GetOrderByDate();*/
        List<Atiflar> GetAtiflarByID(int id);
        Atiflar GetByID(int id);
        void AtiflarAdd(Atiflar atiflar);
        void AtiflarUpdate(Atiflar atiflar);
        void AtiflarDelete(Atiflar atiflar);
    }
}
