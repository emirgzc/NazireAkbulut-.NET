using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IAkacemikCVService
	{
        List<AkacemikCV> GetAll();
        /*List<Atiflar> GetOrderByDate();*/
        List<AkacemikCV> GetAkacemikCVByID(int id);
        AkacemikCV GetByID(int id);
        void AkacemikCVAdd(AkacemikCV akacemikCV);
        void AkacemikCVUpdate(AkacemikCV akacemikCV);
        void AkacemikCVDelete(AkacemikCV akacemikCV);
    }
}
