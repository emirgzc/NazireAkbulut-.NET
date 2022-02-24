using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IYayUluslararsBildirService
	{
        List<YayUluslararsBildir> GetAll();
        /*List<YayUluslararsBildir> GetOrderByDate();*/
        List<YayUluslararsBildir> GetYayUluslararsBildirByID(int id);
        YayUluslararsBildir GetByID(int id);
        void YayUluslararsBildirAdd(YayUluslararsBildir yayUluslararsBildir);
        void YayUluslararsBildirUpdate(YayUluslararsBildir yayUluslararsBildir);
        void YayUluslararsBildirDelete(YayUluslararsBildir yayUluslararsBildir);
    }
}
