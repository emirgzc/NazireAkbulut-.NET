using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IMakaleService
	{
        List<Makale> GetAll();
        List<Makale> GetOrderByDate();
        List<Makale> GetMakaleByID(int id);
        Makale GetByID(int id);
        void MakaleAdd(Makale makale);
        void MakaleUpdate(Makale makale);
        void MakaleDelete(Makale makale);
    }
}
