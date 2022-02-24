using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IGazeteDergiService
	{
        List<GazeteDergi> GetAll();
        /*List<GazeteDergi> GetOrderByDate();*/
        List<GazeteDergi> GetGazeteDergiByID(int id);
        GazeteDergi GetByID(int id);
        void GazeteDergiAdd(GazeteDergi gazeteDergi);
        void GazeteDergiUpdate(GazeteDergi gazeteDergi);
        void GazeteDergiDelete(GazeteDergi gazeteDergi);
    }
}
